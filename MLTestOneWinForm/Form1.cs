namespace MLTestOneWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Col0 =txtReview.Text,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);

            lblGuess.Text = result.PredictedLabel.ToString();
            lblConfidence.Text = (result.Score[0]*100).ToString();

        }
    }
}