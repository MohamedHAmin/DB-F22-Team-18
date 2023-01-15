namespace MainPage_Demo.Forms
{
    partial class Inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(225)))));
            this.panel1.Location = new System.Drawing.Point(54, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 405);
            this.panel1.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Silver;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(244, 530);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(144, 44);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DiscardButton
            // 
            this.DiscardButton.BackColor = System.Drawing.Color.Silver;
            this.DiscardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscardButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscardButton.Location = new System.Drawing.Point(544, 530);
            this.DiscardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DiscardButton.Name = "DiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(144, 44);
            this.DiscardButton.TabIndex = 4;
            this.DiscardButton.Text = "Discard";
            this.DiscardButton.UseVisualStyleBackColor = false;
            this.DiscardButton.Click += new System.EventHandler(this.DiscardButton_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 639);
            this.Controls.Add(this.DiscardButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DiscardButton;
    }
}