namespace MainPage_Demo.Forms
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.TextBox();
            this.Welcome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.visible = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.visible);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 753);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(495, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(495, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "username";
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.login.Location = new System.Drawing.Point(550, 493);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(111, 42);
            this.login.TabIndex = 14;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(499, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 32);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.password.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(536, 407);
            this.password.MaxLength = 12;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(173, 27);
            this.password.TabIndex = 12;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(499, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.username.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.Location = new System.Drawing.Point(536, 337);
            this.username.MaxLength = 30;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(173, 27);
            this.username.TabIndex = 10;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // Welcome
            // 
            this.Welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold);
            this.Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.Welcome.Location = new System.Drawing.Point(491, 249);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(218, 44);
            this.Welcome.TabIndex = 9;
            this.Welcome.Text = "WELCOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(438, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Note: If it\'s your first time to login use \"123456\" as a password";
            // 
            // visible
            // 
            this.visible.AutoSize = true;
            this.visible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.visible.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(120)))), ((int)(((byte)(143)))));
            this.visible.Location = new System.Drawing.Point(727, 415);
            this.visible.Name = "visible";
            this.visible.Size = new System.Drawing.Size(75, 19);
            this.visible.TabIndex = 18;
            this.visible.Text = "visible";
            this.visible.UseVisualStyleBackColor = false;
            this.visible.CheckedChanged += new System.EventHandler(this.visible_CheckedChanged);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 753);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1218, 800);
            this.MinimumSize = new System.Drawing.Size(1218, 800);
            this.Name = "Login_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox visible;
    }
}