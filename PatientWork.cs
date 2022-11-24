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
    public partial class PatientWork : Form
    {
       
        public PatientWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Documents\MyWork.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "Select * From Doctors Where Type='" + typecomboBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;

        }

        private void next_Click(object sender, EventArgs e)
        {
            
        }
    }
}
