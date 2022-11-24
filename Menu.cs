using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineHealthCare
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdminLogIn1 ss = new AdminLogIn1();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientLogIn ss = new PatientLogIn();
            ss.Show();
        }

        private void Doctorlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorLogIn ss = new DoctorLogIn();
            ss.Show();
        }
    }
}
