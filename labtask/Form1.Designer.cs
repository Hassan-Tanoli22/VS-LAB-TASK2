
namespace labtask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.etxtname = new System.Windows.Forms.TextBox();
            this.etxtemail = new System.Windows.Forms.TextBox();
            this.etxtaddress = new System.Windows.Forms.TextBox();
            this.etxtphonenumber = new System.Windows.Forms.TextBox();
            this.etxtdesignation = new System.Windows.Forms.TextBox();
            this.etxtemployecode = new System.Windows.Forms.TextBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.StudentRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.resetbtn = new System.Windows.Forms.Button();
            this.searchid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(71, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(71, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Designation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(71, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Employe Code";
            // 
            // etxtname
            // 
            this.etxtname.Location = new System.Drawing.Point(287, 80);
            this.etxtname.Name = "etxtname";
            this.etxtname.Size = new System.Drawing.Size(164, 23);
            this.etxtname.TabIndex = 7;
            // 
            // etxtemail
            // 
            this.etxtemail.Location = new System.Drawing.Point(287, 124);
            this.etxtemail.Name = "etxtemail";
            this.etxtemail.Size = new System.Drawing.Size(164, 23);
            this.etxtemail.TabIndex = 8;
            this.etxtemail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // etxtaddress
            // 
            this.etxtaddress.Location = new System.Drawing.Point(287, 159);
            this.etxtaddress.Name = "etxtaddress";
            this.etxtaddress.Size = new System.Drawing.Size(164, 23);
            this.etxtaddress.TabIndex = 9;
            // 
            // etxtphonenumber
            // 
            this.etxtphonenumber.Location = new System.Drawing.Point(287, 200);
            this.etxtphonenumber.Name = "etxtphonenumber";
            this.etxtphonenumber.Size = new System.Drawing.Size(164, 23);
            this.etxtphonenumber.TabIndex = 10;
            // 
            // etxtdesignation
            // 
            this.etxtdesignation.Location = new System.Drawing.Point(287, 243);
            this.etxtdesignation.Name = "etxtdesignation";
            this.etxtdesignation.Size = new System.Drawing.Size(164, 23);
            this.etxtdesignation.TabIndex = 11;
            this.etxtdesignation.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // etxtemployecode
            // 
            this.etxtemployecode.Location = new System.Drawing.Point(287, 295);
            this.etxtemployecode.Name = "etxtemployecode";
            this.etxtemployecode.Size = new System.Drawing.Size(164, 23);
            this.etxtemployecode.TabIndex = 12;
            // 
            // insertbtn
            // 
            this.insertbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertbtn.Location = new System.Drawing.Point(71, 344);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(75, 28);
            this.insertbtn.TabIndex = 13;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatebtn.Location = new System.Drawing.Point(178, 344);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 28);
            this.updatebtn.TabIndex = 14;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Searchbtn.Location = new System.Drawing.Point(275, 344);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 28);
            this.Searchbtn.TabIndex = 15;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.Location = new System.Drawing.Point(376, 344);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 28);
            this.deletebtn.TabIndex = 16;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // StudentRecordDataGridView
            // 
            this.StudentRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecordDataGridView.Location = new System.Drawing.Point(480, 80);
            this.StudentRecordDataGridView.Name = "StudentRecordDataGridView";
            this.StudentRecordDataGridView.RowTemplate.Height = 25;
            this.StudentRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentRecordDataGridView.Size = new System.Drawing.Size(412, 234);
            this.StudentRecordDataGridView.TabIndex = 17;
            this.StudentRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordDataGridView_CellClick);
            this.StudentRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // resetbtn
            // 
            this.resetbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetbtn.Location = new System.Drawing.Point(480, 344);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 28);
            this.resetbtn.TabIndex = 18;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // searchid
            // 
            this.searchid.AutoSize = true;
            this.searchid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchid.Location = new System.Drawing.Point(71, 38);
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(71, 19);
            this.searchid.TabIndex = 19;
            this.searchid.Text = "Search ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(287, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 23);
            this.txtID.TabIndex = 20;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(904, 468);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.searchid);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.StudentRecordDataGridView);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.etxtemployecode);
            this.Controls.Add(this.etxtdesignation);
            this.Controls.Add(this.etxtphonenumber);
            this.Controls.Add(this.etxtaddress);
            this.Controls.Add(this.etxtemail);
            this.Controls.Add(this.etxtname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox etxtname;
        private System.Windows.Forms.TextBox etxtemail;
        private System.Windows.Forms.TextBox etxtaddress;
        private System.Windows.Forms.TextBox etxtphonenumber;
        private System.Windows.Forms.TextBox etxtdesignation;
        private System.Windows.Forms.TextBox etxtemployecode;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView StudentRecordDataGridView;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label searchid;
        private System.Windows.Forms.TextBox txtID;
    }
}

