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


namespace PBOApp
{
    public partial class register : Form
    {
        public Point mouseLocation;
        string connectionString = @"Data Source=DESKTOP-8G644J1\SQLEXPRESS;Initial Catalog=PBO;Integrated Security=True";
        public register()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            if (text_username.Text == "" || text_password.Text == "")
                MessageBox.Show("Please fill the box");
            else if (text_password.Text != text_confirm.Text)
                MessageBox.Show("Password do not match");
            else
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    //..
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@username", text_username.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@age", text_age.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", text_password.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    Clear();


                }
            }
        }
        void Clear()
        {
            text_username.Text = text_age.Text = text_password.Text = text_confirm.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mousePose.X, mousePose.Y);
                Location = mousePose;
            }
        }
    }
}
