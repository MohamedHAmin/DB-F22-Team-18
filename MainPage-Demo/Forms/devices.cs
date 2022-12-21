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
        private int[] dbcapicity;
        private int[] dbmaintance;
        private int totaldevices = 0;
        string buttonsState = "";
        public devices()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
        }
        private void buttonActivation(bool state)
        {
            if (state == true)
            {
                discardButton.Enabled = true;
                discardButton.FlatStyle = FlatStyle.Flat;
                discardButton.BackColor = Color.LightCoral;
                discardButton.ForeColor = Color.FromArgb(33, 86, 118);
                saveButton.Enabled = true;
                saveButton.FlatStyle = FlatStyle.Flat;
                saveButton.BackColor = Color.LightGreen;
                saveButton.ForeColor = Color.FromArgb(33, 86, 118);
            }
            else
            {
                discardButton.Enabled = false;
                discardButton.FlatStyle = FlatStyle.Standard;
                discardButton.BackColor = Color.Silver;
                discardButton.ForeColor = Color.DimGray;
                saveButton.Enabled = false;
                saveButton.FlatStyle = FlatStyle.Standard;
                saveButton.BackColor = Color.Silver;
                saveButton.ForeColor = Color.DimGray;
            }
        }
        private void editPriceTitle_Click(object sender, EventArgs e)
        {

        }

        private GroupBox createdevice(String deviceName, Point position, string picture, int capicity,int time_to_maintence)
        {
            Label CapicityTemp = new Label();
            CapicityTemp.Text = "capicity";
            CapicityTemp.Location = new Point(18, 135);
            CapicityTemp.Size = new Size(60, 15);
            CapicityTemp.ForeColor = Color.FromArgb(33, 86, 118);
            CapicityTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);

            Label maintenceTemp = new Label();
            maintenceTemp.Text = "maintanace time";
            maintenceTemp.Location = new Point(18, 160);
            maintenceTemp.Size = new Size(120, 15);
            maintenceTemp.ForeColor = Color.FromArgb(33, 86, 118);
            maintenceTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);

            TextBox capicitytextBox = new TextBox();
            capicitytextBox.Text = capicity.ToString();
            capicitytextBox.Location = new Point(80, 135);
            capicitytextBox.Size = new Size(85, 20);
            capicitytextBox.TextChanged += capicityChangeCheck;
            //priceTextBox.TabStop = false;

            TextBox maintenceTextBox = new TextBox();
            maintenceTextBox.Text = time_to_maintence.ToString();
            maintenceTextBox.Location = new Point(140, 160);
            maintenceTextBox.Size = new Size(85, 20);
            maintenceTextBox.TextChanged += maintanceChangeCheck;

            Label deviceNameLabel = new Label();
            deviceNameLabel.Text = deviceName;
            deviceNameLabel.Location = new Point(72, 19);
            deviceNameLabel.ForeColor = Color.FromArgb(33, 86, 118);
            deviceNameLabel.Font = new Font("Lucida Bright", 10, FontStyle.Bold);

            PictureBox icon = new PictureBox();
            icon.ImageLocation = picture;
            icon.Location = new Point(60, 50);
            icon.Size = new Size(144, 144);

            GroupBox device = new GroupBox();
            device.Location = position;
            device.Size = new Size(230, 200);
            device.Tag = totaldevices;
            device.Controls.Add(CapicityTemp);
            device.Controls.Add(capicitytextBox);
            device.Controls.Add(maintenceTemp);
            device.Controls.Add(maintenceTextBox);
            device.Controls.Add(deviceNameLabel);
            device.Controls.Add(icon);



            return device;
        }

        private void productPanel_Paint(object sender, PaintEventArgs e)
        {
   
        }
    
        private void devices_Load(object sender, EventArgs e)
        {
            int listsize_devices = 10;
            Point origin = new Point(35, 3);
            Point pos = origin;
            int maxPerRow = 5;
            int counter = 0;
            dbcapicity = new int[listsize_devices];
            dbmaintance = new int[listsize_devices];
            for (int i = 0; i < listsize_devices; i++)
            {
                buttonsState += "0";
                dbcapicity[i] = 10;
                dbmaintance[i] = 30;
                string location_picture = "C:/college_items/database/databbase project/DB-F22-Team-18/MainPage-Demo/Resources/hair-dryer.png";
                GroupBox addeddevice = createdevice("device " + (i + 1).ToString(), pos, location_picture, dbcapicity[i], dbmaintance[i]); //Price and Name are obtained from product list
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

        private void capicityChangeCheck(object sender, EventArgs e)
        {
            TextBox capicitytextBox = sender as TextBox;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox product = (GroupBox)capicitytextBox.Parent;

            if (capicitytextBox.Text == dbcapicity[(int)product.Tag].ToString())
            //if a price is changed go check if it is the same as in the database
            {
                //if yess=> 
                char[] temp = buttonsState.ToCharArray();
                temp[(int)product.Tag] = '0';
                buttonsState = string.Join("", temp);

            }
            else
            {
                char[] temp = buttonsState.ToCharArray();
                temp[(int)product.Tag] = '1';
                buttonsState = string.Join("", temp);
            }

            if (buttonsState.Contains('1') == false)
            //if a price is changed go check if it is the same as in the database
            {
                buttonActivation(false);
            }
            else
            {
                buttonActivation(true);
            }
        }
        private void maintanceChangeCheck(object sender, EventArgs e)
        {
            TextBox MaintanceTextBox = sender as TextBox;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox product = (GroupBox)MaintanceTextBox.Parent;

            if (MaintanceTextBox.Text == dbmaintance[(int)product.Tag].ToString())
            //if a price is changed go check if it is the same as in the database
            {
                //if yess=> 
                char[] temp = buttonsState.ToCharArray();
                temp[(int)product.Tag] = '0';
                buttonsState = string.Join("", temp);

            }
            else
            {
                char[] temp = buttonsState.ToCharArray();
                temp[(int)product.Tag] = '1';
                buttonsState = string.Join("", temp);
            }

            if (buttonsState.Contains('1') == false)
            //if a price is changed go check if it is the same as in the database
            {
                buttonActivation(false);
            }
            else
            {
                buttonActivation(true);
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

        private void discardButton_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < totaldevices; i++)
            {
                GroupBox product = (GroupBox)productPanel.Controls[i];
                ((TextBox)product.Controls[1]).Text = dbcapicity[i].ToString();
                ((TextBox)product.Controls[3]).Text = dbmaintance[i].ToString();
                //((TextBox)product.Controls[1]).Text = dbPrices[(int)product.Tag].ToString();
                buttonActivation(false);
                //buttonsState = buttonsState.Replace('1', '0');
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            int flag1 = 0;
            int flag2 = 0;
            for (int i = 0; i < totaldevices; i++)
            {
                GroupBox product = (GroupBox)productPanel.Controls[i];
                String capicity = ((TextBox)product.Controls[1]).Text;
                String maintance = ((TextBox)product.Controls[3]).Text;
                if(capicity.All(Char.IsDigit) && capicity != "")
                { 
                   dbcapicity[i] = Int32.Parse(capicity);
                    flag1 = 1;
                }
                else
                {
                    MessageBox.Show("invalid capicity");
                    flag1 = 0;
                    
                }
                if(maintance.All(Char.IsDigit) && maintance != "")
                {
                    dbmaintance[i] = Int32.Parse(maintance);
                    flag2 = 1;
                }
                else
                {
                    MessageBox.Show("invalid maintence period");
                    flag2 = 0;
                }

                //dbPrices[(int)product.Tag] = Int32.Parse(price); //a3tked dyy kda byakhod el price w y3delo fy el database
                if(flag1==1 && flag2==1) 
                {
                        buttonActivation(false);
                        buttonsState = buttonsState.Replace('1', '0');
                    
                }
            }
        }
    }
}
