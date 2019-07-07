using System;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using CODESCHAMP.ui;
using System.Collections;

namespace CODESCHAMP
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        private static Boolean flag = false;

        private static ArrayList resultList;

        private static string fileSelected;

        private static ArrayList sortedList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            flag = false;
            // get index number from user input
            String indexNumber = txt_indexNumber.Text;
            // Regular expression for index number
            Regex regex = new Regex("^[0-9]+$");
            if (indexNumber == "") // when user submit with empty feild
            {
                // show the error message
                MessageBox.Show("Please enter your index number!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!regex.IsMatch(indexNumber)) // When index number format invalid
            {
                MessageBox.Show("index number must consists only numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // url for retrive results from doenet.lk 
                String url = "https://doenets.lk/result/service/AlResult/" + indexNumber;
                // send request to the doenets.lk
                GetRequest(url);   
            }
            
        }

        async static void GetRequest(String url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage httpResponseMessage = await client.GetAsync(url))
                {
                    using (HttpContent content = httpResponseMessage.Content)
                    {
                        // Response
                        string data = await content.ReadAsStringAsync();
                        // Response convert to JSON
                        JObject json = JObject.Parse(data);
                        // when user submit Only One Index number
                        if (flag == false)
                        {
                            if (json.GetValue("indexNo").ToString() != "") // Valid Index Number
                            {
                                Results results = new Results(json);
                                results.Show();
                            }
                            else
                            {
                                MessageBox.Show("Please enter valid index number!"); // Invalid Index Number
                            }
                        }
                        else // When user submit list of Index numbers
                        {
                            if (json.GetValue("indexNo").ToString() != "") // Valid Index Number
                            {
                                resultList.Add(json); // Add JObject  to resultList(ArrayList)
                            }
                        }
                    }
                }
            }
        }

        private static void writeDataIntoTextFile()
        {
            // Open the windows Explorer to select the text file path
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\"; // set default location deive C:
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // set file formats
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK) // when text file selected
                {
                    fileSelected  = openFileDialog1.FileName; // save path
                }
            }

            if (fileSelected != "" || fileSelected != null)
            {
                try
                {
                    // writing results into selected text file
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@fileSelected))
                    {

                        // Write the result in descending order by z-score
                        for (int i=sortedList.Count-1;i>=0;i--)
                        {
                            file.WriteLine("Name : " + ((JObject) sortedList[i]).GetValue("name").ToString());
                            file.WriteLine("Index Number : " + ((JObject)sortedList[i]).GetValue("indexNo").ToString());
                            file.WriteLine("Z-Score : " + ((JObject)sortedList[i]).GetValue("zScore").ToString());
                            file.WriteLine("District Rank : " + ((JObject)sortedList[i]).GetValue("districtRank").ToString());
                            file.WriteLine("Island Rank : " + ((JObject)sortedList[i]).GetValue("islandRank").ToString());
                            file.WriteLine("Stream : " + ((JObject)sortedList[i]).GetValue("stream").ToString());
                            file.WriteLine("Subjects");

                            Array subjects = ((JObject)sortedList[i]).GetValue("subjectResults").ToArray();
                            for (int j = 0; j < subjects.Length; j++)
                            {
                                JObject json = JObject.Parse(subjects.GetValue(j).ToString());

                                String subjectName = json.GetValue("subjectName").ToString();
                                String subjectResult = json.GetValue("subjectResult").ToString();

                                file.WriteLine("\t" + subjectName + "\t" + subjectResult);
                            }

                            file.WriteLine();
                            file.WriteLine();
                        }
                    }
                    MessageBox.Show("Results Saved");

                }
                catch(Exception ex)
                {
                    // do nothing
                }
            }    
             
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            txt_indexNumber.Clear();
        }

        private void Btn_resetlistOfIndexNumbers_Click(object sender, EventArgs e)
        {
            txt_listOfIndexNumbers.Clear();
        }

        private void Btn_submitListOfIndexNumbers_Click(object sender, EventArgs e)
        {
            flag = true;
            resultList = new ArrayList(); // Initialize the resultList ArrayList
            Regex regex = new Regex("^([0-9]+,)*[0-9]+$"); // Regular expression for validated User Input
            // ,123,123     Invalid
            // 123,123,     Invalid
            // ASD,123      Invalid
            // 123,123      Valid
            String listOfIndexNumbers = txt_listOfIndexNumbers.Text;
            if (listOfIndexNumbers == "")  // when user submit with empty feild
            {
                MessageBox.Show("Please enter your index numbers list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!regex.IsMatch(listOfIndexNumbers)) // when invalid user input
            {
                MessageBox.Show("Invalid Input Format!\nIndex Numbers must be seperated by commas and only numbers.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                String[] indexNumbers = listOfIndexNumbers.Split(','); // Split by comma
                foreach (String indexNumber in indexNumbers)
                {
                    String url = "https://doenets.lk/result/service/AlResult/" + indexNumber; // create URL according to index number
                    GetRequest(url); // send GET request to the doenets.lk
                }
                MessageBox.Show("Results retrive successfully!");
                orderByZScore(); // Sort by Z-Score in ascending order
                writeDataIntoTextFile(); // Write results in text file 
            }
        }

        private void orderByZScore() // Method to sort the Result List by Z-Score in ascending order
        {
            sortedList = new ArrayList(); // Initialize the arraylist
            var list =  resultList.Cast<JObject>().OrderBy(item => Double.Parse(item.GetValue("zScore").ToString())); // sort by Z-Score
            foreach(JObject jObject in list)
            {
                sortedList.Add(jObject);
            }
        }
    }
}
