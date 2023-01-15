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
    public partial class Inventory : Form
    {
        private int[] dbcapicity;
        private int TotalInventoryItems = 0;
        string ButtonState = "";
        Controller controllerObj;

        public Inventory()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            controllerObj = new Controller();
        }

        private void buttonActivation(bool state)
        {
            if (state == true)  // any changes in values of fields available
            {
                DiscardButton.Enabled = true;
                DiscardButton.FlatStyle = FlatStyle.Flat;
                DiscardButton.BackColor = Color.LightCoral;
                DiscardButton.ForeColor = Color.FromArgb(33, 86, 118);

                SaveButton.Enabled = true;
                SaveButton.FlatStyle = FlatStyle.Flat;
                SaveButton.BackColor = Color.LightGreen;
                SaveButton.ForeColor = Color.FromArgb(33, 86, 118);

            }
            else
            {
                DiscardButton.Enabled = false;
                DiscardButton.FlatStyle = FlatStyle.Standard;
                DiscardButton.BackColor = Color.Silver;
                DiscardButton.ForeColor = Color.DimGray;

                SaveButton.Enabled = false;
                SaveButton.FlatStyle = FlatStyle.Standard;
                SaveButton.BackColor = Color.Silver;
                SaveButton.ForeColor = Color.DimGray;
            }
        }
        private void set_background(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(239, 235, 246), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(239, 235, 246), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        }

        private GroupBox CreateInventoryItem(String ItemName, Point position, string picture, int capacity)
        {
            Label CapacityTemp = new Label();
            CapacityTemp.Text = "Capacity";
            CapacityTemp.Location = new Point(18, 135);
            CapacityTemp.Size = new Size(68, 18);
            CapacityTemp.ForeColor = Color.FromArgb(33, 86, 118);
            CapacityTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);

            TextBox CapacitytextBox = new TextBox();
            CapacitytextBox.Text = capacity.ToString();
            CapacitytextBox.Location = new Point(85, 135);
            CapacitytextBox.Size = new Size(85, 20);
            CapacitytextBox.TextChanged += CapacityChangeCheck;

            Label ItemNameLabel = new Label();
            ItemNameLabel.Text = ItemName;
            ItemNameLabel.Location = new Point(72, 19);
            ItemNameLabel.ForeColor = Color.FromArgb(33, 86, 118);
            ItemNameLabel.Font = new Font("Lucida Bright", 10, FontStyle.Bold);

            PictureBox icon = new PictureBox();
            icon.ImageLocation = picture;
            icon.Location = new Point(65, 50);
            icon.Size = new Size(144, 144);


            GroupBox Inventory_Item = new GroupBox();
            Inventory_Item.Location = position;
            Inventory_Item.Size = new Size(230, 175);
            Inventory_Item.Tag = TotalInventoryItems;
            Inventory_Item.Controls.Add(CapacityTemp);
            Inventory_Item.Controls.Add(CapacitytextBox);
            Inventory_Item.Controls.Add(ItemNameLabel);
            Inventory_Item.Controls.Add(icon);

            return Inventory_Item;
        }


        private void CapacityChangeCheck(object sender, EventArgs e)
        {
            TextBox capacitytextBox = sender as TextBox;
            GroupBox product = (GroupBox)capacitytextBox.Parent;

            // compare quanitity entered with quantity stored in db
            if (capacitytextBox.Text == dbcapicity[(int)product.Tag].ToString())
            {
                // temp is array that stores 0 to the corresponding item if its quantity matches the quantity stored in db or 1 if the quantity doesn't match the db
                char[] temp = ButtonState.ToCharArray();
                temp[(int)product.Tag] = '0';
                ButtonState = string.Join("", temp);
            }
            else
            {
                char[] temp = ButtonState.ToCharArray();
                temp[(int)product.Tag] = '1';
                ButtonState = string.Join("", temp);
            }

            if (ButtonState.Contains('1') == false)
            {
                buttonActivation(false);
            }
            else
            {
                buttonActivation(true);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Select_Number_of_Inventory_Items();
            int list_Inventory = Int16.Parse(dt.Rows[0][0].ToString());
            DataTable ItemInfo = controllerObj.Select_Inventory_Items();
            Point origin = new Point(35, 3);
            Point pos = origin;
            int maxPerRow = 4;
            dbcapicity = new int[list_Inventory];
            for (int i = 0; i < list_Inventory; i++)
            {
                ButtonState += "0";
                dbcapicity[i] = Int16.Parse(ItemInfo.Rows[i][1].ToString());
                string picture_location = "D:/F22/DB/Project/DB-F22-Team-18/Images/products.png";
                String ItemName = ItemInfo.Rows[i][0].ToString();
                GroupBox Add_Item = CreateInventoryItem(ItemName, pos, picture_location, dbcapicity[i]);

                panel1.Controls.Add(Add_Item);
                TotalInventoryItems++;
                if (TotalInventoryItems % maxPerRow == 0)
                {
                    pos.X = origin.X;
                    pos.Y += Add_Item.Height + 2;
                }
                else
                {
                    pos.X += Add_Item.Width + 5;
                }

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            DataTable ItemInfo = controllerObj.Select_Inventory_Items();
            for (int i = 0; i < TotalInventoryItems; i++)
            {
                GroupBox product = (GroupBox)panel1.Controls[i];
                String Newcap = ((TextBox)product.Controls[1]).Text; // Newcap is a string to be able to check if digits only are enetered in capacity text box
                int minCapacity = Int16.Parse(ItemInfo.Rows[i][2].ToString());
                if (Newcap != "" && Newcap.All(Char.IsDigit) && Int16.Parse(Newcap) != dbcapicity[i])           // if capacity field changed
                {

                    if (Int16.Parse(Newcap) >= minCapacity)
                    {
                        dbcapicity[i] = Int16.Parse(Newcap);
                        flag = 1;
                        int result = controllerObj.Update_Inventory_Item_Capacity(Int16.Parse(Newcap), ItemInfo.Rows[i][0].ToString());
                        if (result != 0)
                        {
                            MessageBox.Show("Capacity of " + ItemInfo.Rows[i][0] + " is updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Capacity is not updated!");
                        }

                    }
                    else if (Int16.Parse(Newcap) < minCapacity)
                    {
                        MessageBox.Show("                  Invalid Capacity for " + ItemInfo.Rows[i][0] + Environment.NewLine + Environment.NewLine
                            + "Entered Capacity is less than the min capacity(" + minCapacity + ")");
                        flag = 0;
                    }
                }
                else if (Newcap != "" && Newcap.All(Char.IsDigit) && Int16.Parse(Newcap) == dbcapicity[i]) // value of capacity is not changed
                {

                }
                else
                {
                    MessageBox.Show("Invalid Capacity for " + ItemInfo.Rows[i][0]);
                    flag = 0;
                }

                if (flag == 1)
                {
                    buttonActivation(false);
                    ButtonState = ButtonState.Replace('1', '0');
                }
            }



        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TotalInventoryItems; i++)
            {
                GroupBox product = (GroupBox)panel1.Controls[i];
                ((TextBox)product.Controls[1]).Text = dbcapicity[i].ToString();
                buttonActivation(false);
            }
        }
    }

}
