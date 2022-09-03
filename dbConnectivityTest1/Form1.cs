namespace dbConnectivityTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SQLConn sqlDB = new SQLConn();

        private void enterNametextBox_Click(object sender, EventArgs e)
        {
            enterNametextBox.Clear();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            while(fullNameTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Please enter your Full Name!", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            while(contactTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Please enter your Contact Number!", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            while(ageTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Please enter your Age!", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            while(emailTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Please enter your E-mail!", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            System.Text.RegularExpressions.Regex emailRegex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");
            while(!emailRegex.IsMatch(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid E-mail!", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            InsVal();
        }

        public void InsVal()
        {
            
        }
    }
}