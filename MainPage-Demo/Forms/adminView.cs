using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainPage_Demo
{
    public partial class adminView : Form
    {
        private Button currentButton;
        private Form activeForm;


        public adminView()
        {
            InitializeComponent();
            CloseChildForm.Visible = false;
            timer1.Start();

            scheduleView.Columns.Add("column0", "Customer");
            scheduleView.Columns.Add("column1", "Start Time");
            scheduleView.Columns.Add("column2", "Finsh Time");
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
                    currentButton.Font = this.Edit.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            //TitleLabel.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void Order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.createAccount(), sender, "#b6d9d9");
        }

        private void History_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.History(), sender, "#88b8c2");
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Edit(), sender, "#449fbc");
        }
        private void devices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.devices(), sender, "#20aaa9");
        }

        private void employess_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms.employees(), sender, "#ddc9d2");
        }

        private void CloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            disablebutton();
            TitleLabel.Text = "HOME";
            TitleLabel.ForeColor = Color.Silver;
            //TitleLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TitleBar.BackColor = Color.FromArgb(169, 120, 143);
            LogoBar.BackColor = Color.FromArgb(169, 166, 157);
            currentButton = null;
            CloseChildForm.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           Clock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Inventory(), sender, "#449fa7");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form loginPage = new Forms.Login_Form();
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
