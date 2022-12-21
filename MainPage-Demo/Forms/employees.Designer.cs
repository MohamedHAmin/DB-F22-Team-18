
namespace MainPage_Demo.Forms
{
    partial class employees
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
            this.employeepanel = new System.Windows.Forms.Panel();
            this.addemployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeepanel
            // 
            this.employeepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeepanel.AutoScroll = true;
            this.employeepanel.BackColor = System.Drawing.Color.LightBlue;
            this.employeepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeepanel.Location = new System.Drawing.Point(146, 35);
            this.employeepanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeepanel.Name = "employeepanel";
            this.employeepanel.Size = new System.Drawing.Size(931, 344);
            this.employeepanel.TabIndex = 4;
            // 
            // addemployee
            // 
            this.addemployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addemployee.BackColor = System.Drawing.Color.Silver;
            this.addemployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addemployee.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.addemployee.Location = new System.Drawing.Point(506, 427);
            this.addemployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addemployee.Name = "addemployee";
            this.addemployee.Size = new System.Drawing.Size(205, 71);
            this.addemployee.TabIndex = 5;
            this.addemployee.Text = "Add Employee";
            this.addemployee.UseVisualStyleBackColor = false;
            this.addemployee.Click += new System.EventHandler(this.addemployee_Click);
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1306, 522);
            this.Controls.Add(this.addemployee);
            this.Controls.Add(this.employeepanel);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "employees";
            this.Text = "employess";
            this.Load += new System.EventHandler(this.employees_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel employeepanel;
        private System.Windows.Forms.Button addemployee;
    }
}