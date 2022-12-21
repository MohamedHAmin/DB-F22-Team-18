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
        private int[] dbPrices;
        int [] dboffers;
        int[] dbtime;
        private int totalProducts=0;
        private int totalServices=0;
        private int counter2 = 0;
        private String buttonsState;
        
        public Edit()
        {
            InitializeComponent();
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
        private GroupBox createProduct(int price, String productName, Point position, string picture, int offer, int time = 0)
        {
            Label priceTemp = new Label();
            priceTemp.Text = "Price:";
            priceTemp.Location = new Point(18, 213);
            priceTemp.Size = new Size(46, 15);
            priceTemp.ForeColor = Color.FromArgb(33, 86, 118);
            priceTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);

            Label timeTemp = new Label();
            timeTemp.Text = "time:";
            timeTemp.Location = new Point(18, 260);
            timeTemp.Size = new Size(46, 15);
            timeTemp.ForeColor = Color.FromArgb(33, 86, 118);
            timeTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);

            Label offerTemp = new Label();
            offerTemp.Text = "offer:";
            offerTemp.Location = new Point(18, 235);
            offerTemp.Size = new Size(46, 15);
            offerTemp.ForeColor = Color.FromArgb(33, 86, 118);
            offerTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);

            TextBox priceTextBox = new TextBox();
            priceTextBox.Text = price.ToString();
            priceTextBox.Location = new Point(67, 210);
            priceTextBox.Size = new Size(95, 20);
            priceTextBox.TextChanged += priceChangeCheck;
            //priceTextBox.TabStop = false;

            TextBox timeTextBox = new TextBox();
            timeTextBox.Text = time.ToString();
            timeTextBox.Location = new Point(67, 260);
            timeTextBox.Size = new Size(95, 20);
            timeTextBox.TextChanged += timeChangeCheck;

            TextBox offerTextBox = new TextBox();
            offerTextBox.Text = offer.ToString();
            offerTextBox.Location = new Point(67, 235);
            offerTextBox.Size = new Size(95, 20);
            offerTextBox.TextChanged += offerChangeCheck;

            Label productNameLabel = new Label();
            productNameLabel.Text = productName;
            productNameLabel.Location = new Point(52, 19);
            productNameLabel.ForeColor = Color.FromArgb(33, 86, 118);
            productNameLabel.Font = new Font("Lucida Bright", 10,FontStyle.Bold);

            PictureBox icon = new PictureBox();
            icon.ImageLocation = picture;
            icon.Location = new Point(18, 50);
            icon.Size = new Size(144, 144);

            GroupBox product = new GroupBox();
            product.Location = position;
            if (time != 0)
            {
                product.Size = new Size(183, 300);
            }
            else
            {
                product.Size = new Size(183, 270);
            }
            product.Tag = counter2;
            product.Controls.Add(priceTemp);
            product.Controls.Add(priceTextBox);
            product.Controls.Add(productNameLabel);
            product.Controls.Add(offerTextBox);
            product.Controls.Add(offerTemp);
            
            if (time != 0)
            {
                product.Controls.Add(timeTemp);
                product.Controls.Add(timeTextBox);
            }
            product.Controls.Add(icon);

       

            return product;
        }


        //Startup Function
        private void editPriceForm_Load(object sender, EventArgs e)
        {
            //Temporary Variables To Be Replaced by DB Values
            int listSize_products = 10;
            int listSize_services = 10;
            dbPrices = new int[listSize_products+listSize_services];
            dboffers = new int[listSize_products + listSize_services];
            dbtime = new int[listSize_services];
            buttonsState = "";
            Point origin = new Point(35, 3);
            Point pos = origin;
            int maxPerRow = 5;
            int counter = 0;

            for (int i = 0; i < listSize_services; i++)
            {
                
                dbPrices[i] = 100;
                dboffers[i] = 25;
                dbtime[i] = 30;
                string location_picture = "C:/college_items/database/databbase project/DB-F22-Team-18/MainPage-Demo/Resources/hairdresser (2).png";
                GroupBox addedService = createProduct(dbPrices[i], "service " + (i + 1).ToString(), pos, location_picture, dboffers[i], dbtime[i]); //Price and Name are obtained from product list
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

            for (int i = 0; i < listSize_products; i++)
            {
                dbPrices[i] = 100;
                dboffers[i] = 25;

                GroupBox addedProduct = createProduct(dbPrices[i], "Product " + (i + 1).ToString(), pos, "./salonsmall.png", dboffers[i]); //Price and Name are obtained from product list
                productPanel.Controls.Add(addedProduct);
                totalProducts++;
                dbPrices[i+ listSize_services] = 100;
                buttonsState += "0";
                counter++;
                if (counter == maxPerRow)
                {
                    pos.X = origin.X;
                    pos.Y += addedProduct.Height + 2;
                    counter = 0;
                }
                else
                {
                    pos.X += addedProduct.Width + 5;
                }
                counter2++;
            }
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
                String time = ((TextBox)product.Controls[6]).Text;
                if (price.All(Char.IsDigit) && price!="")
                {
                    dbPrices[i] = Int32.Parse(price);
                    flag1 = 1;
                }
                else
                {
                    MessageBox.Show("invalid price");
                    flag1 = 0;
                  
                }
                if (offers.All(Char.IsDigit)&& offers!="")
                {
                    dboffers[i] = Int32.Parse(offers);
                    flag2 = 1;
                }
                else
                {
                    MessageBox.Show("invalid offer");
                    flag2 = 0;
                    
                }
                if (time.All(Char.IsDigit)&&time!="")
                {
                    dboffers[i] = Int32.Parse(time);
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
            flag1 = 0;
            flag2 = 0;
            for (int i = totalServices; i < totalProducts; i++)
            {
                GroupBox product = (GroupBox)productPanel.Controls[i];
                String price = ((TextBox)product.Controls[1]).Text;
                String offers = ((TextBox)product.Controls[3]).Text;
                if (price.All(Char.IsDigit) && price != "")
                {
                    dbPrices[i] = Int32.Parse(price);
                    flag1 = 1;
                }
                else
                {
                    MessageBox.Show("invalid price");
                    flag1 = 0;
                   
                }
                if (offers.All(Char.IsDigit) && offers != "")
                {
                    dboffers[i] = Int32.Parse(offers);
                    flag2 = 1;
                }
                else
                {
                    MessageBox.Show("invalid time");
                    flag2 = 0;
                    
                }
                //dbPrices[(int)product.Tag] = Int32.Parse(price); //a3tked dyy kda byakhod el price w y3delo fy el database
               if(flag2==1 && flag1==1)
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
                ((TextBox)product.Controls[1]).Text = dbPrices[i].ToString();
                ((TextBox)product.Controls[3]).Text = dboffers[i].ToString();
                ((TextBox)product.Controls[6]).Text = dbtime[i].ToString();
                //((TextBox)product.Controls[1]).Text = dbPrices[(int)product.Tag].ToString();
                buttonActivation(false);
                buttonsState = buttonsState.Replace('1', '0');
            }
            for (int i = 0; i < totalProducts; i++)
            {
                GroupBox product = (GroupBox)productPanel.Controls[i];
                ((TextBox)product.Controls[1]).Text = dbPrices[i].ToString();
                ((TextBox)product.Controls[3]).Text = dboffers[i].ToString();
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


            if (priceTextBox.Text == dbPrices[(int)product.Tag].ToString())
            //if a price is changed go check if it is the same as in the database
            {
                //if yess=> 
                char[] temp = buttonsState.ToCharArray();
                temp[(int)product.Tag] ='0';  
                buttonsState = string.Join("", temp);
                
            }
            else
            {
                char[] temp = buttonsState.ToCharArray();
                temp[(int)product.Tag] = '1';
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

            if (offerTextBox.Text == dboffers[(int)product.Tag].ToString())
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
        private void timeChangeCheck(object sender, EventArgs e)
        {
            TextBox timeTextBox = sender as TextBox;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox product = (GroupBox)timeTextBox.Parent;

            if (timeTextBox.Text == dbtime[(int)product.Tag].ToString())
            //if a price is changed go check if it is the same as in the database
            {
                //if yess=> 
                char[] temp = buttonsState.ToCharArray();
                int x = (int)product.Tag;
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
    }
}
