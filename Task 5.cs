namespace FactorialApp
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
            lblNumber = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            textBoxNumber = new TextBox();
            lblFactorial = new Label();
            textBoxFactorial = new TextBox();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(89, 93);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(63, 20);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Number";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(89, 276);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(243, 276);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(212, 90);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(125, 27);
            textBoxNumber.TabIndex = 3;
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Location = new Point(89, 161);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(65, 20);
            lblFactorial.TabIndex = 4;
            lblFactorial.Text = "Factorial";
            // 
            // textBoxFactorial
            // 
            textBoxFactorial.Location = new Point(212, 161);
            textBoxFactorial.Name = "textBoxFactorial";
            textBoxFactorial.Size = new Size(125, 27);
            textBoxFactorial.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxFactorial);
            Controls.Add(lblFactorial);
            Controls.Add(textBoxNumber);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber;
        private Button btnCalculate;
        private Button btnExit;
        private TextBox textBoxNumber;
        private Label lblFactorial;
        private TextBox textBoxFactorial;
    }
}
