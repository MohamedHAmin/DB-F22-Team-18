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
using System.Text.RegularExpressions;

namespace MainPage_Demo.Forms
{
    public partial class CreateCustomer : Form
    {
        private Form activeForm;
        Controller controllerObj;
        public CreateCustomer()
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

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);

            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if(!Regex.IsMatch(Name.Text, @"^[a-zA-Z]+$"))
            {
                flag = true;
                Name.Text = "First Name";
                Name.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(lastname.Text, @"^[a-zA-Z]+$"))
            {
                flag = true;
                lastname.Text = "Last Name";
                lastname.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(Phone.Text, @"^[0-9]{11}$"))
            {
                flag = true;
                Phone.Text = "Phone Number";
                Phone.ForeColor = Color.Red;
            }
            if (flag)
            {
                MessageBox.Show("Please enter a valid arguments");
            }
            else
            {
                //DONE - check if exist in db (SelectCustomer), if not Insert custmer in db (InsertCustomer)
                //check if custmer in db
                DataTable dt = controllerObj.SelectCustomer(Phone.Text);
                if (dt != null)
                {
                    MessageBox.Show("Customer already exist");                    
                }
                else
                {
                    int result = controllerObj.InsertCustomer(Name.Text, lastname.Text, Phone.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("The insertion of a new customer failed");
                    }
                    else
                    {
                        MessageBox.Show("Customer profile created successfully!");
                    }
                    
                }
                this.Close();
            }
        }

        private void Name_Enter(object sender, EventArgs e)
        {
            if (Name.Text == "First Name")
            {
                Name.Text = "";
                Name.ForeColor = Color.Black;
            }
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if (Name.Text == "")
            {
                Name.Text = "First Name";
                Name.ForeColor = Color.Silver;
            }
        }

        private void Phone_Enter(object sender, EventArgs e)
        {
            if (Phone.Text == "Phone Number")
            {
                Phone.Text = "";
                Phone.ForeColor = Color.Black;
            }
        }

        private void Phone_Leave(object sender, EventArgs e)
        {
            if (Phone.Text == "")
            {
                Phone.Text = "Phone Number";
                Phone.ForeColor = Color.Silver;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (lastname.Text == "Last Name")
            {
                lastname.Text = "";
                lastname.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (lastname.Text == "")
            {
                lastname.Text = "Lasr Name";
                lastname.ForeColor = Color.Silver;
            }
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
