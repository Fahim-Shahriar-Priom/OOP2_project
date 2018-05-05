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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "Patient")
            {
                this.Hide();
                Form5 regp = new Form5();
                regp.Show();
            }
            else if (metroComboBox1.Text == "Doctor")
            {
                this.Hide();
                Form4 regd = new Form4();
                regd.Show();
            }
            else
            {
                MessageBox.Show("Invalid or null input");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
