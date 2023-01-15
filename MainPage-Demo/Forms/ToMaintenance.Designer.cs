namespace MainPage_Demo.Forms
{
    partial class ToMaintenance
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
            this.toMaintenanceView = new System.Windows.Forms.DataGridView();
            this.AddDevice = new System.Windows.Forms.Button();
            this.DevicesList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toMaintenanceView)).BeginInit();
            this.SuspendLayout();
            // 
            // toMaintenanceView
            // 
            this.toMaintenanceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toMaintenanceView.Location = new System.Drawing.Point(92, 176);
            this.toMaintenanceView.Name = "toMaintenanceView";
            this.toMaintenanceView.ReadOnly = true;
            this.toMaintenanceView.RowHeadersWidth = 51;
            this.toMaintenanceView.RowTemplate.Height = 24;
            this.toMaintenanceView.Size = new System.Drawing.Size(778, 284);
            this.toMaintenanceView.TabIndex = 11;
            // 
            // AddDevice
            // 
            this.AddDevice.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.AddDevice.Location = new System.Drawing.Point(629, 110);
            this.AddDevice.Name = "AddDevice";
            this.AddDevice.Size = new System.Drawing.Size(114, 47);
            this.AddDevice.TabIndex = 10;
            this.AddDevice.Text = "Add";
            this.AddDevice.UseVisualStyleBackColor = true;
            this.AddDevice.Click += new System.EventHandler(this.AddDevice_Click);
            // 
            // DevicesList
            // 
            this.DevicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DevicesList.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevicesList.ForeColor = System.Drawing.Color.Black;
            this.DevicesList.FormattingEnabled = true;
            this.DevicesList.Location = new System.Drawing.Point(351, 122);
            this.DevicesList.Name = "DevicesList";
            this.DevicesList.Size = new System.Drawing.Size(235, 28);
            this.DevicesList.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(235, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Device :";
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.Confirm.Location = new System.Drawing.Point(401, 478);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(148, 54);
            this.Confirm.TabIndex = 12;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.Remove.Location = new System.Drawing.Point(756, 110);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(114, 47);
            this.Remove.TabIndex = 14;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // ToMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 639);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.toMaintenanceView);
            this.Controls.Add(this.AddDevice);
            this.Controls.Add(this.DevicesList);
            this.Controls.Add(this.label3);
            this.Name = "ToMaintenance";
            this.Text = "To Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.toMaintenanceView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView toMaintenanceView;
        private System.Windows.Forms.Button AddDevice;
        private System.Windows.Forms.ComboBox DevicesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Remove;
    }
}