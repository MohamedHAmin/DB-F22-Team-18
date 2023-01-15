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
    public partial class TellerView : Form
    {
        private Button currentButton;
        private Form activeForm;
        Controller controllerObj;

        string tellername;
        public TellerView(string username)
        {
            InitializeComponent();
            CloseChildForm.Visible = false;
            timer1.Start();
            controllerObj = new Controller();

            //scheduleView.Columns.Add("column0", "Customer");
            //scheduleView.Columns.Add("column1", "Start Time");
            //scheduleView.Columns.Add("column2", "Finsh Time");
            
            tellername = username;

            DataTable dt = controllerObj.SelectAllWorkers();
            workers.DataSource = dt;
            workers.DisplayMember = "FirstName";
            workers.ValueMember = "SSN";
        }

        private void ActivateButton(object btnSender, string colorHex)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    disablebutton();
                    Color color = ColorTranslator.FromHtml(colorHex);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    TitleBar.BackColor = color;
                    LogoBar.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = color;
                    CloseChildForm.Visible = true;
                }
            }
        }

        private void disablebutton()
        {
            foreach (Control previousBtn in Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(199, 203, 197);
                    previousBtn.ForeColor = ColorTranslator.FromHtml("#a9788f");
                    previousBtn.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender, string color)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender, color);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Main.Controls.Add(childForm);
            this.Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleLabel.Text = childForm.Text;
            TitleLabel.ForeColor = Color.DimGray;
            activeForm = childForm;
        }

        private void Reset()
        {
            disablebutton();
            TitleLabel.Text = "HOME";
            TitleLabel.ForeColor = Color.Silver;
            TitleBar.BackColor = Color.FromArgb(169, 120, 143);
            LogoBar.BackColor = Color.FromArgb(169, 166, 157);
            currentButton = null;
            CloseChildForm.Visible = false;
        }
        private void Order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Order(tellername), sender, "#b6d9d9");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void devices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ToMaintenance(tellername), sender, "#88b8c2");
        }

        private void CloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

       

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form loginPage = new Forms.Login_Form();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.SelectALLSchedule();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                // < 0 − If date1 is earlier than date2
                // = 0 − If date1 is the same as date2
                // > 0 − If date1 is later than date2
                DateTime finishTime = (DateTime)dt1.Rows[i][4];
                if (DateTime.Compare(finishTime, DateTime.Now) < 0)
                {
                    int del = controllerObj.DeleteSchedule(Convert.ToInt32(dt1.Rows[i][1]));
                }
            }
            DataTable dt = controllerObj.SelectWorkerSchedule(workers.SelectedValue.ToString());
            scheduleView.DataSource = dt;
            scheduleView.Refresh();
        }
    }
}
