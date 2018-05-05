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
    public partial class Form10 : MetroFramework.Forms.MetroForm
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            PatientDataContext del = new PatientDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Priom\Downloads\c#\Private_Clinic - Copy\Private_Clinic\Clinic.mdf;Integrated Security=True;Connect Timeout=30");

                //var x = from a in del.Patients
                //where a.E_mail == metroTextBox2.Text
                // select a;
                var x = del.Patients.Where(a => a.E_mail == metroTextBox2.Text).Count();
                if (x != 0 && metroTextBox2.Text != "")
                {
                    var z = del.Patients.Where(a => a.E_mail == metroTextBox2.Text);
                    foreach (Patient p in z)
                    {
                        del.Patients.DeleteOnSubmit(p);
                    }
                    del.SubmitChanges();

                    MessageBox.Show("Your data deleted");
                    this.Hide();
                    Form8 details = new Form8();
                    details.Show();
                }
                else
                {
                    MessageBox.Show("Input  valid value ");
                }
            

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 details = new Form8();
            details.Show();
        }
    }
}
