namespace dbConnectivityTest1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.submitButton = new System.Windows.Forms.Button();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ageLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.enterNametextBox = new System.Windows.Forms.TextBox();
            this.dataDispTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.submitButton);
            this.splitContainer1.Panel1.Controls.Add(this.dobDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.ageLabel);
            this.splitContainer1.Panel1.Controls.Add(this.dobLabel);
            this.splitContainer1.Panel1.Controls.Add(this.emailTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.emailLabel);
            this.splitContainer1.Panel1.Controls.Add(this.ageTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.contactTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.contactNoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.fullNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.fullNameLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.enterNametextBox);
            this.splitContainer1.Panel2.Controls.Add(this.dataDispTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(699, 269);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(12, 209);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(291, 45);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobDateTimePicker.Location = new System.Drawing.Point(93, 117);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(210, 23);
            this.dobDateTimePicker.TabIndex = 2;
            this.dobDateTimePicker.Value = new System.DateTime(2022, 9, 4, 22, 42, 3, 0);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLabel.Location = new System.Drawing.Point(49, 87);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(38, 15);
            this.ageLabel.TabIndex = 0;
            this.ageLabel.Text = "Age: ";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dobLabel.Location = new System.Drawing.Point(8, 123);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(88, 15);
            this.dobLabel.TabIndex = 0;
            this.dobLabel.Text = "Date of Birth: ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTextBox.Location = new System.Drawing.Point(67, 156);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(236, 23);
            this.emailTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(12, 159);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 15);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E-mail: ";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageTextBox.Location = new System.Drawing.Point(93, 84);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(210, 23);
            this.ageTextBox.TabIndex = 1;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactTextBox.Location = new System.Drawing.Point(93, 48);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(210, 23);
            this.contactTextBox.TabIndex = 1;
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.AutoSize = true;
            this.contactNoLabel.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNoLabel.Location = new System.Drawing.Point(12, 51);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(84, 15);
            this.contactNoLabel.TabIndex = 0;
            this.contactNoLabel.Text = "Contact No.: ";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameTextBox.Location = new System.Drawing.Point(67, 15);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(236, 23);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.Location = new System.Drawing.Point(12, 18);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(49, 15);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Name: ";
            // 
            // enterNametextBox
            // 
            this.enterNametextBox.Location = new System.Drawing.Point(12, 18);
            this.enterNametextBox.Name = "enterNametextBox";
            this.enterNametextBox.Size = new System.Drawing.Size(362, 23);
            this.enterNametextBox.TabIndex = 2;
            this.enterNametextBox.Text = "Enter a Name";
            this.enterNametextBox.Click += new System.EventHandler(this.enterNametextBox_Click);
            this.enterNametextBox.TextChanged += new System.EventHandler(this.enterNametextBox_TextChanged);
            // 
            // dataDispTextBox
            // 
            this.dataDispTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dataDispTextBox.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataDispTextBox.Location = new System.Drawing.Point(12, 51);
            this.dataDispTextBox.Multiline = true;
            this.dataDispTextBox.Name = "dataDispTextBox";
            this.dataDispTextBox.Size = new System.Drawing.Size(362, 206);
            this.dataDispTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 269);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox fullNameTextBox;
        private Label fullNameLabel;
        private Button submitButton;
        private DateTimePicker dobDateTimePicker;
        private Label ageLabel;
        private Label dobLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox ageTextBox;
        private TextBox contactTextBox;
        private Label contactNoLabel;
        private TextBox dataDispTextBox;
        private TextBox enterNametextBox;
    }
}