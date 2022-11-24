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
   
    public partial class ViewDoctors : Form
    {
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\MyWork.mdf;Integrated Security=True;Connect Timeout=30";
        public ViewDoctors()
        {
            InitializeComponent();
        }
        

        private void ViewDoctors_Load(object sender, EventArgs e)
        {


        }

        private void View_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Doctors", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv2.DataSource = dtbl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminOptions ss = new AdminOptions();
            ss.Show();
        }
    }
}
