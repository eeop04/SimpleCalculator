namespace SimpleCalculator
{
    partial class Form1
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
            buttonCE = new Button();
            buttonDel = new Button();
            buttonDiv = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonMul = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonSub = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonAdd = new Button();
            buttonSign = new Button();
            button0 = new Button();
            buttonDot = new Button();
            buttonEqual = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonC = new Button();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            LblName = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold);
            buttonCE.Location = new Point(135, 3);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(124, 70);
            buttonCE.TabIndex = 1;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold);
            buttonDel.Location = new Point(267, 3);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(124, 70);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Del";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.BackColor = Color.FromArgb(255, 128, 0);
            buttonDiv.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            buttonDiv.ForeColor = Color.White;
            buttonDiv.Location = new Point(399, 3);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(124, 70);
            buttonDiv.TabIndex = 3;
            buttonDiv.Text = "÷";
            buttonDiv.UseVisualStyleBackColor = false;
            buttonDiv.Click += buttonDiv_Click;
            buttonDiv.KeyDown += buttonDiv_KeyDown;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Font = new Font("휴먼둥근헤드라인", 22.2F);
            button7.ForeColor = Color.Cyan;
            button7.Location = new Point(3, 91);
            button7.Name = "button7";
            button7.Size = new Size(124, 70);
            button7.TabIndex = 4;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            button7.KeyDown += button7_KeyDown;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaption;
            button8.Font = new Font("휴먼둥근헤드라인", 22.2F);
            button8.ForeColor = Color.Cyan;
            button8.Location = new Point(135, 91);
            button8.Name = "button8";
            button8.Size = new Size(124, 70);
            button8.TabIndex = 5;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            button8.KeyDown += button8_KeyDown;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaption;
            button9.Font = new Font("휴먼둥근헤드라인", 22.2F);
            button9.ForeColor = Color.Cyan;
            button9.Location = new Point(267, 91);
            button9.Name = "button9";
            button9.Size = new Size(124, 70);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            button9.KeyDown += button9_KeyDown;
            // 
            // buttonMul
            // 
            buttonMul.BackColor = Color.FromArgb(255, 128, 0);
            buttonMul.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold);
            buttonMul.ForeColor = Color.White;
            buttonMul.Location = new Point(399, 91);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(124, 70);
            buttonMul.TabIndex = 7;
            buttonMul.Text = "*";
            buttonMul.UseVisualStyleBackColor = false;
            buttonMul.Click += buttonMul_Click;
            buttonMul.KeyDown += buttonMul_KeyDown;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("휴먼둥근헤드라인", 22.2F);
            button4.ForeColor = Color.Cyan;
            button4.Location = new Point(3, 179);
            button4.Name = "button4";
            button4.Size = new Size(124, 70);
            button4.TabIndex = 8;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.KeyDown += button4_KeyDown;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("휴먼둥근헤드라인", 22.2F);
            button5.ForeColor = Color.Cyan;
            button5.Location = new Point(135, 179);
            button5.Name = "button5";
            button5.Size = new Size(124, 70);
            button5.TabIndex = 9;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            button5.KeyDown += button5_KeyDown;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Font = new Font("휴먼둥근헤드라인", 22.2F);
            button6.ForeColor = Color.Cyan;
            button6.Location = new Point(267, 179);
            button6.Name = "button6";
            button6.Size = new Size(124, 70);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            button6.KeyDown += button6_KeyDown;
            // 
            // buttonSub
            // 
            buttonSub.BackColor = Color.FromArgb(255, 128, 0);
            buttonSub.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold);
            buttonSub.ForeColor = Color.White;
            buttonSub.Location = new Point(399, 179);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(124, 70);
            buttonSub.TabIndex = 11;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = false;
            buttonSub.Click += buttonSub_Click;
            buttonSub.KeyDown += buttonSub_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("휴먼둥근헤드라인", 22.2F);
            button1.ForeColor = Color.Cyan;
            button1.Location = new Point(3, 267);
            button1.Name = "button1";
            button1.Size = new Size(124, 70);
            button1.TabIndex = 12;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.KeyDown += Form1_KeyDown;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("휴먼둥근헤드라인", 22.2F);
            button2.ForeColor = Color.Cyan;
            button2.Location = new Point(135, 267);
            button2.Name = "button2";
            button2.Size = new Size(124, 70);
            button2.TabIndex = 13;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.KeyDown += button2_KeyDown;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("휴먼둥근헤드라인", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button3.ForeColor = Color.Cyan;
            button3.Location = new Point(267, 267);
            button3.Name = "button3";
            button3.Size = new Size(124, 70);
            button3.TabIndex = 14;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button15_Click;
            button3.KeyDown += button3_KeyDown;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(255, 128, 0);
            buttonAdd.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(399, 267);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(124, 70);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            buttonAdd.KeyDown += buttonAdd_KeyDown;
            // 
            // buttonSign
            // 
            buttonSign.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold);
            buttonSign.Location = new Point(3, 355);
            buttonSign.Name = "buttonSign";
            buttonSign.Size = new Size(124, 70);
            buttonSign.TabIndex = 16;
            buttonSign.Text = "+/-";
            buttonSign.UseVisualStyleBackColor = true;
            buttonSign.Click += buttonSign_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ActiveCaption;
            button0.Font = new Font("휴먼둥근헤드라인", 22.2F);
            button0.ForeColor = Color.Cyan;
            button0.Location = new Point(135, 355);
            button0.Name = "button0";
            button0.Size = new Size(124, 70);
            button0.TabIndex = 17;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold);
            buttonDot.Location = new Point(267, 355);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(124, 70);
            buttonDot.TabIndex = 18;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.ActiveCaption;
            buttonEqual.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold);
            buttonEqual.ForeColor = Color.White;
            buttonEqual.Location = new Point(399, 355);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(124, 70);
            buttonEqual.TabIndex = 19;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += button20_Click;
            buttonEqual.KeyDown += buttonEqual_KeyDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(buttonC, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonEqual, 3, 4);
            tableLayoutPanel1.Controls.Add(buttonDot, 2, 4);
            tableLayoutPanel1.Controls.Add(button0, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonSign, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonAdd, 3, 3);
            tableLayoutPanel1.Controls.Add(button3, 2, 3);
            tableLayoutPanel1.Controls.Add(button2, 1, 3);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonSub, 3, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 2);
            tableLayoutPanel1.Controls.Add(button5, 1, 2);
            tableLayoutPanel1.Controls.Add(button4, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonMul, 3, 1);
            tableLayoutPanel1.Controls.Add(button9, 2, 1);
            tableLayoutPanel1.Controls.Add(button8, 1, 1);
            tableLayoutPanel1.Controls.Add(button7, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonDiv, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonDel, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonCE, 1, 0);
            tableLayoutPanel1.Location = new Point(52, 192);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(529, 440);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.Red;
            buttonC.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold);
            buttonC.Location = new Point(3, 3);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(124, 70);
            buttonC.TabIndex = 20;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtOutput.Location = new Point(52, 124);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(529, 51);
            txtOutput.TabIndex = 1;
            txtOutput.TextChanged += txtInput_TextChanged;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(52, 54);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(529, 43);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += txtOutput_TextChanged;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("한컴 말랑말랑 Bold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LblName.Location = new Point(60, 15);
            LblName.Name = "LblName";
            LblName.Size = new Size(157, 30);
            LblName.TabIndex = 3;
            LblName.Text = "@간단 계산기@";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 657);
            Controls.Add(LblName);
            Controls.Add(txtInput);
            Controls.Add(txtOutput);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCE;
        private Button buttonDel;
        private Button buttonDiv;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonMul;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonSub;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonAdd;
        private Button buttonSign;
        private Button button0;
        private Button buttonDot;
        private Button buttonEqual;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonC;
        private TextBox txtOutput;
        private TextBox txtInput;
        private Label LblName;
    }
}
