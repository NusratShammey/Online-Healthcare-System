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
    public partial class AdminLogIn1 : Form
    {
        public AdminLogIn1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Documents\MyWork.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "Select * From LogIn Where Username='" + nameTextBox.Text.Trim() + "' and Password ='" + passTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                // Form2 ss = new Form2();

                //ss.Show();
                AdminOptions ob1 = new AdminOptions();
                ob1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please double check your Username and password");
            }
        }
    }
    }

