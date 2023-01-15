using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.Data;

namespace MainPage_Demo.Forms { 
    public partial class Order : Form
    {
        private Form activeForm;
        Controller controllerObj;
        string tellerName;
        public Order(string name)
        {
            InitializeComponent();
            controllerObj = new Controller();
            tellerName = name;
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
                //DONE - check if exist in db (SelectCustomer), if not Insert custmer in db (InsertCustomer)
                DataTable dt = controllerObj.SelectCustomer(phone.Text);
                if (dt != null)
                {
                    MessageBox.Show("Customer already exist");
                }
                else
                {
                    int result = controllerObj.InsertCustomer(firstname.Text, lastname.Text, phone.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("The insertion of a new customer failed");
                    }
                    else
                    {
                        MessageBox.Show("Customer profile created successfully!");
                    }

                }
                
                dt = controllerObj.SelectCustomer(phone.Text);
                if (dt != null)
                {
                    string customerName = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
                    int numOfOrders = (int)dt.Rows[0][2];
                    int customerid = (int)dt.Rows[0][4];
                    OpenChildForm(new Forms.PlaceOrder(customerName, customerid, numOfOrders, tellerName));

                }
                else
                {
                    MessageBox.Show("Error please try again");
                }
                firstname.Text = "First Name";
                firstname.ForeColor = Color.Silver;
                lastname.Text = "Last Name";
                lastname.ForeColor = Color.Silver;
                phone.Text = "Phone Number";
                phone.ForeColor = Color.Silver;
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
            if (PhoneNumber.Text == "")
            {
                MessageBox.Show("Please enter user's ID or user's phone number to search for user.", "Empty search fields");
            }
            else if ((PhoneNumber.Text.Length < 11 || !PhoneNumber.Text.StartsWith("01")))
            {
                MessageBox.Show(String.Format("{0} is an invalid mobile number.\nPlease enter a valid mobile number and try again.", PhoneNumber.Text), "Invalid mobile number");
                PhoneNumber.Text = "";
            }
            else
            {
                
                DataTable dt = controllerObj.SelectCustomer(PhoneNumber.Text);
                if (dt != null)
                {
                    string customerName = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
                    int numOfOrders = (int)dt.Rows[0][2];
                    int customerid = (int)dt.Rows[0][4];
                    OpenChildForm(new Forms.PlaceOrder(customerName, customerid, numOfOrders, tellerName));

                }
                else
                {
                    MessageBox.Show("Error please try again");
                }
                PhoneNumber.Text = "";
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

        private void firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lastname.Select();
            }
        }

        private void lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                phone.Select();
            }
        }

        private void phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}