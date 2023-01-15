
namespace MainPage_Demo.Forms
{
    partial class Edit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editPriceTitle = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.discardButton = new System.Windows.Forms.Button();
            this.productPanel = new System.Windows.Forms.Panel();
            this.addservice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editPriceTitle
            // 
            this.editPriceTitle.AutoSize = true;
            this.editPriceTitle.BackColor = System.Drawing.Color.Transparent;
            this.editPriceTitle.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.editPriceTitle.Location = new System.Drawing.Point(96, 39);
            this.editPriceTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editPriceTitle.Name = "editPriceTitle";
            this.editPriceTitle.Size = new System.Drawing.Size(280, 68);
            this.editPriceTitle.TabIndex = 0;
            this.editPriceTitle.Text = "Services";
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
            this.saveButton.Location = new System.Drawing.Point(315, 583);
            this.saveButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 65);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // discardButton
            // 
            this.discardButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.discardButton.BackColor = System.Drawing.Color.Silver;
            this.discardButton.Enabled = false;
            this.discardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.discardButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardButton.ForeColor = System.Drawing.Color.DimGray;
            this.discardButton.Location = new System.Drawing.Point(592, 583);
            this.discardButton.Margin = new System.Windows.Forms.Padding(0);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(147, 65);
            this.discardButton.TabIndex = 2;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = false;
            this.discardButton.Click += new System.EventHandler(this.discardButton_Click);
            // 
            // productPanel
            // 
            this.productPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPanel.AutoScroll = true;
            this.productPanel.BackColor = System.Drawing.Color.Thistle;
            this.productPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPanel.Location = new System.Drawing.Point(140, 140);
            this.productPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(802, 407);
            this.productPanel.TabIndex = 3;
            this.productPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.productPanel_Paint);
            // 
            // addservice
            // 
            this.addservice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addservice.BackColor = System.Drawing.Color.Silver;
            this.addservice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addservice.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addservice.ForeColor = System.Drawing.Color.DimGray;
            this.addservice.Location = new System.Drawing.Point(871, 583);
            this.addservice.Margin = new System.Windows.Forms.Padding(0);
            this.addservice.Name = "addservice";
            this.addservice.Size = new System.Drawing.Size(200, 65);
            this.addservice.TabIndex = 4;
            this.addservice.Text = "Add Service";
            this.addservice.UseVisualStyleBackColor = false;
            this.addservice.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 677);
            this.Controls.Add(this.addservice);
            this.Controls.Add(this.discardButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editPriceTitle);
            this.Controls.Add(this.productPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Edit";
            this.ShowInTaskbar = false;
            this.Text = "Edit Price";
            this.Load += new System.EventHandler(this.editPriceForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.editPriceForm_Paint);
            this.Resize += new System.EventHandler(this.editPriceForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editPriceTitle;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button discardButton;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Button addservice;
    }
}

