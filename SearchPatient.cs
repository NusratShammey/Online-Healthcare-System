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
    public partial class SearchPatient : Form
    {
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\MyWork.mdf;Integrated Security=True;Connect Timeout=30";
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void GetPatient_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Patient", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgView.DataSource = dtbl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            SearchPatient2 ss = new SearchPatient2();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorWork ss = new DoctorWork();
            ss.Show();

        }
    }
}
