using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private string currentOperator = "";
        private bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.ReadOnly = true;
            txtOutput.ReadOnly = true;

            txtInput.TabStop = false;
            txtOutput.TabStop = false;

            button0.TabStop = false;
            button1.TabStop = false;
            button2.TabStop = false;
            button3.TabStop = false;
            button4.TabStop = false;
            button5.TabStop = false;
            button6.TabStop = false;
            button7.TabStop = false;
            button8.TabStop = false;
            button9.TabStop = false;
            buttonAdd.TabStop = false;
            buttonSub.TabStop = false;
            buttonMul.TabStop = false;
            buttonDiv.TabStop = false;
            buttonEqual.TabStop = false;
            buttonDot.TabStop = false;
            buttonSign.TabStop = false;
            buttonC.TabStop = false;
            buttonCE.TabStop = false;
            buttonDel.TabStop = false;

            txtInput.Text = "";
            txtOutput.Text = "0";
            this.ActiveControl = null;
        }

        private void InputNumber(string number)
        {
            if (txtOutput.Text == "0" || isNewNumber)
            {
                txtOutput.Text = number;
                isNewNumber = false;
            }
            else
            {
                txtOutput.Text += number;
            }

            UpdateInputExpression();
            this.ActiveControl = null;
        }

        private void InputDot()
        {
            if (isNewNumber)
            {
                txtOutput.Text = "0.";
                isNewNumber = false;
            }
            else if (!txtOutput.Text.Contains("."))
            {
                txtOutput.Text += ".";
            }

            UpdateInputExpression();
            this.ActiveControl = null;
        }

        private void UpdateInputExpression()
        {
            if (currentOperator != "")
            {
                txtInput.Text = firstNumber.ToString() + " " + currentOperator + " " + txtOutput.Text;
            }
            else
            {
                txtInput.Text = txtOutput.Text;
            }
        }

        private void SetOperator(string op)
        {
            if (txtOutput.Text == "")
                return;

            firstNumber = double.Parse(txtOutput.Text);
            currentOperator = op;
            isNewNumber = true;
            txtInput.Text = firstNumber.ToString() + " " + currentOperator;
            this.ActiveControl = null;
        }

        private void Calculate()
        {
            if (currentOperator == "" || txtOutput.Text == "")
                return;

            double secondNumber = double.Parse(txtOutput.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "x":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                        this.ActiveControl = null;
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
            }

            txtInput.Text = firstNumber.ToString() + " " + currentOperator + " " + secondNumber.ToString() + " = " + result.ToString();
            txtOutput.Text = result.ToString();
            firstNumber = result;
            currentOperator = "";
            isNewNumber = true;
            this.ActiveControl = null;
        }

        private void ClearAll()
        {
            txtInput.Text = "";
            txtOutput.Text = "0";
            firstNumber = 0;
            currentOperator = "";
            isNewNumber = true;
            this.ActiveControl = null;
        }

        private void ClearEntry()
        {
            txtOutput.Text = "0";
            isNewNumber = true;

            if (currentOperator != "")
                txtInput.Text = firstNumber.ToString() + " " + currentOperator;
            else
                txtInput.Text = "";

            this.ActiveControl = null;
        }

        private void DeleteOne()
        {
            if (!isNewNumber && txtOutput.Text.Length > 0)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);

                if (txtOutput.Text == "" || txtOutput.Text == "-")
                {
                    txtOutput.Text = "0";
                    isNewNumber = true;
                }

                UpdateInputExpression();
            }

            this.ActiveControl = null;
        }

        private void ChangeSign()
        {
            if (txtOutput.Text != "0" && txtOutput.Text != "")
            {
                if (txtOutput.Text.StartsWith("-"))
                    txtOutput.Text = txtOutput.Text.Substring(1);
                else
                    txtOutput.Text = "-" + txtOutput.Text;

                UpdateInputExpression();
            }

            this.ActiveControl = null;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            InputNumber("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputNumber("2");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            InputNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InputNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InputNumber("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InputNumber("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InputNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputNumber("9");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SetOperator("+");
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            SetOperator("-");
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            SetOperator("*");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            SetOperator("/");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            InputDot();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            ChangeSign();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DeleteOne();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                InputNumber((e.KeyCode - Keys.D0).ToString());
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                InputNumber((e.KeyCode - Keys.NumPad0).ToString());
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Add || (e.KeyCode == Keys.Oemplus && e.Shift))
            {
                SetOperator("+");
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                SetOperator("-");
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Multiply || (e.KeyCode == Keys.D8 && e.Shift))
            {
                SetOperator("x");
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
            {
                SetOperator("/");
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                InputDot();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                Calculate();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Back)
            {
                DeleteOne();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                ClearAll();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.E)
            {
                ClearEntry();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.N)
            {
                ChangeSign();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void buttonDiv_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void buttonMul_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void buttonSub_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void buttonAdd_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void buttonEqual_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button8_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button9_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}