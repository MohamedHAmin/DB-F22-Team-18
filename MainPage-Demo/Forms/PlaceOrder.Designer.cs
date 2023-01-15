namespace MainPage_Demo.Forms
{
    partial class PlaceOrder
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
            this.Remove = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.ApplyOffer = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.serviceList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.offerLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Remove);
            this.panel1.Controls.Add(this.customerName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Confirm);
            this.panel1.Controls.Add(this.OrderView);
            this.panel1.Controls.Add(this.ApplyOffer);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.serviceList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.offerLable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 639);
            this.panel1.TabIndex = 1;
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.Remove.Location = new System.Drawing.Point(528, 170);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(114, 38);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.customerName.Location = new System.Drawing.Point(501, 66);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(189, 26);
            this.customerName.TabIndex = 12;
            this.customerName.Text = "Cutomer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(298, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.panel3.Controls.Add(this.TotalCost);
            this.panel3.Location = new System.Drawing.Point(186, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 54);
            this.panel3.TabIndex = 10;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.TotalCost.ForeColor = System.Drawing.Color.White;
            this.TotalCost.Location = new System.Drawing.Point(62, 15);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(54, 26);
            this.TotalCost.TabIndex = 0;
            this.TotalCost.Text = "000";
            this.TotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(95, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total :";
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.Confirm.Location = new System.Drawing.Point(718, 486);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(148, 54);
            this.Confirm.TabIndex = 8;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // OrderView
            // 
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderView.Location = new System.Drawing.Point(105, 230);
            this.OrderView.Name = "OrderView";
            this.OrderView.ReadOnly = true;
            this.OrderView.RowHeadersWidth = 51;
            this.OrderView.RowTemplate.Height = 24;
            this.OrderView.Size = new System.Drawing.Size(537, 235);
            this.OrderView.TabIndex = 7;
            // 
            // ApplyOffer
            // 
            this.ApplyOffer.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyOffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.ApplyOffer.Location = new System.Drawing.Point(744, 209);
            this.ApplyOffer.Name = "ApplyOffer";
            this.ApplyOffer.Size = new System.Drawing.Size(96, 43);
            this.ApplyOffer.TabIndex = 6;
            this.ApplyOffer.Text = "Apply";
            this.ApplyOffer.UseVisualStyleBackColor = true;
            this.ApplyOffer.Click += new System.EventHandler(this.ApplyOffer_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.Add.Location = new System.Drawing.Point(528, 126);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(114, 38);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // serviceList
            // 
            this.serviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceList.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceList.ForeColor = System.Drawing.Color.Black;
            this.serviceList.FormattingEnabled = true;
            this.serviceList.Location = new System.Drawing.Point(202, 132);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(273, 28);
            this.serviceList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(86, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Service :";
            // 
            // offerLable
            // 
            this.offerLable.AutoSize = true;
            this.offerLable.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offerLable.Location = new System.Drawing.Point(739, 168);
            this.offerLable.Name = "offerLable";
            this.offerLable.Size = new System.Drawing.Size(81, 26);
            this.offerLable.TabIndex = 2;
            this.offerLable.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(692, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Offer";
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
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 639);
            this.Controls.Add(this.panel1);
            this.Name = "PlaceOrder";
            this.Text = "PlaceOrder";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlaceOrder_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.DataGridView OrderView;
        private System.Windows.Forms.Button ApplyOffer;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox serviceList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label offerLable;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Remove;
    }
}