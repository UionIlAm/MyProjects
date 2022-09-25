using System;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace project_08
{

    public partial class MainWindow : Window
    {
        private string resultMath = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x1 = Convert.ToInt32(λ1.Text);
                int x2 = Convert.ToInt32(λ2.Text);
                int h1 = Convert.ToInt32(h.Text);
                result.Text += Tab(x1, x2, h1);    
            }
            catch (Exception)
            {
                string message = "Должны быть целочисленые числа";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                string caption = "Ошибка";
                result = System.Windows.Forms.MessageBox.Show(message, caption, buttons);
            }
        }
        public string Tab(int λ1, int λ2, int h)
        {
            double[] dataX = new double[] { };
            double[] dataY = new double[] { };
            Array.Resize(ref dataX, λ2);
            Array.Resize(ref dataY, λ2);
            
            for (int t = λ1; t < λ2 + 1; t++)
            {
                λ1 = +h;
                dataX[λ1] = λ1;
                double res = Math.Log10(t + Math.Abs((t * t) + 4)) - Math.Log10(t + Math.Sqrt((t * t) + 1));
                resultMath += ($"{t}" + " = " + res.ToString() + "\n");
                dataY[λ1] = res;
            }
            dataX = dataX.Where(a => a != 0).ToArray();
            dataY = dataY.Where(a => a != 0).ToArray();
            result_Graf.Plot.AddScatter(dataX, dataY);
            result_Graf.Plot.SaveFig("WpfGraf.png");
            result_Graf.Refresh();
            return resultMath;
        }
    }
}
