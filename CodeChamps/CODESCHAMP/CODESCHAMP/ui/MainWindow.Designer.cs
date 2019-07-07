namespace CODESCHAMP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_indexNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_indexNumber = new MaterialSkin.Controls.MaterialLabel();
            this.btn_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_reset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_resetlistOfIndexNumbers = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_submitListOfIndexNumbers = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_listOfIndexNumbers = new MaterialSkin.Controls.MaterialLabel();
            this.txt_listOfIndexNumbers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "2018 Advanced Level Results";
            // 
            // txt_indexNumber
            // 
            this.txt_indexNumber.Depth = 0;
            this.txt_indexNumber.Hint = "";
            this.txt_indexNumber.Location = new System.Drawing.Point(192, 116);
            this.txt_indexNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_indexNumber.Name = "txt_indexNumber";
            this.txt_indexNumber.PasswordChar = '\0';
            this.txt_indexNumber.SelectedText = "";
            this.txt_indexNumber.SelectionLength = 0;
            this.txt_indexNumber.SelectionStart = 0;
            this.txt_indexNumber.Size = new System.Drawing.Size(165, 23);
            this.txt_indexNumber.TabIndex = 1;
            this.txt_indexNumber.UseSystemPasswordChar = false;
            // 
            // lbl_indexNumber
            // 
            this.lbl_indexNumber.AutoSize = true;
            this.lbl_indexNumber.Depth = 0;
            this.lbl_indexNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_indexNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_indexNumber.Location = new System.Drawing.Point(54, 117);
            this.lbl_indexNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_indexNumber.Name = "lbl_indexNumber";
            this.lbl_indexNumber.Size = new System.Drawing.Size(101, 19);
            this.lbl_indexNumber.TabIndex = 3;
            this.lbl_indexNumber.Text = "Index Number";
            // 
            // btn_submit
            // 
            this.btn_submit.Depth = 0;
            this.btn_submit.Location = new System.Drawing.Point(83, 178);
            this.btn_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Primary = true;
            this.btn_submit.Size = new System.Drawing.Size(75, 35);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Depth = 0;
            this.btn_reset.Location = new System.Drawing.Point(210, 178);
            this.btn_reset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Primary = true;
            this.btn_reset.Size = new System.Drawing.Size(75, 35);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // btn_resetlistOfIndexNumbers
            // 
            this.btn_resetlistOfIndexNumbers.Depth = 0;
            this.btn_resetlistOfIndexNumbers.Location = new System.Drawing.Point(210, 352);
            this.btn_resetlistOfIndexNumbers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_resetlistOfIndexNumbers.Name = "btn_resetlistOfIndexNumbers";
            this.btn_resetlistOfIndexNumbers.Primary = true;
            this.btn_resetlistOfIndexNumbers.Size = new System.Drawing.Size(75, 35);
            this.btn_resetlistOfIndexNumbers.TabIndex = 10;
            this.btn_resetlistOfIndexNumbers.Text = "Reset";
            this.btn_resetlistOfIndexNumbers.UseVisualStyleBackColor = true;
            this.btn_resetlistOfIndexNumbers.Click += new System.EventHandler(this.Btn_resetlistOfIndexNumbers_Click);
            // 
            // btn_submitListOfIndexNumbers
            // 
            this.btn_submitListOfIndexNumbers.Depth = 0;
            this.btn_submitListOfIndexNumbers.Location = new System.Drawing.Point(83, 352);
            this.btn_submitListOfIndexNumbers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_submitListOfIndexNumbers.Name = "btn_submitListOfIndexNumbers";
            this.btn_submitListOfIndexNumbers.Primary = true;
            this.btn_submitListOfIndexNumbers.Size = new System.Drawing.Size(75, 35);
            this.btn_submitListOfIndexNumbers.TabIndex = 9;
            this.btn_submitListOfIndexNumbers.Text = "Submit";
            this.btn_submitListOfIndexNumbers.UseVisualStyleBackColor = true;
            this.btn_submitListOfIndexNumbers.Click += new System.EventHandler(this.Btn_submitListOfIndexNumbers_Click);
            // 
            // lbl_listOfIndexNumbers
            // 
            this.lbl_listOfIndexNumbers.AutoSize = true;
            this.lbl_listOfIndexNumbers.Depth = 0;
            this.lbl_listOfIndexNumbers.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_listOfIndexNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_listOfIndexNumbers.Location = new System.Drawing.Point(34, 267);
            this.lbl_listOfIndexNumbers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_listOfIndexNumbers.Name = "lbl_listOfIndexNumbers";
            this.lbl_listOfIndexNumbers.Size = new System.Drawing.Size(156, 19);
            this.lbl_listOfIndexNumbers.TabIndex = 8;
            this.lbl_listOfIndexNumbers.Text = "List of Index Numbers";
            // 
            // txt_listOfIndexNumbers
            // 
            this.txt_listOfIndexNumbers.Location = new System.Drawing.Point(223, 264);
            this.txt_listOfIndexNumbers.Name = "txt_listOfIndexNumbers";
            this.txt_listOfIndexNumbers.Size = new System.Drawing.Size(155, 68);
            this.txt_listOfIndexNumbers.TabIndex = 11;
            this.txt_listOfIndexNumbers.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 421);
            this.Controls.Add(this.txt_listOfIndexNumbers);
            this.Controls.Add(this.btn_resetlistOfIndexNumbers);
            this.Controls.Add(this.btn_submitListOfIndexNumbers);
            this.Controls.Add(this.lbl_listOfIndexNumbers);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_indexNumber);
            this.Controls.Add(this.txt_indexNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Text = "Doenets.lk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_indexNumber;
        private MaterialSkin.Controls.MaterialLabel lbl_indexNumber;
        private MaterialSkin.Controls.MaterialRaisedButton btn_submit;
        private MaterialSkin.Controls.MaterialRaisedButton btn_reset;
        private MaterialSkin.Controls.MaterialRaisedButton btn_resetlistOfIndexNumbers;
        private MaterialSkin.Controls.MaterialRaisedButton btn_submitListOfIndexNumbers;
        private MaterialSkin.Controls.MaterialLabel lbl_listOfIndexNumbers;
        private System.Windows.Forms.RichTextBox txt_listOfIndexNumbers;
    }
}

