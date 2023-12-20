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
    public partial class Form1 : Form
    {
        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();
           
        }
        void IncreaseOpacity(object sender, EventArgs e)
        {
       
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8G644J1\SQLEXPRESS;Initial Catalog=PBO;Integrated Security=True");

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM regisTable WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0) 
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;
                    

                    login f2 = new login();
                    f2.Show();
                    Hide();


                }

                else
                {
                    MessageBox.Show("Invalid Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Invalid login");
            }

            finally
            {
                conn.Close();

            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            register f2 = new register();
            f2.Show();
            Hide();
        }

        private void button_login_MouseEnter(object sender, EventArgs e)
        {
            button_login.ForeColor = Color.White;
        }

        private void button_login_MouseLeave(object sender, EventArgs e)
        {
            button_login.ForeColor = Color.Black;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register f2 = new register();
            f2.Show();
            Hide();
        }

        private void button_clear_MouseEnter(object sender, EventArgs e)
        {
            button_clear.ForeColor = Color.White;
        }

        private void button_clear_MouseLeave(object sender, EventArgs e)
        {
            button_clear.ForeColor = Color.Black;
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mousePose.X, mousePose.Y);
                Location = mousePose;
            }
        }
    }
}
