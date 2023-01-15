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
    public partial class Edit : Form
    {
        Controller controllerObj;
        private int totalServices=0;
        private int counter2 = 0;
        private String buttonsState;
        
        public Edit()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        //Button Activation Control Function
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

        //Creates a Product Box
        private GroupBox createProduct(int price, String serviceName, Point position, string picture, int offer, int time = 0)
        {
            Label priceTemp = new Label();
            priceTemp.Text = "Price:";
            priceTemp.Location = new Point(18, 203);
            priceTemp.Size = new Size(46, 15);
            priceTemp.ForeColor = Color.FromArgb(33, 86, 118);
            priceTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);
            priceTemp.Tag = totalServices;

            Label timeTemp = new Label();
            timeTemp.Text = "time:";
            timeTemp.Location = new Point(18, 250);
            timeTemp.Size = new Size(46, 15);
            timeTemp.ForeColor = Color.FromArgb(33, 86, 118);
            timeTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);
            timeTemp.Tag = totalServices;

            Label offerTemp = new Label();
            offerTemp.Text = "offer:";
            offerTemp.Location = new Point(18, 225);
            offerTemp.Size = new Size(46, 15);
            offerTemp.ForeColor = Color.FromArgb(33, 86, 118);
            offerTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);
            offerTemp.Tag = totalServices;

            TextBox priceTextBox = new TextBox();
            priceTextBox.Text = price.ToString();
            priceTextBox.Location = new Point(67, 200);
            priceTextBox.Size = new Size(95, 20);
            priceTextBox.TextChanged += priceChangeCheck;
            //priceTextBox.TabStop = false;
            priceTextBox.Tag = totalServices;

            TextBox timeTextBox = new TextBox();
            timeTextBox.Text = time.ToString();
            timeTextBox.Location = new Point(67, 250);
            timeTextBox.Size = new Size(95, 20);
            timeTextBox.TextChanged += timeChangeCheck;
            timeTextBox.Tag = totalServices;

            Button remove = new Button();
            remove.Text = "Remove";
            remove.Location = new Point(28, 270);
            remove.Size = new Size(90, 25);
            remove.Visible = true;
            remove.Enabled = true;
            remove.Click += removeservice;
            remove.BackColor = Color.LightCoral;
            remove.ForeColor = Color.FromArgb(33, 86, 118);
            remove.Tag = totalServices;

            TextBox offerTextBox = new TextBox();
            offerTextBox.Text = offer.ToString();
            offerTextBox.Location = new Point(67, 225);
            offerTextBox.Size = new Size(95, 20);
            offerTextBox.TextChanged += offerChangeCheck;
            offerTextBox.Tag = totalServices;

            Label productNameLabel = new Label();
            productNameLabel.Text = serviceName;
            productNameLabel.Location = new Point(52, 19);
            productNameLabel.ForeColor = Color.FromArgb(33, 86, 118);
            productNameLabel.Font = new Font("Lucida Bright", 10,FontStyle.Bold);
            productNameLabel.Tag = totalServices;

            PictureBox icon = new PictureBox();
            icon.ImageLocation = picture;
            icon.Location = new Point(18, 50);
            icon.Size = new Size(144, 144);
            icon.Tag = totalServices;

            GroupBox product = new GroupBox();
            product.Location = position;
            product.Size = new Size(183, 300);
            product.Tag = serviceName;
            product.Controls.Add(priceTemp);
            product.Controls.Add(priceTextBox);
            product.Controls.Add(productNameLabel);
            product.Controls.Add(offerTextBox);
            product.Controls.Add(offerTemp);
            product.Controls.Add(timeTemp);
            product.Controls.Add(remove);
            product.Controls.Add(timeTextBox);
            return product;
        }


        //Startup Function
        private void editPriceForm_Load(object sender, EventArgs e)
        {
            //Temporary Variables To Be Replaced by DB Values
            int listSize_services;
            buttonsState = "";
            Point origin = new Point(35, 3);
            Point pos = origin;
            int maxPerRow = 3;
            int counter = 0;
            string name;
            int duration;
            int price;
            int discount;
            DataTable dt = controllerObj.selectservicesInfo();
            listSize_services = dt.Rows.Count;
            for (int i = 0; i < listSize_services; i++)
            {
                //a3delha
                string location_picture = "D:/F22/DB/Project/DB - F22 - Team - 18/Images/hairdresser_2.png";
                name = dt.Rows[i][0].ToString();
                duration = Int16.Parse((dt.Rows[i][1]).ToString());
                price = Int16.Parse((dt.Rows[i][2]).ToString());
                discount = Int16.Parse((dt.Rows[i][3]).ToString());
                GroupBox addedService = createProduct(price, name, pos, location_picture, discount, duration); //Price and Name are obtained from product list
                productPanel.Controls.Add(addedService);
                totalServices++;
                buttonsState += "0";
                counter++;
                if (counter == maxPerRow)
                {
                    pos.X = origin.X;
                    pos.Y += addedService.Height + 2;
                    counter = 0;
                }
                else
                {
                    pos.X += addedService.Width + 5;
                }
                counter2++;
            }

            counter = 0;
            pos.Y +=50;
            pos.X = origin.X;

           
        }

            //Event Handlers
        private void saveButton_Click(object sender, EventArgs e)
        {
            int flag1 = 0;
            int flag2 = 0;
            int flag3 = 0;
            for (int i=0;i<totalServices;i++)
            {
                GroupBox product = (GroupBox)productPanel.Controls[i];
                String price= ((TextBox)product.Controls[1]).Text;
                String offers = ((TextBox)product.Controls[3]).Text;
                String time = ((TextBox)product.Controls[7]).Text;
                if (price.All(Char.IsDigit) && price!="")
                {
                    controllerObj.update_price(product.Tag.ToString(), Int32.Parse(price));
                    flag1 = 1;
                }
                else
                {
                    MessageBox.Show("invalid price");
                    flag1 = 0;
                }
                if (offers.All(Char.IsDigit)&& offers!="")
                {
                    controllerObj.update_discount(product.Tag.ToString(), Int32.Parse(offers));
                    flag2 = 1;
                }
                else
                {
                    MessageBox.Show("invalid offer");
                    flag2 = 0;
                    
                }
                if (time.All(Char.IsDigit)&&time!="")
                {
                    controllerObj.update_duration(product.Tag.ToString(), Int32.Parse(time));
                    flag3 = 1;
                }
                else
                {
                    MessageBox.Show("invalid time");
                    flag3 = 0;
                   
                }
                //dbPrices[(int)product.Tag] = Int32.Parse(price); //a3tked dyy kda byakhod el price w y3delo fy el database
                if (flag2 == 1 &&flag1==1&&flag3==1)
                {
                    buttonActivation(false);
                    buttonsState = buttonsState.Replace('1', '0');
                }
            }
        }


        private void discardButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <totalServices; i++)
            {
                GroupBox product = (GroupBox)productPanel.Controls[i];
                DataTable dt =controllerObj.selectservicesInfo(product.Tag.ToString());
                ((TextBox)product.Controls[7]).Text = dt.Rows[0][1].ToString(); 
                ((TextBox)product.Controls[3]).Text = dt.Rows[0][3].ToString(); //discounts
                ((TextBox)product.Controls[1]).Text = dt.Rows[0][2].ToString(); //duration
                //((TextBox)product.Controls[1]).Text = dbPrices[(int)product.Tag].ToString();
                buttonActivation(false);
                buttonsState = buttonsState.Replace('1', '0');
            }
           
        }
        private void priceChangeCheck(object sender, EventArgs e)
        {
            TextBox priceTextBox = sender as TextBox;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox product = (GroupBox)priceTextBox.Parent;
            DataTable dt = controllerObj.selectservicesInfo(product.Tag.ToString());

            if (priceTextBox.Text == dt.Columns[2].ToString())
            //if a price is changed go check if it is the same as in the database
            {
                //if yess=> 
                char[] temp = buttonsState.ToCharArray();
                temp[(int)priceTextBox.Tag] ='0';  
                buttonsState = string.Join("", temp);
                
            }
            else
            {
                char[] temp = buttonsState.ToCharArray();
                temp[(int)priceTextBox.Tag] = '1';
                buttonsState = string.Join("",temp);
            }
          
            if(buttonsState.Contains('1')==false)
            {
                buttonActivation(false);
            }
            else
            {
                buttonActivation(true);
            }
            
        }
        private void offerChangeCheck(object sender, EventArgs e)
        {
            TextBox offerTextBox = sender as TextBox;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox product = (GroupBox)offerTextBox.Parent;
            DataTable dt = controllerObj.selectservicesInfo(product.Tag.ToString());

            if (offerTextBox.Text == dt.Columns[3].ToString())
            //if a price is changed go check if it is the same as in the database
            {
                //if yess=> 
                char[] temp = buttonsState.ToCharArray();
                temp[(int)offerTextBox.Tag] = '0';
                buttonsState = string.Join("", temp);

            }
            else
            {
                char[] temp = buttonsState.ToCharArray();
                temp[(int)offerTextBox.Tag] = '1';
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
        private void timeChangeCheck(object sender, EventArgs e)
        {
            TextBox timeTextBox = sender as TextBox;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox product = (GroupBox)timeTextBox.Parent;
            DataTable dt = controllerObj.selectservicesInfo(product.Tag.ToString());

            if (timeTextBox.Text == dt.Columns[1].ToString())
            //if a price is changed go check if it is the same as in the database
            {
                //if yess=> 
                char[] temp = buttonsState.ToCharArray();
                int x = (int)product.Tag;
                temp[(int)timeTextBox.Tag] = '0';
                buttonsState = string.Join("", temp);
                
            }
            else
            {
                char[] temp = buttonsState.ToCharArray();
                temp[(int)timeTextBox.Tag] = '1';
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
            private void editPriceForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        
        }

        private void editPriceForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void productPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editPriceTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //button add service
        {
            AddService s = new AddService(ref totalServices);
            s.Show();
            //editPriceForm_Load(editPricepanel, e);
        }
        private void removeservice(object sender, EventArgs e)
        {
            totalServices--;
            Button remove = sender as Button;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox service = (GroupBox)remove.Parent;
            controllerObj.delete_service(service.Tag.ToString());
            //areload el panel
        }

    }
}
