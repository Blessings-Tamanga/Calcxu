
namespace Calcxu
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private string operation = "";
        private bool isNewNumber = true;
        private string expression = "";

        public Form1()
        {
            InitializeComponent();
        }

        // NUMBER BUTTONS: 0-9
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewNumber || txtBoxScreen.Text == "0")
            {
                txtBoxScreen.Text = btn.Text;
                isNewNumber = false;
            }
            else
            {
                txtBoxScreen.Text += btn.Text;
            }

            UpdateExpression();
        }

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxScreen.Text = "0";
            txtSumdesc.Text = "";

            firstNumber = 0;
            operation = "";
            expression = "";
            isNewNumber = true;
        }

        // ARITHMETIC OPERATORS
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!double.TryParse(txtBoxScreen.Text, out firstNumber))
                return;

            operation = btn.Name == "btnPower" ? "^" : btn.Text;
            expression = $"{firstNumber} {operation}";

            txtSumdesc.Text = expression;
            isNewNumber = true;
        }

        // EQUALS BUTTON
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operation == "")
                return;

            if (!double.TryParse(txtBoxScreen.Text, out double secondNumber))
                return;

            double result;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "−":
                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "×":
                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "÷":
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;

                case "^":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;

                default:
                    return;
            }

            if (double.IsNaN(result) || double.IsInfinity(result))
            {
                MessageBox.Show("The calculation produced an invalid result.");
                return;
            }

            txtSumdesc.Text =
                $"{firstNumber} {operation} {secondNumber} =";

            txtBoxScreen.Text = result.ToString("G15");

            firstNumber = result;
            operation = "";
            expression = "";
            isNewNumber = true;
        }

        // PI AND E CONSTANTS
        private void Constant_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            double value = btn.Name == "btnpi"
                ? Math.PI
                : Math.E;

            txtBoxScreen.Text = value.ToString("G15");
            isNewNumber = true;

            UpdateExpression();
        }

        // SCIENTIFIC FUNCTIONS
        private void Scientific_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!double.TryParse(txtBoxScreen.Text, out double x))
                return;

            double result;

            switch (btn.Name)
            {
                case "btnSqrt": // Square root
                    if (x < 0)
                    {
                        ShowError("Cannot calculate the square root of a negative number.");
                        return;
                    }

                    result = Math.Sqrt(x);
                    break;

                case "btnPower2": // Square
                    result = Math.Pow(x, 2);
                    break;

                case "button7": // Reciprocal
                    if (x == 0)
                    {
                        ShowError("Cannot divide by zero.");
                        return;
                    }

                    result = 1 / x;
                    break;

                case "button15": // Absolute value
                    result = Math.Abs(x);
                    break;

                case "btnLog": // Log base 10
                    if (x <= 0)
                    {
                        ShowError("Logarithm requires a number greater than zero.");
                        return;
                    }

                    result = Math.Log10(x);
                    break;

                case "button33": // Natural logarithm
                    if (x <= 0)
                    {
                        ShowError("Natural logarithm requires a number greater than zero.");
                        return;
                    }

                    result = Math.Log(x);
                    break;

                case "btn10BaseExponent": // 10^x
                    result = Math.Pow(10, x);
                    break;

                case "btnExp": // e^x
                    result = Math.Exp(x);
                    break;

                case "btnPercent": // Convert to decimal percentage
                    result = x / 100;
                    break;

                case "button10": // Factorial
                    if (x < 0 || x != Math.Truncate(x) || x > 170)
                    {
                        ShowError("Factorial requires a whole number from 0 to 170.");
                        return;
                    }

                    result = 1;

                    for (int i = 2; i <= (int)x; i++)
                    {
                        result *= i;
                    }

                    break;

                default:
                    return;
            }

            if (double.IsNaN(result) || double.IsInfinity(result))
            {
                ShowError("The calculation produced an invalid result.");
                return;
            }

            txtSumdesc.Text = $"{btn.Text}({x}) =";
            txtBoxScreen.Text = result.ToString("G15");

            firstNumber = result;
            operation = "";
            expression = "";
            isNewNumber = true;
        }

        // UPDATE THE SMALL EXPRESSION DISPLAY
        private void UpdateExpression()
        {
            if (operation != "")
            {
                txtSumdesc.Text =
                    $"{firstNumber} {operation} {txtBoxScreen.Text}";
            }
        }

        // DISPLAY AN ERROR MESSAGE
        private void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Calculator Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {

        }
    }
}
