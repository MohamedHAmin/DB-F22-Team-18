using System.Windows.Forms;
namespace MainPage_Demo.Forms
{
    partial class Order
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Createbtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panel2.Size = new System.Drawing.Size(1097, 532);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1077, 516);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 512);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Searchbtn);
            this.groupBox1.Controls.Add(this.PhoneNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(445, 311);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for user";
            // 
            // Searchbtn
            // 
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbtn.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.Searchbtn.Image = global::MainPage_Demo.Properties.Resources.search_free_icon_font;
            this.Searchbtn.Location = new System.Drawing.Point(116, 234);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(208, 54);
            this.Searchbtn.TabIndex = 10;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumber.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.PhoneNumber.Location = new System.Drawing.Point(116, 128);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumber.MaxLength = 11;
            this.PhoneNumber.Multiline = true;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(281, 27);
            this.PhoneNumber.TabIndex = 8;
            this.PhoneNumber.TextChanged += new System.EventHandler(this.PhoneNumber_TextChanged);
            this.PhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneNumber_KeyDown);
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.MaximumSize = new System.Drawing.Size(105, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(541, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 512);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lastname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.firstname);
            this.groupBox2.Controls.Add(this.phone);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Createbtn);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.groupBox2.Location = new System.Drawing.Point(46, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(445, 311);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create new user";
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.SystemColors.Window;
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.lastname.Location = new System.Drawing.Point(137, 128);
            this.lastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastname.Multiline = true;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(281, 27);
            this.lastname.TabIndex = 15;
            this.lastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastname_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Last Name";
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.SystemColors.Window;
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.firstname.Location = new System.Drawing.Point(137, 79);
            this.firstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstname.Multiline = true;
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(281, 27);
            this.firstname.TabIndex = 13;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            this.firstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstname_KeyDown);
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.phone.Location = new System.Drawing.Point(137, 181);
            this.phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone.MaxLength = 11;
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(281, 27);
            this.phone.TabIndex = 12;
            this.phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phone_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(26, 173);
            this.label1.MaximumSize = new System.Drawing.Size(105, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name";
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.Color.Transparent;
            this.Createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Createbtn.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.Createbtn.Image = global::MainPage_Demo.Properties.Resources.add_document_free_icon_font__2_;
            this.Createbtn.Location = new System.Drawing.Point(107, 234);
            this.Createbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(244, 58);
            this.Createbtn.TabIndex = 0;
            this.Createbtn.Text = "Create";
            this.Createbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Createbtn.UseVisualStyleBackColor = false;
            this.Createbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1097, 532);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(999, 495);
            this.Name = "Order";
            this.Text = "Order";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private GroupBox groupBox2;
        private Button Createbtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox PhoneNumber;
        private Label label3;
        private Panel panel4;
        private Button Searchbtn;
        private TextBox firstname;
        private TextBox phone;
        private Label label1;
        private Label label4;
        private TextBox lastname;
        private Label label5;
    }
}