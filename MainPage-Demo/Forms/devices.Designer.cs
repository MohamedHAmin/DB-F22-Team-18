
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
            this.saveButton = new System.Windows.Forms.Button();
            this.discardButton = new System.Windows.Forms.Button();
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
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.BackColor = System.Drawing.Color.Silver;
            this.saveButton.Enabled = false;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.saveButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.DimGray;
            this.saveButton.Location = new System.Drawing.Point(271, 558);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 65);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // discardButton
            // 
            this.discardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.discardButton.BackColor = System.Drawing.Color.Silver;
            this.discardButton.Enabled = false;
            this.discardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.discardButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardButton.ForeColor = System.Drawing.Color.DimGray;
            this.discardButton.Location = new System.Drawing.Point(609, 558);
            this.discardButton.Margin = new System.Windows.Forms.Padding(0);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(147, 65);
            this.discardButton.TabIndex = 7;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = false;
            this.discardButton.Click += new System.EventHandler(this.discardButton_Click_1);
            // 
            // devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 677);
            this.Controls.Add(this.discardButton);
            this.Controls.Add(this.saveButton);
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
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button discardButton;
    }
}