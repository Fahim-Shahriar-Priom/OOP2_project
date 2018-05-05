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
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        public Form8()
        {
            InitializeComponent();
        }
        
        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 logd = new Form6();
            logd.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
        }

        void UpdateGridView()
        {
            PatientDataContext up = new PatientDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Priom\Downloads\c#\Private_Clinic - Copy\Private_Clinic\Clinic.mdf;Integrated Security=True;Connect Timeout=30");
            metroGrid1.DataSource = up.Patients;

        }
        

        private void metroButton2_Click(object sender, EventArgs e)
        {
            PatientDataContext dbp = new PatientDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Priom\Downloads\c#\Private_Clinic - Copy\Private_Clinic\Clinic.mdf;Integrated Security=True;Connect Timeout=30");
            var x=from a in dbp.Patients
                  select a;
             dbp.SubmitChanges();
            metroGrid1.DataSource = x.ToList();

            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateGridView();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 regu = new Form4();
            regu.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 regd = new Form10();
            regd.Show();
            UpdateGridView();
            

        }
    }
}
