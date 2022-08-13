namespace firstTestWFA
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
            this.num1Text = new System.Windows.Forms.TextBox();
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.num2Text = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.modButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.solnText = new System.Windows.Forms.TextBox();
            this.functionText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // num1Text
            // 
            this.num1Text.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1Text.Location = new System.Drawing.Point(180, 15);
            this.num1Text.Name = "num1Text";
            this.num1Text.Size = new System.Drawing.Size(197, 30);
            this.num1Text.TabIndex = 0;
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1Label.Location = new System.Drawing.Point(23, 15);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(151, 22);
            this.num1Label.TabIndex = 1;
            this.num1Label.Text = "Enter Number 1:";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2Label.Location = new System.Drawing.Point(23, 51);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(151, 22);
            this.num2Label.TabIndex = 1;
            this.num2Label.Text = "Enter Number 2:";
            // 
            // num2Text
            // 
            this.num2Text.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2Text.Location = new System.Drawing.Point(180, 51);
            this.num2Text.Name = "num2Text";
            this.num2Text.Size = new System.Drawing.Size(197, 30);
            this.num2Text.TabIndex = 0;
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusButton.Location = new System.Drawing.Point(43, 100);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(58, 38);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divideButton.Location = new System.Drawing.Point(171, 100);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(58, 38);
            this.divideButton.TabIndex = 2;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // modButton
            // 
            this.modButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modButton.Location = new System.Drawing.Point(299, 100);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(58, 38);
            this.modButton.TabIndex = 2;
            this.modButton.Text = "%";
            this.modButton.UseVisualStyleBackColor = true;
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusButton.Location = new System.Drawing.Point(107, 100);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(58, 38);
            this.minusButton.TabIndex = 2;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplyButton.Location = new System.Drawing.Point(235, 100);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(58, 38);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(18, 206);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 44);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // solnText
            // 
            this.solnText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solnText.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solnText.Location = new System.Drawing.Point(157, 206);
            this.solnText.Multiline = true;
            this.solnText.Name = "solnText";
            this.solnText.Size = new System.Drawing.Size(226, 44);
            this.solnText.TabIndex = 4;
            // 
            // functionText
            // 
            this.functionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.functionText.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.functionText.Location = new System.Drawing.Point(87, 149);
            this.functionText.Multiline = true;
            this.functionText.Name = "functionText";
            this.functionText.Size = new System.Drawing.Size(226, 44);
            this.functionText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 284);
            this.Controls.Add(this.functionText);
            this.Controls.Add(this.solnText);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.Controls.Add(this.num2Text);
            this.Controls.Add(this.num1Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox num1Text;
        private Label num1Label;
        private Label num2Label;
        private TextBox num2Text;
        private Button plusButton;
        private Button divideButton;
        private Button modButton;
        private Button minusButton;
        private Button multiplyButton;
        private Button calculateButton;
        private TextBox solnText;
        private TextBox functionText;
    }
}