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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
       
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminOptions ss = new AdminOptions();
            ss.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTextBox.Text);
                string name = nameTextBox.Text;
                String type = typeComboBox.Text;
                string quali = QualiTextBox.Text;
                string gender = genderComboBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);
                string mobile = mobileTextBox.Text;
                string email = emailTextBox.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\MyWork.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Doctors values ('" + id + "','" + name + "','" + type + "','" + quali + "','" + gender + "','" + age + "','" + mobile + "','" + email + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet d5 = new DataSet();
                DA.Fill(d5);
            }
            catch(Exception)
            {
                MessageBox.Show("Give proper information");
            }
            idTextBox.Clear();
            nameTextBox.Clear();
            typeComboBox.ResetText();
            QualiTextBox.Clear();
            genderComboBox.ResetText();
            ageTextBox.Clear();
            mobileTextBox.Clear();
            emailTextBox.Clear();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\MyWork.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update  Doctors set Name='" + nameTextBox.Text + "',Type='" + typeComboBox.Text + "',Qualification='" + QualiTextBox.Text + "',Gender='" + genderComboBox.Text + "',Age='" + ageTextBox.Text + "',Mobile='" + mobileTextBox.Text + "',Email='" + emailTextBox.Text + "'where Id='" + idTextBox.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet d2 = new DataSet();
                DA.Fill(d2);
            }
            catch (Exception)
            {
                MessageBox.Show("Give proper information");
            }
            idTextBox.Clear();
            nameTextBox.Clear();
            typeComboBox.ResetText();
            QualiTextBox.Clear();
            genderComboBox.ResetText();
            ageTextBox.Clear();
            mobileTextBox.Clear();
            emailTextBox.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try { 
 
                int id = Convert.ToInt32(idTextBox.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\MyWork.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Doctors where Id='" + idTextBox.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet d5 = new DataSet();
                DA.Fill(d5);
            }
            catch (Exception)
            {
                MessageBox.Show("Give proper information");
            }
            idTextBox.Clear();
            nameTextBox.Clear();
            typeComboBox.ResetText();
            QualiTextBox.Clear();
            genderComboBox.ResetText();
            ageTextBox.Clear();
            mobileTextBox.Clear();
            emailTextBox.Clear();

        }
    }
}
