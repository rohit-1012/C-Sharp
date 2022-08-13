namespace firstTestWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int val1, val2, valCalc;

        private void divideButton_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(num1Text.Text);
            val2 = Convert.ToInt32(num2Text.Text);
            functionText.Text = $"{val1} / {val2}";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(num1Text.Text);
            val2 = Convert.ToInt32(num2Text.Text);
            functionText.Text = $"{val1} x {val2}";
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(num1Text.Text);
            val2 = Convert.ToInt32(num2Text.Text);
            functionText.Text = $"{val1} % {val2}";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(num1Text.Text);
            val2 = Convert.ToInt32(num2Text.Text);
            functionText.Text = $"{val1} - {val2}";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (functionText.Text.Contains("+"))
            {
                valCalc = val1 + val2;
                solnText.Text = Convert.ToString(valCalc);
            }
            if (functionText.Text.Contains("-"))
            {
                valCalc = val1 - val2;
                solnText.Text = Convert.ToString(valCalc);
            }
            if (functionText.Text.Contains("/"))
            {
                valCalc = val1 / val2;
                solnText.Text = Convert.ToString(valCalc);
            }
            if (functionText.Text.Contains("x"))
            {
                valCalc = val1 * val2;
                solnText.Text = Convert.ToString(valCalc);
            }
            if (functionText.Text.Contains("%"))
            {
                valCalc = val1 % val2;
                solnText.Text = Convert.ToString(valCalc);
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(num1Text.Text);
            val2 = Convert.ToInt32(num2Text.Text);
            functionText.Text = $"{val1} + {val2}";
        }
    }
}