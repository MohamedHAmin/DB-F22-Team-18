namespace MainPage_Demo.Forms
{
    partial class TellerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TellerView));
            this.Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.current_work = new System.Windows.Forms.Panel();
            this.scheduleView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.workers = new System.Windows.Forms.ComboBox();
            this.Clock = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseChildForm = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.devices = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.LogoBar = new System.Windows.Forms.Panel();
            this.fullpage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Main.SuspendLayout();
            this.current_work.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleView)).BeginInit();
            this.TitleBar.SuspendLayout();
            this.Menu.SuspendLayout();
            this.LogoBar.SuspendLayout();
            this.fullpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.current_work);
            this.Main.Controls.Add(this.Clock);
            this.Main.Location = new System.Drawing.Point(200, 100);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1000, 686);
            this.Main.TabIndex = 5;
            this.Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current schedule";
            // 
            // current_work
            // 
            this.current_work.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.current_work.AutoScroll = true;
            this.current_work.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.current_work.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_work.Controls.Add(this.scheduleView);
            this.current_work.Controls.Add(this.button1);
            this.current_work.Controls.Add(this.label2);
            this.current_work.Controls.Add(this.workers);
            this.current_work.Location = new System.Drawing.Point(103, 84);
            this.current_work.Name = "current_work";
            this.current_work.Size = new System.Drawing.Size(799, 525);
            this.current_work.TabIndex = 1;
            // 
            // scheduleView
            // 
            this.scheduleView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleView.Location = new System.Drawing.Point(92, 140);
            this.scheduleView.Name = "scheduleView";
            this.scheduleView.ReadOnly = true;
            this.scheduleView.RowHeadersWidth = 51;
            this.scheduleView.RowTemplate.Height = 24;
            this.scheduleView.Size = new System.Drawing.Size(617, 330);
            this.scheduleView.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.button1.Location = new System.Drawing.Point(574, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Worker :";
            // 
            // workers
            // 
            this.workers.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workers.FormattingEnabled = true;
            this.workers.Location = new System.Drawing.Point(224, 53);
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(245, 31);
            this.workers.TabIndex = 4;
            // 
            // Clock
            // 
            this.Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.Clock.Location = new System.Drawing.Point(672, 30);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(230, 50);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "00:00:00";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.TitleBar.Controls.Add(this.panel1);
            this.TitleBar.Controls.Add(this.CloseChildForm);
            this.TitleBar.Controls.Add(this.TitleLabel);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(200, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1000, 100);
            this.TitleBar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(702, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 244);
            this.panel1.TabIndex = 1;
            // 
            // CloseChildForm
            // 
            this.CloseChildForm.BackColor = System.Drawing.Color.Transparent;
            this.CloseChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.CloseChildForm.FlatAppearance.BorderSize = 0;
            this.CloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseChildForm.ForeColor = System.Drawing.Color.DimGray;
            this.CloseChildForm.Image = global::MainPage_Demo.Properties.Resources.close__1_;
            this.CloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.CloseChildForm.Name = "CloseChildForm";
            this.CloseChildForm.Size = new System.Drawing.Size(75, 100);
            this.CloseChildForm.TabIndex = 1;
            this.CloseChildForm.UseVisualStyleBackColor = false;
            this.CloseChildForm.Click += new System.EventHandler(this.CloseChildForm_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Silver;
            this.TitleLabel.Location = new System.Drawing.Point(417, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(139, 44);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "HOME";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(203)))), ((int)(((byte)(197)))));
            this.Menu.Controls.Add(this.logout);
            this.Menu.Controls.Add(this.devices);
            this.Menu.Controls.Add(this.Order);
            this.Menu.Controls.Add(this.LogoBar);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(200, 753);
            this.Menu.TabIndex = 3;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(203)))), ((int)(((byte)(197)))));
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Segoe Print", 12.6F);
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.logout.Location = new System.Drawing.Point(0, 695);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(200, 65);
            this.logout.TabIndex = 10;
            this.logout.Text = "Logout";
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // devices
            // 
            this.devices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devices.Dock = System.Windows.Forms.DockStyle.Top;
            this.devices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(203)))), ((int)(((byte)(197)))));
            this.devices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devices.Font = new System.Drawing.Font("Segoe Print", 13.2F);
            this.devices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.devices.Image = ((System.Drawing.Image)(resources.GetObject("devices.Image")));
            this.devices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devices.Location = new System.Drawing.Point(0, 200);
            this.devices.Name = "devices";
            this.devices.Size = new System.Drawing.Size(200, 100);
            this.devices.TabIndex = 7;
            this.devices.Text = "Devices";
            this.devices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.devices.UseVisualStyleBackColor = true;
            this.devices.Click += new System.EventHandler(this.devices_Click);
            // 
            // Order
            // 
            this.Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Order.Dock = System.Windows.Forms.DockStyle.Top;
            this.Order.FlatAppearance.BorderSize = 0;
            this.Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order.Font = new System.Drawing.Font("Segoe Print", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.Order.Image = global::MainPage_Demo.Properties.Resources.icons8_add_new_32;
            this.Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Order.Location = new System.Drawing.Point(0, 100);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(200, 100);
            this.Order.TabIndex = 2;
            this.Order.Text = "Order";
            this.Order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // LogoBar
            // 
            this.LogoBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoBar.Controls.Add(this.fullpage);
            this.LogoBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBar.Location = new System.Drawing.Point(0, 0);
            this.LogoBar.Name = "LogoBar";
            this.LogoBar.Size = new System.Drawing.Size(200, 100);
            this.LogoBar.TabIndex = 5;
            // 
            // fullpage
            // 
            this.fullpage.Controls.Add(this.pictureBox1);
            this.fullpage.Location = new System.Drawing.Point(0, 0);
            this.fullpage.Name = "fullpage";
            this.fullpage.Size = new System.Drawing.Size(1212, 785);
            this.fullpage.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainPage_Demo.Properties.Resources.hand_cream__1_;
            this.pictureBox1.Location = new System.Drawing.Point(55, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(68, 18, 68, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // TellerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 753);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.Menu);
            this.Name = "TellerView";
            this.Text = "Form1";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.current_work.ResumeLayout(false);
            this.current_work.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleView)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.LogoBar.ResumeLayout(false);
            this.fullpage.ResumeLayout(false);
            this.fullpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel current_work;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseChildForm;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button devices;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Panel LogoBar;
        private System.Windows.Forms.Panel fullpage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView scheduleView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox workers;
    }
}