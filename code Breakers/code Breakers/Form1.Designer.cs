namespace code_Breakers
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
            inputTextBox = new TextBox();
            button2 = new Button();
            outputTextBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = Color.Ivory;
            inputTextBox.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            inputTextBox.Location = new Point(35, 128);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(242, 35);
            inputTextBox.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1, 2);
            button2.Name = "button2";
            button2.Size = new Size(190, 40);
            button2.TabIndex = 2;
            button2.Text = "Encrypt";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // outputTextBox
            // 
            outputTextBox.BackColor = SystemColors.InactiveBorder;
            outputTextBox.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            outputTextBox.Location = new Point(35, 183);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(242, 35);
            outputTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button2);
            panel1.Location = new Point(57, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 44);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(57, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 44);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1, 2);
            button1.Name = "button1";
            button1.Size = new Size(190, 40);
            button1.TabIndex = 2;
            button1.Text = "Decpryt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Pink;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 29);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 6;
            label1.Text = "Code Breakers";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Location = new Point(297, -1);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 7;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(326, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Button button1;
        private Button button2;
        private TextBox outputTextBox;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Label label1;
    }
}