namespace MainPage_Demo.Forms
{
    partial class History
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
            this.Logs = new System.Windows.Forms.DataGridView();
            this.DurationList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logs)).BeginInit();
            this.SuspendLayout();
            // 
            // Logs
            // 
            this.Logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Logs.Location = new System.Drawing.Point(12, 84);
            this.Logs.Name = "Logs";
            this.Logs.RowHeadersWidth = 51;
            this.Logs.RowTemplate.Height = 24;
            this.Logs.Size = new System.Drawing.Size(958, 543);
            this.Logs.TabIndex = 0;
            // 
            // DurationList
            // 
            this.DurationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DurationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationList.FormattingEnabled = true;
            this.DurationList.Location = new System.Drawing.Point(183, 27);
            this.DurationList.Name = "DurationList";
            this.DurationList.Size = new System.Drawing.Size(264, 33);
            this.DurationList.TabIndex = 1;
            this.DurationList.SelectedIndexChanged += new System.EventHandler(this.DurationList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "View By:";
            // 
            // select
            // 
            this.select.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.select.Location = new System.Drawing.Point(742, 26);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(130, 33);
            this.select.TabIndex = 3;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.button1_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 639);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DurationList);
            this.Controls.Add(this.Logs);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Logs;
        private System.Windows.Forms.ComboBox DurationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select;
    }
}