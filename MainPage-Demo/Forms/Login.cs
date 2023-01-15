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

        Controller controllerObj;
        public Login_Form()
        {
            InitializeComponent();
            controllerObj = new Controller();
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
            //DONE: check username & password ( SelectUser() )
            string Username = username.Text;
            string Password = password.Text;
            DataTable dt = controllerObj.SelectSystemUser(Username, Password);
            if (dt == null)
            {
                MessageBox.Show("Invalid User");
                return;
            }

            if (dt.Rows[0][2].ToString() == "123456")
            {
                Form childForm = new ChangePassword(Username);
                childForm.Show();
            }
            else
            {
                bool admin = (bool)dt.Rows[0][0];
                if (admin)
                    OpenChildForm(new adminView());
                else
                    OpenChildForm(new TellerView(Username));
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

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Select();
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void visible_CheckedChanged(object sender, EventArgs e)
        {
            if (visible.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
