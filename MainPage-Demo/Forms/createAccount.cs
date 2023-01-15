using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace MainPage_Demo.Forms
{
    public partial class createAccount : Form
    {
        private Form activeForm;
        Controller controllerObj;
        public createAccount()
        {
            InitializeComponent();
            controllerObj = new Controller();
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
            OpenChildForm(new Forms.CreateCustomer());
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
            //this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(ID.Text=="" && PhoneNumber.Text=="")
            //{
            //    MessageBox.Show("Please enter user's ID or user's phone number to search for user.","Empty search fields");
            //}
            //else if ((PhoneNumber.Text.Length < 11 || !PhoneNumber.Text.StartsWith("01")) && ID.Text=="")
            //{
            //    MessageBox.Show(String.Format("{0} is an invalid mobile number.\nPlease enter a valid mobile number and try again.",PhoneNumber.Text),"Invalid mobile number");
            //    PhoneNumber.Text = "";
            //}
            //else
            //{
            //    ID.Text = "";
            //    PhoneNumber.Text = "";
            //    OpenChildForm(new Forms.PlaceOrder());
            //}
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
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void PhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    button2_Click(sender, e);
            //}
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void newworker_Click(object sender, EventArgs e)
        {
            int employees_no = controllerObj.countworkers();
            OpenChildForm(new Forms.CreateWorker(ref employees_no));
        }

        private void newuser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CreateUser());
        }
    }
}