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
    public partial class ToMaintenance : Form
    {
        public ToMaintenance()
        {
            InitializeComponent();

            toMaintenanceView.Columns.Add("column0", "Device");
            toMaintenanceView.Columns.Add("column1", "ID");
            toMaintenanceView.Columns.Add("column2", "Cost");
            toMaintenanceView.Columns.Add("column3", "Company");
            toMaintenanceView.Columns.Add("column4", "Company Contact");
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
