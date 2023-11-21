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
            SuspendLayout();
            // 
            // Guess
            // 
            Guess.Location = new Point(213, 141);
            Guess.Name = "Guess";
            Guess.Size = new Size(75, 23);
            Guess.TabIndex = 0;
            Guess.Text = "Guess";
            Guess.UseVisualStyleBackColor = true;
            Guess.Click += Guess_Click;
            // 
            // txtReview
            // 
            txtReview.Location = new Point(218, 74);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(452, 23);
            txtReview.TabIndex = 1;
            // 
            // lblGuess
            // 
            lblGuess.BackColor = SystemColors.ControlLight;
            lblGuess.Location = new Point(450, 145);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(100, 23);
            lblGuess.TabIndex = 2;
            // 
            // lblConfidence
            // 
            lblConfidence.BackColor = SystemColors.ControlLight;
            lblConfidence.Location = new Point(450, 201);
            lblConfidence.Name = "lblConfidence";
            lblConfidence.Size = new Size(100, 28);
            lblConfidence.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblConfidence);
            Controls.Add(lblGuess);
            Controls.Add(txtReview);
            Controls.Add(Guess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Guess;
        private TextBox txtReview;
        private Label lblGuess;
        private Label lblConfidence;
    }
}