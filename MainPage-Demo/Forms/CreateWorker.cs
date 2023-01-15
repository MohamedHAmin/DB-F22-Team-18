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
    public partial class CreateWorker : Form
    {
        Controller controllerObj;
        int listSize_employees;
        public CreateWorker(ref int listSize_employee)
        {
            controllerObj = new Controller();
            InitializeComponent();
            listSize_employees = listSize_employee;
        }

        private void goBack_MouseHover(object sender, EventArgs e)
        {
            goBack.BackColor = Color.White;
        }

        private void goBack_MouseLeave(object sender, EventArgs e)
        {
            goBack.BackColor = Color.Transparent;
        }

        private void goBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void CrateWorker_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);

            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        }

        private void firstname_Enter(object sender, EventArgs e)
        {
            if (firstname.Text == "First Name")
            {
                firstname.Text = "";
                firstname.ForeColor = Color.Black;
            }
        }

        private void firstname_Leave(object sender, EventArgs e)
        {
            if (firstname.Text == "")
            {
                firstname.Text = "First Name";
                firstname.ForeColor = Color.Silver;
            }
        }

        private void lastname_Enter(object sender, EventArgs e)
        {
            if (lastname.Text == "Last Name")
            {
                lastname.Text = "";
                lastname.ForeColor = Color.Black;
            }
        }

        private void lastname_Leave(object sender, EventArgs e)
        {
            if (lastname.Text == "")
            {
                lastname.Text = "Last Name";
                lastname.ForeColor = Color.Silver;
            }
        }

        private void phone_Enter(object sender, EventArgs e)
        {
            if (phone.Text == "Phone Number")
            {
                phone.Text = "";
                phone.ForeColor = Color.Black;
            }
        }

        private void phone_Leave(object sender, EventArgs e)
        {
            if (phone.Text == "")
            {
                phone.Text = "Phone Number";
                phone.ForeColor = Color.Silver;
            }
        }

        private void ssn_Enter(object sender, EventArgs e)
        {
            if (ssn.Text == "SSN")
            {
                ssn.Text = "";
                ssn.ForeColor = Color.Black;
            }
        }

        private void ssn_Leave(object sender, EventArgs e)
        {
            if (ssn.Text == "")
            {
                ssn.Text = "SSN";
                ssn.ForeColor = Color.Silver;
            }
        }

        private void salary_Enter(object sender, EventArgs e)
        {
            if (salary.Text == "Salary")
            {
                salary.Text = "";
                salary.ForeColor = Color.Black;
            }
        }

        private void salary_Leave(object sender, EventArgs e)
        {
            if (salary.Text == "")
            {
                salary.Text = "Salary";
                salary.ForeColor = Color.Silver;
            }
        }

        private void create_Click(object sender, EventArgs e)
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
            if (!Regex.IsMatch(phone.Text, @"^[0-9]{11}$"))
            {
                flag = true;
                phone.Text = "Phone Number";
                phone.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(ssn.Text, @"^[0-9]{14}$"))
            {
                flag = true;
                ssn.Text = "SSN";
                ssn.ForeColor = Color.Red;
            }
            if (salary.Text.Length < 3 || salary.Text.Length > 7 || salary.Text == "Salary")
            {
                flag = true;
                salary.Text = "Salary";
                salary.ForeColor = Color.Red;
            }
            if (flag)
            {
                MessageBox.Show("Please enter a valid arguments");
            }
            else
            {
                //TODO - check if exist in db (SelectWorker), if not Insert custmer in db (InsertWorker)
                MessageBox.Show("Worker added");
                controllerObj.insert_worker(Int64.Parse(ssn.Text), Int64.Parse(phone.Text), firstname.Text, lastname.Text, Int16.Parse(salary.Text));
                this.Close();
            }
        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
