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
                new double[] {2.75, 5.3},
                new double[] {2.5, 5.3},
                new double[] {2.5, 5.3},
                new double[] {2.5, 5.3},
                new double[] {2.5, 5.4},
                new double[] {2.5, 5.6},
                new double[] {2.5, 5.5},
                new double[] {2.25, 5.5},
                new double[] {2.25, 5.5},
                new double[] {2.25, 5.6},
                new double[] {2, 5.7},
                new double[] {2, 5.9},
                new double[] {2, 6},
                new double[] {1.75, 5.9},
                new double[] {1.75, 5.8},
                new double[] {1.75, 6.1},
                new double[] {1.75, 6.2},
                new double[] {1.75, 6.1},
                new double[] {1.75, 6.1},
                new double[] {1.75, 6.1},
                new double[] {1.75, 5.9},
                new double[] {1.75, 6.2},
                new double[] {1.75, 6.2},
                new double[] {1.75, 6.1},
            };
            double[] outputs = {
                 1464,
                 1394,
                 1357,
                 1293,
                 1256,
                 1254,
                 1234,
                 1195,
                 1159,
                 1167,
                 1130,
                 1075,
                 1047,
                 965,
                 943,
                 958,
                 971,
                 949,
                 884,
                 866,
                 876,
                 822,
                 704,
                 719
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
            textBox1.Text = string.Format("Intercept: {0}\r\nCoefficients: {1}",
                                intercept, string.Join(",", coefficients));
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
            regressionOutput.Text = "y = " + y.ToString("N2");

        }
    }
}
