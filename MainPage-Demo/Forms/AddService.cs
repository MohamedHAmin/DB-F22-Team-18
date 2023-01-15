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
    
    public partial class AddService : Form
    {
        Controller controllerObj = new Controller();
        int service_no;
        public AddService(ref int service)
        {
            InitializeComponent();
            service_no = service;
        }

        private void AddService_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);

            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        }

        private void addservice_Load(object sender, EventArgs e)
        {

        }
        
       
        private void create_Click(object sender, EventArgs e)
        {
            bool flag = false;
            
            if (servicename.Text=="" || servicename.Text.Any(Char.IsDigit)) //ezay akhly yinclude spaces
            {
                flag = true;
                servicename.Text = "Service name ";
                servicename.ForeColor = Color.Red;
            }
            
            if (!Regex.IsMatch(serviceduration.Text, @"^[0-9]+$"))
            {
                flag = true;
                serviceduration.Text ="Service Duration";
                serviceduration.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(discount.Text, @"^[0-9]+$"))
            {
                flag = true;
                serviceduration.Text = "Discount";
                serviceduration.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(price.Text, @"^[0-9]+$"))
            {
                flag = true;
                serviceduration.Text = "Price";
                serviceduration.ForeColor = Color.Red;
            }
           
            if (price.Text.Length < 2 || price.Text.Length > 6 || price.Text == "Price")
            {
                flag = true;
                price.Text = "Price";
                price.ForeColor = Color.Red;
            }
            if (discount.Text.Length < 1 || discount.Text.Length > 3 || discount.Text == "Discount")
            {
                flag = true;
                price.Text = "Discount";
                price.ForeColor = Color.Red;
            }
            if (serviceduration.Text.Length < 2 || serviceduration.Text.Length > 6 || serviceduration.Text == "Price")
            {
                flag = true;
                price.Text = "Service Duration";
                price.ForeColor = Color.Red;
            }
            if (flag)
            {
                MessageBox.Show("Please enter a valid arguments");
            }
            else
            {
                //TODO - check if exist in db (SelectAccountByUsername), if not Insert Teller in db (InsertTeller) and create account with password 123456 (InsertAccount)
                MessageBox.Show("Service added");
                controllerObj.insert_service(Int16.Parse(discount.Text), Int16.Parse(price.Text), Int16.Parse(serviceduration.Text), servicename.Text.ToString());
                service_no++;
                this.Close();
            }
        }
        private void servicename_Enter(object sender, EventArgs e)
        {
            if (servicename.Text == "Service name")
            {
                servicename.Text = "";
                servicename.ForeColor = Color.Black;
            }
        }

        private void servicename_Leave(object sender, EventArgs e)
        {
            if (servicename.Text == "")
            {
                servicename.Text = "Service name";
                servicename.ForeColor = Color.Silver;
            }
        }
        private void serviceduration_Enter(object sender, EventArgs e)
        {
            if (serviceduration.Text == "Service Duration")
            {
                serviceduration.Text = "";
                serviceduration.ForeColor = Color.Black;
            }
        }
 
        private void serviceduration_Leave(object sender, EventArgs e)
        {
            if (serviceduration.Text == "")
            {
                serviceduration.Text = "Service Duration";
                serviceduration.ForeColor = Color.Silver;
            }
        }

        private void price_Enter(object sender, EventArgs e)
        {
            if (price.Text == "Price")
            {
                price.Text = "";
                price.ForeColor = Color.Black;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void price_Leave(object sender, EventArgs e)
        {
            if (price.Text == "")
            {
                price.Text = "Price";
                price.ForeColor = Color.Silver;
            }
        }

        private void discount_Enter(object sender, EventArgs e)
        {
            if (discount.Text == "Discount")
            {
                discount.Text = "";
                discount.ForeColor = Color.Black;
            }
        }

        private void discount_Leave(object sender, EventArgs e)
        {
            if (discount.Text == "")
            {
                discount.Text = "Discount";
                discount.ForeColor = Color.Silver;
            }
        }

        private void discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void serviceduration_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
