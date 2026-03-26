using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.ReadOnly = true;    // 식 표시창
            txtOutput.ReadOnly = true;   // 결과 표시창

            txtInput.Text = "";
            txtOutput.Text = "0";
        }

        // 공통 숫자 입력 처리
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

            // 연산자가 이미 눌린 상태면: 식 + 두 번째 숫자 표시
            if (currentOperator != "")
            {
                txtInput.Text = firstNumber.ToString() + " " + currentOperator + " " + txtOutput.Text;
            }
            else
            {
                // 첫 번째 숫자 입력 중이면 입력창에도 그대로 표시
                txtInput.Text = txtOutput.Text;
            }
        }

        // 공통 연산자 처리
        private void SetOperator(string op)
        {
            if (txtOutput.Text == "")
                return;

            firstNumber = double.Parse(txtOutput.Text);
            currentOperator = op;

            txtInput.Text = firstNumber.ToString() + " " + currentOperator;
            txtOutput.Text = "0";
            isNewNumber = true;
        }

        // 공통 계산 처리
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
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
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
        }

        // 3 버튼
        private void button15_Click(object sender, EventArgs e)
        {
            InputNumber("3");
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "0" && txtOutput.Text != "")
            {
                if (txtOutput.Text.StartsWith("-"))
                    txtOutput.Text = txtOutput.Text.Substring(1);
                else
                    txtOutput.Text = "-" + txtOutput.Text;

                if (currentOperator != "")
                    txtInput.Text = firstNumber.ToString() + " " + currentOperator + " " + txtOutput.Text;
                else
                    txtInput.Text = txtOutput.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            InputNumber("0");
        }

        private void buttonDot_Click(object sender, EventArgs e)
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

            if (currentOperator != "")
                txtInput.Text = firstNumber.ToString() + " " + currentOperator + " " + txtOutput.Text;
            else
                txtInput.Text = txtOutput.Text;
        }

        // = 버튼
        private void button20_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputNumber("2");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SetOperator("+");
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

        private void buttonSub_Click(object sender, EventArgs e)
        {
            SetOperator("-");
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

        private void buttonMul_Click(object sender, EventArgs e)
        {
            SetOperator("*");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "0";
            firstNumber = 0;
            currentOperator = "";
            isNewNumber = true;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            isNewNumber = true;

            if (currentOperator != "")
                txtInput.Text = firstNumber.ToString() + " " + currentOperator;
            else
                txtInput.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (!isNewNumber && txtOutput.Text.Length > 0)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);

                if (txtOutput.Text == "" || txtOutput.Text == "-")
                {
                    txtOutput.Text = "0";
                    isNewNumber = true;
                }

                if (currentOperator != "")
                    txtInput.Text = firstNumber.ToString() + " " + currentOperator + " " + txtOutput.Text;
                else
                    txtInput.Text = txtOutput.Text;
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            SetOperator("/");
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}