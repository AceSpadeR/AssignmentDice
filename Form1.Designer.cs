namespace AssignmentDice
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
            GameInfo = new GroupBox();
            LostText = new Label();
            WonText = new Label();
            TimeText = new Label();
            LostLabel = new Label();
            WonLabel = new Label();
            TimesLabel = new Label();
            guessLabel = new Label();
            guessInput = new TextBox();
            DisplayResults = new TextBox();
            RollButton = new Button();
            RestButton = new Button();
            DiceImages = new PictureBox();
            ErrorMessage = new Label();
            GameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiceImages).BeginInit();
            SuspendLayout();
            // 
            // GameInfo
            // 
            GameInfo.Controls.Add(LostText);
            GameInfo.Controls.Add(WonText);
            GameInfo.Controls.Add(TimeText);
            GameInfo.Controls.Add(LostLabel);
            GameInfo.Controls.Add(WonLabel);
            GameInfo.Controls.Add(TimesLabel);
            GameInfo.Location = new Point(43, 68);
            GameInfo.Margin = new Padding(3, 2, 3, 2);
            GameInfo.Name = "GameInfo";
            GameInfo.Padding = new Padding(3, 2, 3, 2);
            GameInfo.Size = new Size(308, 218);
            GameInfo.TabIndex = 0;
            GameInfo.TabStop = false;
            GameInfo.Text = "Game Info";
            // 
            // LostText
            // 
            LostText.AutoSize = true;
            LostText.Location = new Point(247, 158);
            LostText.Name = "LostText";
            LostText.Size = new Size(0, 15);
            LostText.TabIndex = 5;
            // 
            // WonText
            // 
            WonText.AutoSize = true;
            WonText.Location = new Point(247, 106);
            WonText.Name = "WonText";
            WonText.Size = new Size(0, 15);
            WonText.TabIndex = 4;
            // 
            // TimeText
            // 
            TimeText.AutoSize = true;
            TimeText.Location = new Point(247, 52);
            TimeText.Name = "TimeText";
            TimeText.Size = new Size(0, 15);
            TimeText.TabIndex = 3;
            // 
            // LostLabel
            // 
            LostLabel.AutoSize = true;
            LostLabel.Location = new Point(69, 158);
            LostLabel.Name = "LostLabel";
            LostLabel.Size = new Size(127, 15);
            LostLabel.TabIndex = 2;
            LostLabel.Text = "Number of Times Lost:";
            // 
            // WonLabel
            // 
            WonLabel.AutoSize = true;
            WonLabel.Location = new Point(69, 106);
            WonLabel.Name = "WonLabel";
            WonLabel.Size = new Size(130, 15);
            WonLabel.TabIndex = 1;
            WonLabel.Text = "Number of TImes Won:";
            // 
            // TimesLabel
            // 
            TimesLabel.AutoSize = true;
            TimesLabel.Location = new Point(69, 52);
            TimesLabel.Name = "TimesLabel";
            TimesLabel.Size = new Size(143, 15);
            TimesLabel.TabIndex = 0;
            TimesLabel.Text = "Number of Times Played: ";
            // 
            // guessLabel
            // 
            guessLabel.AutoSize = true;
            guessLabel.Location = new Point(43, 319);
            guessLabel.Name = "guessLabel";
            guessLabel.Size = new Size(125, 15);
            guessLabel.TabIndex = 2;
            guessLabel.Text = "Enter your guess (1-6):";
            // 
            // guessInput
            // 
            guessInput.Location = new Point(186, 319);
            guessInput.Margin = new Padding(3, 2, 3, 2);
            guessInput.Name = "guessInput";
            guessInput.Size = new Size(110, 23);
            guessInput.TabIndex = 3;
            // 
            // DisplayResults
            // 
            DisplayResults.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayResults.Location = new Point(43, 533);
            DisplayResults.Margin = new Padding(3, 2, 3, 2);
            DisplayResults.Multiline = true;
            DisplayResults.Name = "DisplayResults";
            DisplayResults.Size = new Size(415, 130);
            DisplayResults.TabIndex = 5;
            // 
            // RollButton
            // 
            RollButton.Location = new Point(269, 363);
            RollButton.Margin = new Padding(3, 2, 3, 2);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(82, 22);
            RollButton.TabIndex = 6;
            RollButton.Text = "Roll";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // RestButton
            // 
            RestButton.Location = new Point(269, 457);
            RestButton.Margin = new Padding(3, 2, 3, 2);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(82, 22);
            RestButton.TabIndex = 7;
            RestButton.Text = "Rest";
            RestButton.UseVisualStyleBackColor = true;
            // 
            // DiceImages
            // 
            DiceImages.Location = new Point(43, 363);
            DiceImages.Margin = new Padding(3, 2, 3, 2);
            DiceImages.Name = "DiceImages";
            DiceImages.Size = new Size(144, 116);
            DiceImages.SizeMode = PictureBoxSizeMode.StretchImage;
            DiceImages.TabIndex = 8;
            DiceImages.TabStop = false;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Location = new Point(185, 298);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 15);
            ErrorMessage.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 692);
            Controls.Add(ErrorMessage);
            Controls.Add(DiceImages);
            Controls.Add(RestButton);
            Controls.Add(RollButton);
            Controls.Add(DisplayResults);
            Controls.Add(guessInput);
            Controls.Add(guessLabel);
            Controls.Add(GameInfo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            GameInfo.ResumeLayout(false);
            GameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiceImages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GameInfo;
        private Label LostLabel;
        private Label WonLabel;
        private Label TimesLabel;
        private Label LostText;
        private Label WonText;
        private Label TimeText;
        private Label guessLabel;
        private TextBox guessInput;
        private TextBox DisplayResults;
        private Button RollButton;
        private Button RestButton;
        private PictureBox DiceImages;
        private Label ErrorMessage;
    }
}