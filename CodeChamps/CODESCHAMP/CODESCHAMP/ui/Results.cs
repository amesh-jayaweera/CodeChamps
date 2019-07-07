using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace CODESCHAMP.ui
{
    public partial class Results : MetroFramework.Forms.MetroForm
    {

        private String name;
        private String indexNumber;
        private String zScore;
        private String districtRank;
        private String islandRank;
        private String stream;
        private Array subjectResults;

        public Results(JObject jObject) // Set Values which retrive from doenets.lk 
        {
            InitializeComponent();
            name = jObject.GetValue("name").ToString();
            indexNumber = jObject.GetValue("indexNo").ToString();
            zScore = jObject.GetValue("zScore").ToString();
            districtRank = jObject.GetValue("districtRank").ToString();
            islandRank = jObject.GetValue("islandRank").ToString();
            stream = jObject.GetValue("stream").ToString();
            subjectResults = jObject.GetValue("subjectResults").ToArray();
        }

        private void Results_Load(object sender, EventArgs e) // place values in Result form
        {
            lbl_name.Text = name;
            lbl_indexNumber.Text = indexNumber;
            lbl_zScore.Text = zScore;
            lbl_distrctRank.Text = districtRank;
            lbl_islandRank.Text = islandRank;
            lbl_stream.Text = stream;
            for (int i = 0; i < subjectResults.Length; i++)
            {
                JObject json = JObject.Parse(subjectResults.GetValue(i).ToString());

                String subjectName = json.GetValue("subjectName").ToString(); // get subject name
                String subjectResult = json.GetValue("subjectResult").ToString(); // get result for the subject
                // Assume AL Student can take only maximum 6 Subjects
                if(i == 0)
                {
                    lbl_s1.Text = subjectName;
                    lbl_r1.Text = subjectResult;
                }else if(i == 1)
                {
                    lbl_s2.Text = subjectName;
                    lbl_r2.Text = subjectResult;
                }
                else if (i == 2)
                {
                    lbl_s3.Text = subjectName;
                    lbl_r3.Text = subjectResult;
                }
                else if (i == 3)
                {
                    lbl_s4.Text = subjectName;
                    lbl_r4.Text = subjectResult;
                }
                else if (i == 4)
                {
                    lbl_s5.Text = subjectName;
                    lbl_r5.Text = subjectResult;
                }
                else if (i == 5)
                {
                    lbl_s6.Text = subjectName;
                    lbl_r6.Text = subjectResult;
                }
            }
        }

    }
}
