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

namespace MainPage_Demo.Forms
{
    public partial class PlaceOrder : Form
    {
        string cName;
        int cID;
        int numOfOrders;
        float discount = 0;
        float customeroffer;
        bool discountApplyed = false;
        string tellerName;
        int serviceDuration;

        Controller controllerObj;
        public PlaceOrder(string name, int id, int orders, string Tname)
        {
            InitializeComponent();
            controllerObj = new Controller();
            cName = name;
            cID = id;
            numOfOrders = orders;
            tellerName = Tname;

            label1.Visible = false;
            offerLable.Visible = false;
            ApplyOffer.Visible = false;
            ApplyOffer.Enabled = false;

            customerName.Text = cName;
            DataTable dt = controllerObj.SelectCustomerOffer(numOfOrders);
            if (dt != null && dt.Rows[0][0].ToString() != "0")
            {
                label1.Visible = true;
                offerLable.Visible = true;
                ApplyOffer.Visible = true;
                ApplyOffer.Enabled = true;
                customeroffer = Convert.ToInt32(dt.Rows[0][0]);
                offerLable.Text = dt.Rows[0][0].ToString() + "% off";
            }

            dt = controllerObj.SelectAllServices();
            serviceList.DataSource = dt;
            serviceList.DisplayMember = "ServiceName";
            serviceList.ValueMember = "ID";

            OrderView.Columns.Add("column0", "Service");
            OrderView.Columns.Add("column1", "ID");
            OrderView.Columns.Add("column2", "Cost");
            OrderView.Columns.Add("column3", "Discount");
            OrderView.Columns.Add("column4", "Cost After Offers");
        }

        private void PlaceOrder_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);

            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
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

        private void Add_Click(object sender, EventArgs e)
        {
            ApplyOffer.BackColor = Color.Tomato;
            ApplyOffer.Enabled = false;
            DataTable dt = controllerObj.SelectServices(serviceList.Text);

            serviceDuration = Convert.ToInt32(dt.Rows[0][1]);

            int price = Convert.ToInt32(dt.Rows[0][2].ToString());
            float offer = Convert.ToInt32(dt.Rows[0][3].ToString());
            //offer --> system  discount --> user based on number of orders
            int costOfService = price - (int)(offer / 100 * price) - (int)((discount / 100) * price);

            //{service Name,service ID, Cost, Discount, Cost After Offers}
            string[] newRow = new string[] {dt.Rows[0][0].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), costOfService.ToString()};
            OrderView.Rows.Add(newRow);


            if (TotalCost.Text == "000")
                TotalCost.Text = "0";

            TotalCost.Text = (Convert.ToInt32(TotalCost.Text) + costOfService).ToString();
        }

        private void ApplyOffer_Click(object sender, EventArgs e)
        {
            discount = customeroffer;
            ApplyOffer.BackColor = Color.Tomato;
            ApplyOffer.Enabled = false;
            discountApplyed = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (OrderView.SelectedRows.Count > 0)
            {
                int selectedRow = OrderView.CurrentCell.RowIndex;
                TotalCost.Text = (Convert.ToInt32(TotalCost.Text) - Convert.ToInt32(OrderView.Rows[selectedRow].Cells[3].Value)).ToString();
                OrderView.Rows.RemoveAt(selectedRow);
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            //DONE 3-Remove products that service consumed
            for (int i = 0; i < OrderView.Rows.Count - 1; i++)
            {
                //{service Name, ID, Cost, Discount, Cost After Offers}
                //type, name, order id, cost, tellername, company, companyContanct, date
                string serviceName = OrderView.Rows[i].Cells[0].Value.ToString();
                DataTable dt3 = controllerObj.SelectProudctsInService(serviceName);
                for(int j = 0; j < dt3.Rows.Count; j++)
                {
                    string productName = dt3.Rows[j][1].ToString();
                    DataTable dt2 = controllerObj.SelectProudct(productName);
                    int upd = 0;
                    if ((Convert.ToInt32(dt2.Rows[0][2]) - 1) > 0)
                    {
                        upd = controllerObj.Update_Inventory_Item_Capacity((Convert.ToInt32(dt2.Rows[0][2]) - 1), productName);
                    }
                    else
                    {
                        MessageBox.Show("can't add this services "+ serviceName  +", no enough prodcts.");
                        TotalCost.Text = (Convert.ToInt32(TotalCost.Text) - Convert.ToInt32(OrderView.Rows[i].Cells[3].Value)).ToString();
                        OrderView.Rows.RemoveAt(i);
                    }
                }
            }
            // 1-Insert in orders
            int orderadd = controllerObj.InsertOrder(Convert.ToInt32(TotalCost.Text), DateTime.Today.ToString(), tellerName);
            // 2-Get order ID
            DataTable dt = controllerObj.SelectOrderID();
            int ID = Convert.ToInt32(dt.Rows[0][0]);
            //DONE 4-Update schedule
            dt = controllerObj.SelectALLSchedule();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                // < 0 − If date1 is earlier than date2
                // = 0 − If date1 is the same as date2
                // > 0 − If date1 is later than date2
                DateTime finishTime = (DateTime)dt.Rows[i][4];
                if (DateTime.Compare(finishTime,DateTime.Now) < 0)
                {
                    int del = controllerObj.DeleteSchedule(Convert.ToInt32(dt.Rows[i][1]));
                }
            }
            //TODO 5-Add to schedule
            DataTable workerdt = controllerObj.SelectAllWorkers();
            DateTime finishtimes = Convert.ToDateTime("2022-12-29 23:59:00.000");
            string toWorker = "";
            for (int i = 0; i < workerdt.Rows.Count; i++)
            {
                dt = controllerObj.SelectMaxSchedule(workerdt.Rows[i][2].ToString());
                if(dt == null)
                {
                    finishtimes = DateTime.Now;
                    toWorker = workerdt.Rows[i][2].ToString();
                    break;
                }
                if (DateTime.Compare((DateTime)dt.Rows[0][4], finishtimes) > 0)
                {
                    finishtimes = (DateTime)dt.Rows[0][4];
                    toWorker = workerdt.Rows[i][2].ToString();
                }
            }
            DateTime endTime = finishtimes.AddMinutes(serviceDuration);

            int insert = controllerObj.InsertSchedule(cName, ID, toWorker, finishtimes.ToString(), endTime.ToString());


            //DONE - add to logs
            for (int i = 0; i < OrderView.Rows.Count - 1; i++)
            {
                //{service Name, ID, Cost, Discount, Cost After Offers}
                //type, name, order id, cost, tellername, company, companyContanct, date
                int resultlog = controllerObj.InsertLogs("Service", OrderView.Rows[i].Cells[0].Value.ToString(), ID, Convert.ToInt32(OrderView.Rows[i].Cells[4].Value), tellerName, "Team18", "01129665659", DateTime.Today.ToString());
                if (resultlog == 0)
                {
                    MessageBox.Show("Failed to add in logs");
                }
                numOfOrders++;
            }
            int usedOrders = 0;
            if (discount == 20)
                usedOrders = 10;
            else if (discount == 35)
                usedOrders = 20;
            else if (discount == 75)
                usedOrders = 40;

            int result = 0;
            if (discountApplyed)
            {
                numOfOrders -= usedOrders;
                result = controllerObj.UpdateNumOfOrders(numOfOrders, cID);
            }

            result = controllerObj.UpdateNumOfOrders(numOfOrders, cID);

           
            this.Close();
        }
    }
}
