using System;
using System.Windows.Forms;
using maytinh; // Reference đến DLL

namespace MayTinhDesktopApp
{
    public partial class Form1 : Form
    {
        private Label lblFirstNumber;
        private Label SecondNumber;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private ComboBox cmbOperation;
        private Button btnCalculate;
        private Label lblResult;
        private Label lblOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNumber1.Text);
                double num2 = Convert.ToDouble(txtNumber2.Text);
                string op = cmbOperation.SelectedItem.ToString();

                MayTinhCalculator calc = new MayTinhCalculator();
                calc.Number1 = num1;
                calc.Number2 = num2;
                calc.Operation = op;
                double result = calc.Calculate();

                lblResult.Text = "Result: " + result + "\r\nCosmic Math by Long – Inspired by the Universe!"; // Thay "Long" bằng tên mày nếu khác
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: " + ex.Message;
            }
        }

        private void InitializeComponent()
        {
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.SecondNumber = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(2, 9);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(83, 16);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First Number";
            // 
            // SecondNumber
            // 
            this.SecondNumber.AutoSize = true;
            this.SecondNumber.Location = new System.Drawing.Point(2, 47);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(116, 16);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.Text = "lblSecondNumber";
            this.SecondNumber.Click += new System.EventHandler(this.SecondNumber_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(2, 95);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(66, 16);
            this.lblOperation.TabIndex = 2;
            this.lblOperation.Text = "Operation";
            this.lblOperation.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(142, 6);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 22);
            this.txtNumber1.TabIndex = 3;
            this.txtNumber1.Text = "txtNumber1";
            this.txtNumber1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(142, 47);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 22);
            this.txtNumber2.TabIndex = 4;
            this.txtNumber2.Text = "txtNumber2";
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Location = new System.Drawing.Point(142, 92);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(121, 24);
            this.cmbOperation.TabIndex = 5;
            this.cmbOperation.Text = "cmbOperation";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(102, 147);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "caculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(24, 189);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(451, 327);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SecondNumber_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}