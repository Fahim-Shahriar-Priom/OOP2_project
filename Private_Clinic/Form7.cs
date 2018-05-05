using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Private_Clinic
{
    public partial class Form7 : MetroFramework.Forms.MetroForm
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 log = new Form2();
            log.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            PatientDataContext log = new PatientDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Priom\Downloads\c#\Private_Clinic - Copy\Private_Clinic\Clinic.mdf;Integrated Security=True;Connect Timeout=30");
            var x = log.Patients.Where(a=>a.E_mail == metroTextBox1.Text && a.Password == metroTextBox2.Text).Count();
            if (x != 0 && metroTextBox1.Text != "" && metroTextBox2.Text != "") 
            {
                this.Hide();
                Form9 pinfo = new Form9();
                pinfo.Show();
            }
            else
            {
                MessageBox.Show("invalid Please try again ");
            }
            
        }
    }
}
