
namespace MainPage_Demo.Forms
{
    partial class devices
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
            this.productPanel = new System.Windows.Forms.Panel();
            this.editPriceTitle = new System.Windows.Forms.Label();
            this.adddeviceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productPanel
            // 
            this.productPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPanel.AutoScroll = true;
            this.productPanel.BackColor = System.Drawing.Color.Thistle;
            this.productPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPanel.Location = new System.Drawing.Point(142, 105);
            this.productPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(802, 407);
            this.productPanel.TabIndex = 4;
            this.productPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.productPanel_Paint);
            // 
            // editPriceTitle
            // 
            this.editPriceTitle.AutoSize = true;
            this.editPriceTitle.BackColor = System.Drawing.Color.Transparent;
            this.editPriceTitle.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.editPriceTitle.Location = new System.Drawing.Point(50, 13);
            this.editPriceTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editPriceTitle.Name = "editPriceTitle";
            this.editPriceTitle.Size = new System.Drawing.Size(266, 68);
            this.editPriceTitle.TabIndex = 5;
            this.editPriceTitle.Text = "Devices";
            this.editPriceTitle.Click += new System.EventHandler(this.editPriceTitle_Click);
            // 
            // adddeviceButton
            // 
            this.adddeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adddeviceButton.BackColor = System.Drawing.Color.Silver;
            this.adddeviceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.adddeviceButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddeviceButton.ForeColor = System.Drawing.Color.DimGray;
            this.adddeviceButton.Location = new System.Drawing.Point(442, 557);
            this.adddeviceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adddeviceButton.Name = "adddeviceButton";
            this.adddeviceButton.Size = new System.Drawing.Size(256, 65);
            this.adddeviceButton.TabIndex = 6;
            this.adddeviceButton.Text = "Add Device";
            this.adddeviceButton.UseVisualStyleBackColor = false;
            this.adddeviceButton.Click += new System.EventHandler(this.adddevice_button);
            // 
            // devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 677);
            this.Controls.Add(this.adddeviceButton);
            this.Controls.Add(this.editPriceTitle);
            this.Controls.Add(this.productPanel);
            this.Name = "devices";
            this.ShowInTaskbar = false;
            this.Text = "devices";
            this.Load += new System.EventHandler(this.devices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Label editPriceTitle;
        private System.Windows.Forms.Button adddeviceButton;
    }
}