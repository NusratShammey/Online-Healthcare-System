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
    public partial class PatientLogIn : Form
    {
        public PatientLogIn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                string name = mynameTextBox.Text;
                int age = Convert.ToInt32(myageTextBox.Text);
            string Gender = mygenderComboBox.Text;
            string Mobile = mymobileTextBox.Text;
            string Email = myemailTextBox.Text;
            string Pass = mypassTextBox.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\MyWork.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
            cmd.CommandText = "insert into Patient values('" + name + "','" + age + "','" + Gender + "','" + Mobile + "','" + Email + "','" + Pass + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet d4 = new DataSet();
                DA.Fill(d4);
            }
            catch (Exception)
            {
                MessageBox.Show("Give proper information");
            }
            mynameTextBox.Clear();
            myageTextBox.Clear();
            mygenderComboBox.ResetText();
            mymobileTextBox.Clear();
            myemailTextBox.Clear();
            mypassTextBox.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlogIn ss = new PlogIn();
            ss.Show();
        }
    }
}
