
namespace MainPage_Demo.Forms
{
    partial class Adddevice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.create = new System.Windows.Forms.Button();
            this.devicename = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.create);
            this.groupBox1.Controls.Add(this.devicename);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(666, 330);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Device";
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(218, 181);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(199, 47);
            this.create.TabIndex = 2;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // devicename
            // 
            this.devicename.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devicename.ForeColor = System.Drawing.Color.Silver;
            this.devicename.Location = new System.Drawing.Point(162, 81);
            this.devicename.Name = "devicename";
            this.devicename.Size = new System.Drawing.Size(312, 46);
            this.devicename.TabIndex = 0;
            this.devicename.Text = "Device Name";
            this.devicename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.devicename.Enter += new System.EventHandler(this.devicename_Enter_1);
            this.devicename.Leave += new System.EventHandler(this.devicename_Leave_1);
            // 
            // Adddevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Adddevice";
            this.Text = "Adddevice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox devicename;
    }
}