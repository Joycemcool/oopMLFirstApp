using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System.Windows.Forms;

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
                Col0 = txtReview.Text,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);

            lblGuess.Text = result.PredictedLabel.ToString();
            lblConfidence.Text = (result.Score[0] * 100).ToString();

            //Take user feedback and save into txt file
            // Take user feedback and save into txt file (append to yelp.labelled.txt)
            string feedback = $"{txtReview.Text}\t{result.PredictedLabel}";
            File.AppendAllText("yelp.labelled.txt", feedback + Environment.NewLine);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            //Create MLContext
            MLContext mlContext = new MLContext();

            //Load Data
            IDataView newData = mlContext.Data.LoadFromTextFile<Feedback>("yelp_labelled.txt", separatorChar: '\t', hasHeader: false);


            // Define Data Preparation Pipeline
            var dataPrepPipeline = mlContext.Transforms.Conversion.MapValueToKey("Label", "Sentiment")
                .Append(mlContext.Transforms.Text.FeaturizeText("Features", "Text"))
                .Append(mlContext.Transforms.CopyColumns("Features", "Features"))
                .Append(mlContext.Transforms.NormalizeMinMax("Features"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("Label"));

            // Preprocess Data
            IDataView transformedNewData = dataPrepPipeline.Fit(newData).Transform(newData);

            //Load trained model
            ITransformer trainedModel = mlContext.Model.Load("MLModel1.zip", out DataViewSchema modelSchema);

            //Extract trained model parameters 
            LinearRegressionModelParameters originalModelParameters =
            ((ISingleFeaturePredictionTransformer<object>)trainedModel).Model as LinearRegressionModelParameters;

            // Retrain model
            RegressionPredictionTransformer<LinearRegressionModelParameters> retrainedModel =
                mlContext.Regression.Trainers.OnlineGradientDescent()
                    .Fit(transformedNewData, originalModelParameters);

            // Extract Model Parameters of re-trained model
            LinearRegressionModelParameters retrainedModelParameters = retrainedModel.Model as LinearRegressionModelParameters;

            // Inspect Change in Weights
            var weightDiffs =
                originalModelParameters.Weights.Zip(
                    retrainedModelParameters.Weights, (original, retrained) => original - retrained).ToArray();

            Console.WriteLine("Original | Retrained | Difference");
            for (int i = 0; i < weightDiffs.Count(); i++)
            {
                Console.WriteLine($"{originalModelParameters.Weights[i]} | {retrainedModelParameters.Weights[i]} | {weightDiffs[i]}");
            }
        }

    }

    public class Feedback
    {
        [LoadColumn(0)]
        public string Comment { get; set; }

        [LoadColumn(2)]
        [ColumnName("Label")]
        public int CurrentPrice { get; set; }
    }
}