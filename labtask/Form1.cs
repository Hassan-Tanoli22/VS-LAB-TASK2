using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labtask
{
    public partial class Form1 : Form
    {
        DbCon db = new DbCon();
        public Form1()
        {
            InitializeComponent();
        }
        public int StudentID;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
            ResetFormControl();

        }

        private void GetStudentRecord()
        {
            string qry = "Select * from Employes";
            DataTable dt = db.Search(qry);
            if (dt != null)
            {
                StudentRecordDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String qry = String.Format("insert into employes values name='{0}', email='{1}', address='{2}', phonenumber={3}, designation='{4}', employecode={5}", etxtname.Text, etxtemail.Text, etxtaddress.Text, etxtphonenumber.Text, etxtdesignation.Text, etxtemployecode.Text) ;
            
            String qry= "insert into employes (name,email,address,phonenumber,designation,employecode) values ('"+etxtname.Text+ "', '" + etxtemail.Text + "', '" + etxtaddress.Text + "', '" + etxtphonenumber.Text + "', '" + etxtdesignation.Text + "', '" + etxtemployecode.Text + "')";

            if (db.UDI(qry))
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Data not inserted");
            }
            GetStudentRecord();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                String qry = "update employes set name= '"+etxtname.Text+"', email='"+etxtemail.Text+"', address='"+etxtaddress.Text+"', phonenumber='"+etxtphonenumber.Text+"', designation='"+etxtdesignation.Text+"' ,employecode='"+etxtemployecode.Text+"' where StudentID=  '"+this.StudentID+"'";





                if (db.UDI(qry))
                {
                    MessageBox.Show("Data updated");
                }
                else
                {
                    MessageBox.Show("Data not updated");
                }
                GetStudentRecord();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                String qry = "Delete from employes  where StudentID=  '" + this.StudentID + "'";





                if (db.UDI(qry))
                {
                    MessageBox.Show("Data Deleted");
                }
                else
                {
                    MessageBox.Show("Data not Deleted");
                }
                GetStudentRecord();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ResetFormControl();

        }

        private void ResetFormControl()
        {
            StudentID = 0;
            etxtname.Clear();
            etxtemail.Clear();
            etxtaddress.Clear();
            etxtphonenumber.Clear();
            etxtdesignation.Clear();
            etxtemployecode.Clear();
        }

        private void StudentRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(StudentRecordDataGridView.SelectedRows[0].Cells[0].Value);

            etxtname.Text = StudentRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            etxtemail.Text = StudentRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            etxtaddress.Text = StudentRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            etxtphonenumber.Text = StudentRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            etxtdesignation.Text = StudentRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            etxtemployecode.Text = StudentRecordDataGridView.SelectedRows[0].Cells[6].Value.ToString();





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string qry = "Select * from employes where StudentID='" + txtID.Text + "'";
            DataTable dt = db.Search(qry);
            if (dt != null)
            {
                etxtname.Text = dt.Rows[0]["name"].ToString();
                etxtemail.Text = dt.Rows[0]["email"].ToString();
                etxtaddress.Text = dt.Rows[0]["address"].ToString();
                etxtphonenumber.Text = dt.Rows[0]["phonenumber"].ToString();
                etxtdesignation.Text = dt.Rows[0]["designation"].ToString();
                etxtemployecode.Text = dt.Rows[0]["employecode"].ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }
    }
}
