using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace MainPage_Demo.Forms
{
    public partial class devices : Form
    {
       
        private int totaldevices = 0;
        private int devices_no = 0;

        Controller controllerObj;
        public devices()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            controllerObj = new Controller();
        }
      
        private void editPriceTitle_Click(object sender, EventArgs e)
        {

        }

        private GroupBox createdevice(String deviceName, Point position, string picture, int deviceid)
        
        {
          

            Label deviceNameLabel = new Label();
            deviceNameLabel.Text = deviceName;
            deviceNameLabel.Location = new Point(72, 19);
            deviceNameLabel.ForeColor = Color.FromArgb(33, 86, 118);
            deviceNameLabel.Font = new Font("Lucida Bright", 10, FontStyle.Bold);
            deviceNameLabel.Tag = totaldevices;

            PictureBox icon = new PictureBox();
            icon.ImageLocation = picture;
            icon.Location = new Point(60, 50);
            icon.Size = new Size(100, 100);

            Button remove = new Button();
            remove.Text = "Remove";
            remove.Location = new Point(45, 150);
            remove.Size = new Size(80, 25);
            remove.Visible = true;
            remove.Enabled = true;
            remove.Click += removedevice;
            remove.BackColor = Color.LightCoral;
            remove.ForeColor = Color.FromArgb(33, 86, 118);
            remove.Tag = totaldevices;

            GroupBox device = new GroupBox();
            device.Location = position;
            device.Size = new Size(230, 180);
            device.Tag = deviceid;
            device.Controls.Add(deviceNameLabel);
            device.Controls.Add(icon);
            device.Controls.Add(remove);

            return device;
        }

        private void productPanel_Paint(object sender, PaintEventArgs e)
        {
   
        }
    
        private void devices_Load(object sender, EventArgs e)
        {
            Point origin = new Point(35, 3);
            Point pos = origin;
            int maxPerRow = 4;
            int counter = 0;
            string devicename;
            int deviceid;
            DataTable dt = controllerObj.selectdevicesInfo();
            devices_no = dt.Rows.Count;
            for (int i = 0; i < devices_no; i++)
            {
                if (dt.Rows[i][2].ToString()=="False")
                {
                    devicename = dt.Rows[i][0].ToString();
                    deviceid = Int16.Parse(dt.Rows[i][1].ToString());
                    string location_picture = "D:/F22/DB/Project/DB-F22-Team-18/Images/hair-dryer.png";
                    GroupBox addeddevice = createdevice(devicename, pos, location_picture, deviceid); //Price and Name are obtained from product list
                    productPanel.Controls.Add(addeddevice);
                    totaldevices++;
                    counter++;
                    if (counter == maxPerRow)
                    {
                        pos.X = origin.X;
                        pos.Y += addeddevice.Height + 2;
                        counter = 0;
                    }
                    else
                    {
                        pos.X += addeddevice.Width + 5;
                    }
                }
            }  
        }
        private void set_background(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        }
        
        private void devices_Resize(object sender, PaintEventArgs e)
        {
            Refresh();
        }

        private void adddevice_button(object sender, EventArgs e)
        {
            Adddevice s = new Adddevice (ref totaldevices);
            s.Show();
        }
        private void removedevice(object sender, EventArgs e)
        {
            totaldevices--;
            Button remove = sender as Button;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox device = (GroupBox)remove.Parent;
            controllerObj.delete_device(Int32.Parse(device.Tag.ToString()));
            //areload el panel
        }
    }
}
