using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace MainPage_Demo.Forms { 
    public partial class Order : Form
    {
        private Form activeForm;
        public Order()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            activeForm = childForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (!Regex.IsMatch(firstname.Text, @"^[a-zA-Z]+$"))
            {
                flag = true;
                firstname.Text = "First Name";
                firstname.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(lastname.Text, @"^[a-zA-Z]+$"))
            {
                flag = true;
                lastname.Text = "Last Name";
                lastname.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(phone.Text, @"^[0-9]{11}$") || !phone.Text.StartsWith("01"))
            {
                flag = true;
                phone.Text = "Phone Number";
                phone.ForeColor = Color.Red;
            }
            if (flag)
            {
                MessageBox.Show("Please enter a valid arguments");
            }
            else
            {
                //TODO - check if exist in db (SelectCustomer), if not Insert custmer in db (InsertCustomer)
                MessageBox.Show("Customer created");
                firstname.Text = "First Name";
                firstname.ForeColor = Color.Silver;
                lastname.Text = "Last Name";
                lastname.ForeColor = Color.Silver;
                phone.Text = "Phone Number";
                phone.ForeColor = Color.Silver;
                OpenChildForm(new Forms.PlaceOrder());
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PhoneNumber.Text=="")
            {
                MessageBox.Show("Please enter user's ID or user's phone number to search for user.","Empty search fields");
            }
            else if ((PhoneNumber.Text.Length < 11 || !PhoneNumber.Text.StartsWith("01")))
            {
                MessageBox.Show(String.Format("{0} is an invalid mobile number.\nPlease enter a valid mobile number and try again.",PhoneNumber.Text),"Invalid mobile number");
                PhoneNumber.Text = "";
            }
            else
            {
                PhoneNumber.Text = "";
                OpenChildForm(new Forms.PlaceOrder());
            }
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    button2_Click(sender, e);
            //}
        }

        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}