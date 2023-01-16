using System;
using System.Globalization;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class SimpleCalculator : Form
    {

        string operationToExecute;
        decimal value1 = 0;
        decimal value2 = 0;
        decimal result = 0;

        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxSymbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "9";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
            {
                textBoxResult.Text += "0";
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Contains("."))
            {
                textBoxResult.Text += ".";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBoxSymbol.Text != "")
            {
                textBoxSymbol.Text = "-";
                operationToExecute = "-";
                value1 = decimal.Parse(textBoxSymbol.Text, CultureInfo.InvariantCulture);
                textBoxSymbol.Text = "";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "")
            {
                textBoxSymbol.Text = "+";
                operationToExecute = "+";
                value1 = decimal.Parse(textBoxResult.Text, CultureInfo.InvariantCulture);
                textBoxResult.Text = "";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "")
            {
                textBoxSymbol.Text = "x";
                operationToExecute = "*";
                value1 = decimal.Parse(textBoxResult.Text, CultureInfo.InvariantCulture);
                textBoxResult.Text = "";
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "")
            {
                textBoxSymbol.Text = "/";
                operationToExecute = "/";
                value1 = decimal.Parse(textBoxResult.Text, CultureInfo.InvariantCulture);
                textBoxResult.Text = "";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "")
            {
                value2 = decimal.Parse(textBoxResult.Text, CultureInfo.InvariantCulture);
                calculateResult(operationToExecute);
                textBoxResult.Text = result.ToString();
                value1 = result;

            }
        }

        private void calculateResult(string operationToExecute)
        {
            switch (operationToExecute)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    try
                    {
                        result = value1 * value2;
                    }
                    catch (OverflowException)
                    {
                        // problem not solved yet!
                    }
                    break;
                case "/":
                    try
                    {
                        result = value1 / value2;
                    }
                    catch (Exception ex) { ex.GetBaseException(); }
                    break;

            }
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "")
            {
                decimal negativeMultiply = decimal.Parse(textBoxResult.Text, CultureInfo.InvariantCulture) * (-1);
                textBoxResult.Text = Convert.ToString(negativeMultiply);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.value1 = 0;
            this.value2 = 0;
            textBoxResult.Text = "";
            textBoxSymbol.Text = "";
        }

        private void buttonClearElement_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            textBoxSymbol.Text = "";
        }
    }
}
