using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineHealthCare
{
    public partial class DoctorLogIn : Form
    {
        public DoctorLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Documents\MyWork.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "Select * From Doctors Where ID='" + idTextBox.Text.Trim() + "' and Name ='" + nameTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                // Form2 ss = new Form2();

                //ss.Show();
                DoctorWork ob1 = new DoctorWork();
                ob1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please double check your Username and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
