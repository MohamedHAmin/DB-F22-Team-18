using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace MainPage_Demo.Forms
{
    public partial class employees : Form
    {
        Controller controllerObj;
        int totalemployees = 0;
        int listSize_employees = 10;
        string buttonsState;
     
        public employees()
        {
            controllerObj = new Controller();
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
        }
        private void buttonActivation(bool state,Button save)
        {
            if (state == true)
            {
                
                save.Enabled = true;
                save.FlatStyle = FlatStyle.Flat;
                save.BackColor = Color.LightGreen;
                save.ForeColor = Color.FromArgb(33, 86, 118);
            }
            else
            {
               
                save.Enabled = false;
                save.FlatStyle = FlatStyle.Standard;
                save.BackColor = Color.Silver;
                save.ForeColor = Color.DimGray;
            }
        }

        private GroupBox createemployee(String employeeName, Point position,string type,string phone_no,int salary,long ssn)
        {
            Label nametemp = new Label();
            nametemp.Text = "Name: "+employeeName;
            nametemp.Location = new Point(18, 20);
            nametemp.Size = new Size(190 , 15);
            nametemp.ForeColor = Color.FromArgb(33, 86, 118);
            nametemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);
            nametemp.Tag = totalemployees;

            Label typetemp = new Label();
            typetemp.Text = type;
            typetemp.Location = new Point(18, 40);
            typetemp.Size = new Size(60, 15);
            typetemp.ForeColor = Color.FromArgb(33, 86, 118);
            typetemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);
            typetemp.Tag = totalemployees;

            Label phoneTemp = new Label();
            phoneTemp.Text = "phone number :";
            phoneTemp.Location = new Point(18, 60);
            phoneTemp.Size = new Size(140, 15);
            phoneTemp.ForeColor = Color.FromArgb(33, 86, 118);
            phoneTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);
            phoneTemp.Tag = totalemployees;

            Label salaryTemp = new Label();
            salaryTemp.Text = "salary : " + salary.ToString();
            salaryTemp.Location = new Point(18, 110);
            salaryTemp.Size = new Size(46, 15);
            salaryTemp.ForeColor = Color.FromArgb(33, 86, 118);
            salaryTemp.Font = new Font("Lucida Bright", 9, FontStyle.Bold);
            salaryTemp.Tag = totalemployees;


            TextBox phone_no_TextBox = new TextBox();
            phone_no_TextBox.Text = phone_no.ToString();
            phone_no_TextBox.Location = new Point(26, 80);
            phone_no_TextBox.Size = new Size(80, 20);
            phone_no_TextBox.TextChanged += phone_noChangeCheck;
            phone_no_TextBox.Tag = totalemployees;

            TextBox salaryTextBox = new TextBox();
            salaryTextBox.Text = salary.ToString();
            salaryTextBox.Location = new Point(80, 105);
            salaryTextBox.Size = new Size(70, 20);
            salaryTextBox.TextChanged += salaryChangeCheck;
            salaryTextBox.Tag = totalemployees;


            Button remove = new Button();
            remove.Text = "Remove";
            remove.Location = new Point(20, 135);
            remove.Size = new Size(70, 25);
            remove.Visible = true;
            remove.Enabled = true;
            remove.Click += removeemployee;
            remove.BackColor = Color.LightCoral;
            remove.ForeColor = Color.FromArgb(33, 86, 118);
            remove.Tag = totalemployees;

            Button save = new Button();
            save.Text = "Save";
            save.Location = new Point(100, 135);
            save.Size = new Size(70, 25);
            save.BackColor = Color.Silver;
            save.Visible = true;
            save.Click += saveemployee;
            save.Tag = totalemployees;


            GroupBox employee = new GroupBox();
            employee.Location = position;
            employee.Size = new Size(210, 170);
            employee.Tag = ssn;
            employee.Controls.Add(nametemp);
            employee.Controls.Add(typetemp);
            employee.Controls.Add(phoneTemp);
            employee.Controls.Add(phone_no_TextBox);
            employee.Controls.Add(salaryTemp);
            employee.Controls.Add(salaryTextBox);
            employee.Controls.Add(remove);
            employee.Controls.Add(save);
            employee.Controls.Add(nametemp);
            
            employee.Controls.Add(typetemp);
            employee.Controls.Add(phoneTemp);
            employee.Controls.Add(phone_no_TextBox);
            employee.Controls.Add(salaryTemp);
            employee.Controls.Add(salaryTextBox);
            employee.Controls.Add(remove);
            employee.Controls.Add(save);

            return employee;
        }
      
        private void employees_Load(object sender, EventArgs e)
        {
            //Temporary Variables To Be Replaced by DB Values
            Point origin = new Point(35, 3);
            Point pos = new Point(35, 3);
            int maxPerRow = 3;
            int counter = 0;
            DataTable dt=controllerObj.selectWorkersInfo();
            employeepanel.Controls.Clear();
            totalemployees = 0;
            listSize_employees = dt.Rows.Count;
            string name;
            string type = "worker";
            string phone_no;
            int salary;
            long ssn;
            for (int i = 0; i < listSize_employees; i++)
            {
                name = dt.Rows[i][0]+" "+dt.Rows[i][1];
                phone_no= dt.Rows[i][4].ToString();
                salary= Int32.Parse((dt.Rows[i][3]).ToString());
                ssn = Int64.Parse((dt.Rows[i][2]).ToString());
                buttonsState += "0";
                GroupBox employee = createemployee(name, pos, type, phone_no, salary,ssn); //Price and Name are obtained from product list
                employeepanel.Controls.Add(employee);
                totalemployees++;
                counter++;
                if (counter == maxPerRow)
                {
                    pos.X = origin.X;
                    pos.Y += employee.Height + 5;
                    counter = 0;
                }
                else
                {
                    pos.X += employee.Width + 8;
                }
            }

            

        }
      private void set_background(object sender, PaintEventArgs e)
        {
           
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(183, 217, 216), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(183, 217, 216), Color.FromArgb(222, 159, 190), LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        
            }
        private void salaryChangeCheck(object sender, EventArgs e)
        {
            TextBox salarytextBox = sender as TextBox;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox employee = (GroupBox)salarytextBox.Parent;
            int salary = controllerObj.selectsalarywithssn(Int64.Parse(employee.Tag.ToString()));
            
            if (salarytextBox.Text == salary.ToString())
            //if a price is changed go check if it is the same as in the database
            {
                //if yess=> 
                char[] temp = buttonsState.ToCharArray();
                temp[(int)salarytextBox.Tag] = '0';
                buttonsState = string.Join("", temp);
            }
            else
            {
                char[] temp = buttonsState.ToCharArray();
                temp[(int)salarytextBox.Tag] = '1';
                buttonsState = string.Join("", temp);
            }
            
            if (buttonsState.Contains('1') == false)
            //if a price is changed go check if it is the same as in the database
            {
                buttonActivation(false,(Button)employee.Controls[7]);
            }
            else
            {
                buttonActivation(true, (Button)employee.Controls[7]);
            }
        }
        private void phone_noChangeCheck(object sender, EventArgs e)
        {
            TextBox phone_notextBox = sender as TextBox;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox employee = (GroupBox)phone_notextBox.Parent;
            long phone_no = controllerObj.selectphonenowithssn(Int64.Parse(employee.Tag.ToString()));
            if (phone_notextBox.Text == phone_no.ToString())
            //if a price is changed go check if it is the same as in the database
            {
                //if yess=> 
                char[] temp = buttonsState.ToCharArray();
                temp[(int)phone_notextBox.Tag] = '0';
                buttonsState = string.Join("", temp);

            }
            else
            {
                char[] temp = buttonsState.ToCharArray();
                temp[(int)phone_notextBox.Tag] = '1';
                buttonsState = string.Join("", temp);
            }

            if (buttonsState.Contains('1') == false)
            //if a price is changed go check if it is the same as in the database
            {
                buttonActivation(false, (Button)employee.Controls[7]);
            }
            else
            {
                buttonActivation(true, (Button)employee.Controls[7]);
            }
        }
        private void employees_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
        private void removeemployee(object sender, EventArgs e)
        {
            listSize_employees--;
            totalemployees--;
            Button remove = sender as Button;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox employee = (GroupBox)remove.Parent;
            controllerObj.delete_worker(Int64.Parse(employee.Tag.ToString()));
            employees_Load(employeepanel, e);
        }
      
        private void addemployee_MouseHover(object sender, EventArgs e)
        {
            addemployee.BackColor = Color.FromArgb(33, 86, 118);
            addemployee.ForeColor = Color.FromArgb(33, 86, 118);
        }

        private void addemployee_MouseLeave(object sender, EventArgs e)
        {
            addemployee.BackColor = Color.Silver;
        }

        private void addemployee_Click(object sender, EventArgs e)
        {
            CreateWorker a = new CreateWorker(ref listSize_employees);
            a.Show();
            employees_Load(employeepanel, e);

        }
        private void saveemployee(object sender, EventArgs e)
        {
            int flag1 = 0;
            int flag2 = 0;
            Button save = sender as Button;
            //priceTextBox.Text=priceTextBox.Text.Replace(" ", "");
            GroupBox employee = (GroupBox)save.Parent;
            String phone_no = ((TextBox)employee.Controls[3]).Text;
            String salary = ((TextBox)employee.Controls[5]).Text;
            long ssn = Int64.Parse(employee.Tag.ToString());
            if (phone_no.All(Char.IsDigit) && phone_no != "" && Regex.IsMatch(phone_no, @"^[0-9]{11}$"))
            {
                controllerObj.update_phoneno(ssn,Int64.Parse(phone_no));
                flag1 = 1;
            }
            else
            {
                MessageBox.Show("invalid phone_no");
                flag1 = 0;

            }
            if (salary.All(Char.IsDigit) && salary != "")
            {
                controllerObj.update_salary(ssn, Int16.Parse(salary));
                flag2 = 1;
            }
            else
            {
                MessageBox.Show("invalid salary");
                flag2 = 0;
            }

            if (flag1 == 1 && flag2 == 1)
            {
                buttonActivation(false, (Button)employee.Controls[7]);
                buttonsState = buttonsState.Replace('1', '0');
            }

            
        }

    }
        
    }


