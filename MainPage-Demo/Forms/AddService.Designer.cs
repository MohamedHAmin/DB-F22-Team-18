
namespace MainPage_Demo.Forms
{
    partial class AddService
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
            this.price = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.serviceduration = new System.Windows.Forms.TextBox();
            this.servicename = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Silver;
            this.price.Location = new System.Drawing.Point(411, 93);
            this.price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(332, 54);
            this.price.TabIndex = 4;
            this.price.Text = "Price";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(253, 356);
            this.create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(224, 59);
            this.create.TabIndex = 2;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // serviceduration
            // 
            this.serviceduration.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceduration.ForeColor = System.Drawing.Color.Silver;
            this.serviceduration.Location = new System.Drawing.Point(13, 192);
            this.serviceduration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serviceduration.Name = "serviceduration";
            this.serviceduration.Size = new System.Drawing.Size(350, 54);
            this.serviceduration.TabIndex = 1;
            this.serviceduration.Text = "Service Duration";
            this.serviceduration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serviceduration.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // servicename
            // 
            this.servicename.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicename.ForeColor = System.Drawing.Color.Silver;
            this.servicename.Location = new System.Drawing.Point(13, 93);
            this.servicename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.servicename.Name = "servicename";
            this.servicename.Size = new System.Drawing.Size(350, 54);
            this.servicename.TabIndex = 0;
            this.servicename.Text = "Service Name";
            this.servicename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.discount);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.create);
            this.groupBox1.Controls.Add(this.servicename);
            this.groupBox1.Controls.Add(this.serviceduration);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(39, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 433);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Service";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.ForeColor = System.Drawing.Color.Silver;
            this.discount.Location = new System.Drawing.Point(411, 192);
            this.discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(332, 54);
            this.discount.TabIndex = 6;
            this.discount.Text = "Discount";
            this.discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddService";
            this.Text = "addservice";
            this.Load += new System.EventHandler(this.addservice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox serviceduration;
        private System.Windows.Forms.TextBox servicename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox discount;
    }
}