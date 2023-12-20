using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            double mass = Double.Parse(weightBox.Text);
            double meter = Double.Parse(heightBox.Text);
            double penyebut = meter*meter/10000;
            double bmi = mass / penyebut;
            label7.Text = bmi.ToString();
            if (bmi < 18.5)
                hasil.Text = "You are UnderWeight";
            else if (bmi >= 18.5 && bmi < 29.9)
                hasil.Text = "Your Body look Ideal";
            else
                hasil.Text = "You are OverWeight";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            workout f3 = new workout();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
