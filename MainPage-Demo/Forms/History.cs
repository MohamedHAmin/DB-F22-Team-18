using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage_Demo.Forms
{
    public partial class History : Form
    {
        Controller controllerObj;
        public History()
        {
            InitializeComponent();
            controllerObj = new Controller();

            //Logs.Columns.Add("column0", "Type"); //service or maintinance
            //Logs.Columns.Add("column1", "Name"); //name of service or device 
            //Logs.Columns.Add("column2", "ID");   //device id or order id
            //Logs.Columns.Add("column3", "Cost");
            //Logs.Columns.Add("column4", "Teller Name");
            //Logs.Columns.Add("column5", "Company"); //in case of device
            //Logs.Columns.Add("column6", "Company contact");
            //Logs.Columns.Add("column7", "Data");

            DurationList.Items.Add("All");
            DurationList.Items.Add("Week");
            DurationList.Items.Add("Month");


            DataTable dt = controllerObj.SelectAllLogs();
            Logs.DataSource = dt;
            Logs.Refresh();
        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void DurationList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DurationList.Text == "All")
            {
                DataTable dt = controllerObj.SelectAllLogs();
                Logs.DataSource = dt;
                Logs.Refresh();
            }
            else if (DurationList.Text == "Week")
            {
                //TODO - Change to be week
                DataTable dt = controllerObj.SelectWeekLogs();
                Logs.DataSource = dt;
                Logs.Refresh();
            }
            else
            {
                //TODO - Change to be Month
                DataTable dt = controllerObj.SelectMonthLogs();
                Logs.DataSource = dt;
                Logs.Refresh();
            }
        }
    }
}
