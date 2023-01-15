namespace MainPage_Demo.Forms
{
    partial class ChangePassword
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
            this.screen = new System.Windows.Forms.Panel();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.visible = new System.Windows.Forms.CheckBox();
            this.screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Controls.Add(this.visible);
            this.screen.Controls.Add(this.label2);
            this.screen.Controls.Add(this.label1);
            this.screen.Controls.Add(this.set);
            this.screen.Controls.Add(this.NewPassword);
            this.screen.Location = new System.Drawing.Point(-4, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(792, 362);
            this.screen.TabIndex = 0;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            // 
            // NewPassword
            // 
            this.NewPassword.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.NewPassword.Location = new System.Drawing.Point(226, 178);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(291, 35);
            this.NewPassword.TabIndex = 0;
            this.NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPassword.UseSystemPasswordChar = true;
            this.NewPassword.TextChanged += new System.EventHandler(this.NewPassword_TextChanged);
            // 
            // set
            // 
            this.set.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.set.Location = new System.Drawing.Point(318, 243);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(100, 33);
            this.set.TabIndex = 1;
            this.set.Text = "Set";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(258, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Must be more than 5 chars and less than 13 char, and can\'t be \"123456\"";
            // 
            // visible
            // 
            this.visible.AutoSize = true;
            this.visible.BackColor = System.Drawing.Color.Transparent;
            this.visible.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.visible.Location = new System.Drawing.Point(555, 194);
            this.visible.Name = "visible";
            this.visible.Size = new System.Drawing.Size(75, 19);
            this.visible.TabIndex = 5;
            this.visible.Text = "visible";
            this.visible.UseVisualStyleBackColor = false;
            this.visible.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.screen);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "ChangePassword";
            this.Text = "Form1";
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox visible;
    }
}