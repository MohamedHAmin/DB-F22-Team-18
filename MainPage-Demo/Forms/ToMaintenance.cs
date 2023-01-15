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
        Controller controllerObj;
        string tellerName;
        public ToMaintenance(string name)
        {
            InitializeComponent();
            controllerObj = new Controller();

            tellerName = name;

            toMaintenanceView.Columns.Add("column0", "Device");
            toMaintenanceView.Columns.Add("column1", "ID");
            toMaintenanceView.Columns.Add("column2", "Cost");
            toMaintenanceView.Columns.Add("column3", "Company");
            toMaintenanceView.Columns.Add("column4", "Company Contact");
            toMaintenanceView.Columns.Add("column5", "Maintenance Duration");

            DataTable dt = controllerObj.SelectAllDevicesNotInMaintenance();
            DevicesList.DataSource = dt;
            DevicesList.DisplayMember = "Name";
            DevicesList.ValueMember = "ID";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            int result = 0;
            int resultlog = 0;
            for (int i = 0; i < toMaintenanceView.Rows.Count - 1; i++)
            {
                result += controllerObj.UpdateDeviceMaintenance(Convert.ToInt32(toMaintenanceView.Rows[i].Cells[1].Value));
                resultlog = controllerObj.InsertLogs("Maintenance", toMaintenanceView.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(toMaintenanceView.Rows[i].Cells[1].Value), Convert.ToInt32(toMaintenanceView.Rows[i].Cells[2].Value), tellerName, toMaintenanceView.Rows[i].Cells[3].Value.ToString(), toMaintenanceView.Rows[i].Cells[4].Value.ToString(), DateTime.Today.ToString());
            }

            if (result != 0)
                MessageBox.Show("Selected Devices setted to maintenance");
            else
                MessageBox.Show("Error! please try again");

            if (resultlog == 0)
            {
                MessageBox.Show("Failed to add in logs");
            }

            DataTable dt = controllerObj.SelectAllDevicesNotInMaintenance();
            DevicesList.DataSource = dt;
            DevicesList.DisplayMember = "Name";
            DevicesList.ValueMember = "ID";

            toMaintenanceView.Rows.Clear();
        }

        private void AddDevice_Click(object sender, EventArgs e)
        {

            //To get device name and id
            DataTable dt = controllerObj.SelectDevices(Convert.ToInt32(DevicesList.SelectedValue));
            string deviceName = dt.Rows[0][0].ToString();
            int deviceID = Convert.ToInt32(dt.Rows[0][1]);
            //To get maintenance company info
            dt = controllerObj.SelectMaintenanceInfo(deviceName);
            int cost = Convert.ToInt32(dt.Rows[0][3]);
            string company = dt.Rows[0][1].ToString();
            string companyContact = dt.Rows[0][2].ToString();
            int duration = Convert.ToInt32(dt.Rows[0][4]);

            string[] newRow = new string[] { deviceName, deviceID.ToString(), cost.ToString(), company, companyContact, duration.ToString() };
            toMaintenanceView.Rows.Add(newRow);

            //DevicesList.Items.Remove(DevicesList.SelectedItem);
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            if (toMaintenanceView.SelectedRows.Count > 0)
            {
                int selectedRow = toMaintenanceView.CurrentCell.RowIndex;
                toMaintenanceView.Rows.RemoveAt(selectedRow);
            }
        }
    }
}
