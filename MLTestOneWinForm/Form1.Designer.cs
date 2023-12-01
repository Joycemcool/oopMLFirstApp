namespace MLTestOneWinForm
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
            Guess = new Button();
            txtReview = new TextBox();
            lblGuess = new Label();
            lblConfidence = new Label();
            btnTrain = new Button();
            SuspendLayout();
            // 
            // Guess
            // 
            Guess.Location = new Point(396, 301);
            Guess.Margin = new Padding(6);
            Guess.Name = "Guess";
            Guess.Size = new Size(139, 49);
            Guess.TabIndex = 0;
            Guess.Text = "Guess";
            Guess.UseVisualStyleBackColor = true;
            Guess.Click += Guess_Click;
            // 
            // txtReview
            // 
            txtReview.Location = new Point(405, 158);
            txtReview.Margin = new Padding(6);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(836, 39);
            txtReview.TabIndex = 1;
            // 
            // lblGuess
            // 
            lblGuess.BackColor = SystemColors.ControlLight;
            lblGuess.Location = new Point(836, 309);
            lblGuess.Margin = new Padding(6, 0, 6, 0);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(186, 49);
            lblGuess.TabIndex = 2;
            // 
            // lblConfidence
            // 
            lblConfidence.BackColor = SystemColors.ControlLight;
            lblConfidence.Location = new Point(836, 429);
            lblConfidence.Margin = new Padding(6, 0, 6, 0);
            lblConfidence.Name = "lblConfidence";
            lblConfidence.Size = new Size(186, 60);
            lblConfidence.TabIndex = 3;
            // 
            // btnTrain
            // 
            btnTrain.Location = new Point(413, 444);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(150, 46);
            btnTrain.TabIndex = 4;
            btnTrain.Text = "Train";
            btnTrain.UseVisualStyleBackColor = true;
            btnTrain.Click += btnTrain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(btnTrain);
            Controls.Add(lblConfidence);
            Controls.Add(lblGuess);
            Controls.Add(txtReview);
            Controls.Add(Guess);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Guess;
        private TextBox txtReview;
        private Label lblGuess;
        private Label lblConfidence;
        private Button btnTrain;
    }
}