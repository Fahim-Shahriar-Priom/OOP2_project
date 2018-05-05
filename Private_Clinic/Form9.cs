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
    public partial class Form9 : MetroFramework.Forms.MetroForm
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 logp = new Form7();
            logp.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 reg = new Form5();
            reg.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DoctorDataContext dbp = new DoctorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Priom\Downloads\c#\Private_Clinic - Copy\Private_Clinic\Clinic.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in dbp.Doctors
                    select a;
            dbp.SubmitChanges();
            metroGrid1.DataSource = x.ToList();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            DoctorDataContext dbp = new DoctorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Priom\Downloads\c#\Private_Clinic - Copy\Private_Clinic\Clinic.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in dbp.Doctors
                    where a.Type==metroComboBox1.Text
                    select a;
           
            metroGrid1.DataSource = x.ToList();
        

        }
        void UpdateGridView()
        {
            DoctorDataContext up = new DoctorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Priom\Downloads\c#\Private_Clinic - Copy\Private_Clinic\Clinic.mdf;Integrated Security=True;Connect Timeout=30");
            metroGrid1.DataSource = up.Doctors;

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
