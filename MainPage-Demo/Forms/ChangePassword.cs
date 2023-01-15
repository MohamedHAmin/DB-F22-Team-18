using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage_Demo.Forms
{
    public partial class ChangePassword : Form
    {
        string username;
        Controller controllerObj;
        public ChangePassword(string Username)
        {
            username = Username;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);

            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        }

        private void set_Click(object sender, EventArgs e)
        {
            if(NewPassword.Text == "123456" || NewPassword.Text.Length > 12 || NewPassword.Text.Length < 6)
            {
                MessageBox.Show("Invalid Password");
            }
            else
            {
                int result = controllerObj.UpdateSystemUser(username, NewPassword.Text);
                if (result == 0)
                {
                    MessageBox.Show("Faild to set password, please try again");
                }
                else
                {
                    MessageBox.Show("Password updated, please login again with your new password");
                    this.Close();
                }
            }
        }

        private void NewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (visible.Checked)
            {
                NewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                NewPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
