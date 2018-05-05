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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Reg = new Form3();
            Reg.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
