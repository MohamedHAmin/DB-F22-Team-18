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
        public History()
        {
            InitializeComponent();

            Logs.Columns.Add("column0", "Type"); //service or maintinance
            Logs.Columns.Add("column1", "Name"); //name of service or device 
            Logs.Columns.Add("column2", "ID");   //device id or order id
            Logs.Columns.Add("column3", "Cost");
            Logs.Columns.Add("column4", "Teller Name");
            Logs.Columns.Add("column5", "Company"); //in case of device
            Logs.Columns.Add("column6", "Company contact");
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
    }
}
