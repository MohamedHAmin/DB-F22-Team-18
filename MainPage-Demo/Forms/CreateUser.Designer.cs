namespace MainPage_Demo.Forms
{
    partial class CreateUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.username = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 639);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.lastname);
            this.groupBox1.Controls.Add(this.salary);
            this.groupBox1.Controls.Add(this.ssn);
            this.groupBox1.Controls.Add(this.create);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.firstname);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.groupBox1.Location = new System.Drawing.Point(155, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 386);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Teller Account";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.Location = new System.Drawing.Point(190, 72);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(296, 46);
            this.username.TabIndex = 6;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.Silver;
            this.lastname.Location = new System.Drawing.Point(349, 135);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(296, 46);
            this.lastname.TabIndex = 5;
            this.lastname.Text = "Last Name";
            this.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastname.Enter += new System.EventHandler(this.lastname_Enter);
            this.lastname.Leave += new System.EventHandler(this.lastname_Leave);
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.ForeColor = System.Drawing.Color.Silver;
            this.salary.Location = new System.Drawing.Point(349, 215);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(296, 46);
            this.salary.TabIndex = 4;
            this.salary.Text = "Salary";
            this.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salary.Enter += new System.EventHandler(this.salary_Enter);
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_KeyPress);
            this.salary.Leave += new System.EventHandler(this.salary_Leave);
            // 
            // ssn
            // 
            this.ssn.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssn.ForeColor = System.Drawing.Color.Silver;
            this.ssn.Location = new System.Drawing.Point(143, 281);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(379, 46);
            this.ssn.TabIndex = 3;
            this.ssn.Text = "SSN";
            this.ssn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ssn.Enter += new System.EventHandler(this.ssn_Enter);
            this.ssn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ssn_KeyPress);
            this.ssn.Leave += new System.EventHandler(this.ssn_Leave);
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(233, 333);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(199, 47);
            this.create.TabIndex = 2;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.Silver;
            this.phone.Location = new System.Drawing.Point(22, 215);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(296, 46);
            this.phone.TabIndex = 1;
            this.phone.Text = "Phone Number";
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phone.Enter += new System.EventHandler(this.phone_Enter);
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            this.phone.Leave += new System.EventHandler(this.phone_Leave);
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.Silver;
            this.firstname.Location = new System.Drawing.Point(22, 135);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(296, 46);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "First Name";
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstname.Enter += new System.EventHandler(this.firstname_Enter);
            this.firstname.Leave += new System.EventHandler(this.firstname_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 35);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MainPage_Demo.Properties.Resources.arrow_small_right_free_icon_font;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 639);
            this.Controls.Add(this.panel1);
            this.Name = "CreateUser";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateUser_Paint);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox firstname;
    }
}