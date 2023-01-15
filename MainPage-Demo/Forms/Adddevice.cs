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
    public partial class Adddevice : Form
    {
        Controller controllerObj = new Controller();
        int device_no;
        public Adddevice(ref int device)
        {
            InitializeComponent();
            device_no = device;
        }
        private void AddDevice_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        }

        private void create_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if (devicename.Text ==""|| devicename.Text.Any(Char.IsDigit)) //ezay akhly yinclude spaces
            {
                flag = true;
                devicename.Text = "Device name ";
                devicename.ForeColor = Color.Red;
            }

            //if (!Regex.IsMatch(deviceid.Text, @"^[0-9]+$"))
            //{
            //    flag = true;
            //    deviceid.Text = "Device Id";
            //    deviceid.ForeColor = Color.Red;
            //}
        
            if (flag)
            {
                MessageBox.Show("Please enter a valid arguments");
            }
            else
            {
                //TODO - check if exist in db (SelectAccountByUsername), if not Insert Teller in db (InsertTeller) and create account with password 123456 (InsertAccount)
                MessageBox.Show("device added");
                controllerObj.insert_device( devicename.Text.ToString());
                device_no++;
                this.Close();
            }
        }
        private void devicename_Enter(object sender, EventArgs e)
        {
            if (devicename.Text == "Device name")
            {
                devicename.Text = "";
                devicename.ForeColor = Color.Black;
            }
        }

        private void devicename_Leave(object sender, EventArgs e)
        {
            if (devicename.Text == "")
            {
                devicename.Text = "Device name";
                devicename.ForeColor = Color.Silver;
            }
        }
        private void deviceid_Enter(object sender, EventArgs e)
        {
            //if (deviceid.Text == "Device Id")
            //{
            //    deviceid.Text = "";
            //    deviceid.ForeColor = Color.Black;
            //}
        }

        private void deviceid_Leave(object sender, EventArgs e)
        {
            //if (deviceid.Text == "")
            //{
            //    deviceid.Text = "Device Id";
            //    deviceid.ForeColor = Color.Silver;
            //}
        }
        private void deviceid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void devicename_Enter_1(object sender, EventArgs e)
        {
            if (devicename.Text == "Device Name")
            {
                devicename.Text = "";
                devicename.ForeColor = Color.Black;
            }
        }

        private void devicename_Leave_1(object sender, EventArgs e)
        {
            if (devicename.Text == "")
            {
                devicename.Text = "Device Name";
                devicename.ForeColor = Color.Silver;
            }
        }

        private void deviceid_Enter_1(object sender, EventArgs e)
        {
            //if (deviceid.Text == "Device ID")
            //{
            //    deviceid.Text = "";
            //    deviceid.ForeColor = Color.Black;
            //}
        }

        private void deviceid_Leave_1(object sender, EventArgs e)
        {
            //if (deviceid.Text == "")
            //{
            //    deviceid.Text = "Device ID";
            //    deviceid.ForeColor = Color.Silver;
            //}
        }
    }
}
