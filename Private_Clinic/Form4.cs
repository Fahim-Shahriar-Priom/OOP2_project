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
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DoctorDataContext dd = new DoctorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Priom\Downloads\c#\Private_Clinic - Copy\Private_Clinic\Clinic.mdf;Integrated Security=True;Connect Timeout=30");
            if (metroTextBox2.Text != "" && metroTextBox6.Text != "")
            {
                Doctor d = new Doctor
                {

                    Name = metroTextBox1.Text,
                    E_mail = metroTextBox2.Text,
                    Age = int.Parse(metroTextBox3.Text),
                    Gender = metroComboBox1.Text,
                    Address = metroTextBox4.Text,
                    Type = metroComboBox2.Text,
                    Password = metroTextBox6.Text
                };


                dd.Doctors.InsertOnSubmit(d);
                dd.SubmitChanges();


                MessageBox.Show("You are Registered ");
                this.Hide();
                Form1 menu = new Form1();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Invalid value ");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 reg = new Form3();
            reg.Show();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            DoctorDataContext up = new DoctorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Priom\Downloads\c#\Private_Clinic - Copy\Private_Clinic\Clinic.mdf;Integrated Security=True;Connect Timeout=30");
            var x = up.Doctors.Where(a => a.E_mail == metroTextBox2.Text).Count();
            if (x != 0 && metroTextBox2.Text != "")
            {
                var z = up.Doctors.Where(a => a.E_mail == metroTextBox2.Text);
                z.First().Name = metroTextBox1.Text;
                z.First().Age = int.Parse(metroTextBox3.Text);
                z.First().Gender = metroComboBox1.Text;
                z.First().Address = metroTextBox4.Text;
                z.First().Password = metroTextBox6.Text;
                z.First().Type = metroComboBox2.Text;
                up.SubmitChanges();


                MessageBox.Show("Your data is updated ");
                this.Hide();
                Form2 login = new Form2();
                login.Show();
            }
            else
            {
                MessageBox.Show("Invalid value ");
            }

        }
    }
}
