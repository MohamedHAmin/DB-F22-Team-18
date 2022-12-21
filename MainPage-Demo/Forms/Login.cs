using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage_Demo.Forms
{
    public partial class Login_Form : Form
    {
        private Form activeForm;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            activeForm = childForm;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: check username & password ( SelectUser() )
            if(username.Text == "admin" && password.Text == "1234" /*&& isadmin = true*/)
            {
                OpenChildForm(new adminView());
            }
            
            else if(username.Text == "teller" && password.Text == "1234" /*&& isadmin != true*/){
                OpenChildForm(new TellerView());
            }
            
            else
            {
                MessageBox.Show("Please enter a valid Username & Password");
            }
            username.Text = "Username";
            username.ForeColor = Color.Silver;
            password.Text = "Password";
            password.ForeColor = Color.Silver;
            password.UseSystemPasswordChar = false;
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if(username.Text == "Username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.Silver;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.ForeColor = Color.Silver;
                password.UseSystemPasswordChar = false;
            }
        }
    }
}
