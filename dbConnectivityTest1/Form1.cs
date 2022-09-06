

namespace dbConnectivityTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SQLConn sqlDB = new SQLConn();

        private void enterNametextBox_Click(object sender, EventArgs e)
        {
            enterNametextBox.Clear();
        }

        

        private void submitButton_Click(object sender, EventArgs e)
        {
            InsVal();
            while (fullNameTextBox.Text.Length <= 0)
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
            MessageBox.Show(dobDateTimePicker.Text);
            MessageBox.Show(Convert.ToString(sqlDB.recordCount));
            MessageBox.Show(sqlDB.excptnShow);
        }

        public void InsVal()
        {
            sqlDB.AddParams("@fullNameValue", fullNameTextBox.Text);
            sqlDB.AddParams("@contactNumberValue", contactTextBox.Text);
            sqlDB.AddParams("@ageValue", ageTextBox.Text);
            sqlDB.AddParams("@birthDateValue", dobDateTimePicker.Text);
            sqlDB.AddParams("@emailValue", emailTextBox.Text);
            sqlDB.sqlQueryCmd("INSERT INTO userDataTest(user_Name,user_Number,user_Age,user_Email,user_DOB) VALUES (@fullNameValue,@contactNumberValue,@ageValue,@emailValue,@birthDateValue);");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dobDateTimePicker.Format = DateTimePickerFormat.Custom;
            dobDateTimePicker.CustomFormat = "yyyy-MM-dd";
        }
    }
}