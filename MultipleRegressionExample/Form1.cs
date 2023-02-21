using System;
using System.Windows.Forms;
using Accord.Statistics.Models.Regression.Linear;

namespace Bobskie_Regression
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private (double[][], double[]) GetDatasets()
        {
            double[][] inputs = {
                new double[] {471.4, 8},
                new double[] {514.3, 20},
                new double[] {612.9, 22},
                new double[] {642.9, 24},
                new double[] {651.4, 30},
                new double[] {694.3, 36},
                new double[] {771.4, 36},
                new double[] {780, 38},
                new double[] {771.4, 36},
                new double[] {750, 38},
                new double[] {835.7, 50},
                new double[] {840, 54},
                new double[] {784.3 ,58},
                new double[] {814.3, 50},
                new double[] {642.9, 48},
            };
            double[] outputs = {
                360,
                720,
                1140,
                1500,
                1800,
                2160,
                2280,
                2580,
                2640,
                2940,
                3000,
                3120,
                3240,
                2160,
                2460

            };

            return (inputs, outputs);
        }

        private OrdinaryLeastSquares GetRegressionModel(bool useIntercept)
        {
            return new OrdinaryLeastSquares()
            {
                UseIntercept = useIntercept
            };
        }


        private void button1_Click(object sender, EventArgs e)
        {
            (double[][] inputs, double[] outputs) = GetDatasets();

            // Create an Ordinary Least Squares (OLS) object to fit the regression
            var ols = GetRegressionModel(useIntercept: true);

            // Learn the multiple regression model using the OLS algorithm
            var regression = ols.Learn(inputs, outputs);

            // Get the intercept and coefficients (weights) of the multiple regression model
            var intercept = regression.Intercept;
            var coefficients = regression.Weights;

            // Build the regression equation string
            string regressionEquation = "y' = " + intercept.ToString("N2");
            for (int i = 0; i < coefficients.Length; i++)
            {
                regressionEquation += $" + {coefficients[i]:N2} *x{i + 1}";
            }

            // Output the regression equation to the textbox
            regressionEquationOutput.Text = regressionEquation;

            // Print the intercept and coefficients to the console
            //textBox1.Text = string.Format("Intercept: {0}\r\nCoefficients: {1}",
            //                    intercept, string.Join(", ", coefficients));
            label6.Text = ""+intercept;
            label7.Text = ""+coefficients[0];
            label8.Text = "" + coefficients[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (double[][] inputs, double[] outputs) = GetDatasets();

            // Create an Ordinary Least Squares (OLS) object to fit the regression
            var ols = GetRegressionModel(useIntercept: true);

            // Learn the multiple regression model using the OLS algorithm
            var regression = ols.Learn(inputs, outputs);

            var intercept = regression.Intercept;
            var coefficients = regression.Weights;

            /// Read the values of x1 and x2 from the TextBox controls
            if (!double.TryParse(inputx1.Text, out double x1) || !double.TryParse(inputx2.Text, out double x2))
            {
                MessageBox.Show("Invalid input values!");
                return;
            }

            // Calculate the value of y for the given values of x1 and x2
            double y = intercept + (coefficients[0] * x1) + (coefficients[1] * x2);

            // Display the result of the regression in the Label control
            reslabel.Text = "y = " + y.ToString("N2");

        }
    }
}
