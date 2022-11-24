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
    public partial class SearchPatient2 : Form
    {
        public SearchPatient2()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Documents\MyWork.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "Select * From Patient Where Email ='" + mailTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
            SearchPatient ss = new SearchPatient();
            ss.Show();
        }
    }
}
