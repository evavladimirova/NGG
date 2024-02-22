namespace NGG
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
            label1 = new Label();
            level1RadioButton = new RadioButton();
            level2RadioButton = new RadioButton();
            level3RadioButton = new RadioButton();
            label2 = new Label();
            guessTextBox = new TextBox();
            SubmitButton = new Button();
            resultLabel = new Label();
            triesLabel = new Label();
            NewGameButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 30);
            label1.Name = "label1";
            label1.Size = new Size(461, 44);
            label1.TabIndex = 0;
            label1.Text = "Number Guessing Game";
            // 
            // level1RadioButton
            // 
            level1RadioButton.AutoSize = true;
            level1RadioButton.Location = new Point(63, 116);
            level1RadioButton.Name = "level1RadioButton";
            level1RadioButton.Size = new Size(154, 29);
            level1RadioButton.TabIndex = 1;
            level1RadioButton.TabStop = true;
            level1RadioButton.Text = "Level 1 (8 tries)";
            level1RadioButton.UseVisualStyleBackColor = true;
            level1RadioButton.CheckedChanged += level1RadioButton_CheckedChanged;
            // 
            // level2RadioButton
            // 
            level2RadioButton.AutoSize = true;
            level2RadioButton.Location = new Point(312, 116);
            level2RadioButton.Name = "level2RadioButton";
            level2RadioButton.Size = new Size(154, 29);
            level2RadioButton.TabIndex = 2;
            level2RadioButton.TabStop = true;
            level2RadioButton.Text = "Level 2 (5 tries)";
            level2RadioButton.UseVisualStyleBackColor = true;
            level2RadioButton.CheckedChanged += level2RadioButton_CheckedChanged;
            // 
            // level3RadioButton
            // 
            level3RadioButton.AutoSize = true;
            level3RadioButton.Location = new Point(578, 116);
            level3RadioButton.Name = "level3RadioButton";
            level3RadioButton.Size = new Size(154, 29);
            level3RadioButton.TabIndex = 3;
            level3RadioButton.TabStop = true;
            level3RadioButton.Text = "Level 3 (3 tries)";
            level3RadioButton.UseVisualStyleBackColor = true;
            level3RadioButton.CheckedChanged += level3RadioButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 192);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 4;
            label2.Text = "Make a guess:";
            // 
            // guessTextBox
            // 
            guessTextBox.Location = new Point(225, 192);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(150, 31);
            guessTextBox.TabIndex = 5;
            guessTextBox.TextChanged += guessTextBox_TextChanged;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(440, 190);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 34);
            SubmitButton.TabIndex = 6;
            SubmitButton.Text = "Guess!";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(63, 335);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(84, 32);
            resultLabel.TabIndex = 7;
            resultLabel.Text = "Result";
            resultLabel.Click += resultLabel_Click;
            // 
            // triesLabel
            // 
            triesLabel.AutoSize = true;
            triesLabel.Location = new Point(63, 268);
            triesLabel.Name = "triesLabel";
            triesLabel.Size = new Size(80, 25);
            triesLabel.TabIndex = 8;
            triesLabel.Text = "Tries Left";
            triesLabel.Click += triesLabel_Click;
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new Point(548, 393);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(223, 34);
            NewGameButton.TabIndex = 9;
            NewGameButton.Text = "Start Game!";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NewGameButton);
            Controls.Add(triesLabel);
            Controls.Add(resultLabel);
            Controls.Add(SubmitButton);
            Controls.Add(guessTextBox);
            Controls.Add(label2);
            Controls.Add(level3RadioButton);
            Controls.Add(level2RadioButton);
            Controls.Add(level1RadioButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton level1RadioButton;
        private RadioButton level2RadioButton;
        private RadioButton level3RadioButton;
        private Label label2;
        private TextBox guessTextBox;
        private Button SubmitButton;
        private Label resultLabel;
        private Label triesLabel;
        private Button NewGameButton;
    }
}
