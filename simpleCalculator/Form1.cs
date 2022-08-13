namespace simpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double var1, var2, varcalc;
        string? oprtr;

        private void oneButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "9";
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if(equatnTextBox.Text.Length > 0)
            {
                equatnTextBox.Text = equatnTextBox.Text.Remove(equatnTextBox.Text.Length - 1, 1);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Clear();
            if(decimalButton.Enabled == false)
            {
                decimalButton.Enabled = true;
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(equatnTextBox.Text);
            equatnTextBox.Clear();
            oprtr = "1";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(equatnTextBox.Text);
            equatnTextBox.Clear();
            oprtr = "2";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(equatnTextBox.Text);
            equatnTextBox.Clear();
            oprtr = "3";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(equatnTextBox.Text);
            equatnTextBox.Clear();
            oprtr = "4";
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(equatnTextBox.Text);
            equatnTextBox.Clear();
            oprtr = "5";
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(equatnTextBox.Text);
            var1 = Math.Sqrt(var1);
            equatnTextBox.Text = Convert.ToString(var1);
        }

        private void raisedToYButton_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(equatnTextBox.Text);
            equatnTextBox.Clear();
            oprtr = "6";
        }

        private void squaredButton_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(equatnTextBox.Text);
            var1 = var1 * var1;
            equatnTextBox.Text = Convert.ToString(var1);
        }

        private void onebyButton_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(equatnTextBox.Text);
            var1 = 1/var1;
            equatnTextBox.Text = Convert.ToString(var1);
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            var2 = Convert.ToDouble(equatnTextBox.Text);
            switch(Convert.ToInt16(oprtr))
            {
                case 1:
                    varcalc = var1 + var2;
                    equatnTextBox.Text = Convert.ToString(varcalc);
                    break;
                case 2:
                    varcalc = var1 - var2;
                    equatnTextBox.Text = Convert.ToString(varcalc);
                    break;
                case 3:
                    varcalc = var1 / var2;
                    equatnTextBox.Text = Convert.ToString(varcalc);
                    break;
                case 4:
                    varcalc = var1 * var2;
                    equatnTextBox.Text = Convert.ToString(varcalc);
                    break;
                case 5:
                    varcalc = var1 % var2;
                    equatnTextBox.Text = Convert.ToString(varcalc);
                    break;
                case 6:
                    varcalc = Math.Pow(var1 , var2);
                    equatnTextBox.Text = Convert.ToString(varcalc);
                    break;
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            equatnTextBox.Text = equatnTextBox.Text + "0";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if(equatnTextBox.Text.Contains("."))
            {
                decimalButton.Enabled = false;
                MessageBox.Show("A number cannot have more than one decimal point");
            }
            else
            {
                equatnTextBox.Text = equatnTextBox.Text + ".";
            }
        }
    }
}