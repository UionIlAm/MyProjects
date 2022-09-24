using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project_06
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double average = 0;
        double x = 0;
        public static double[] mass = new double[120];
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumbersRasult()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                int e = rand.Next(1, 120);
                mass[i] = ((1 / (4 * Math.Sqrt(2 * Math.PI)))
                    * Math.Pow(e, -Math.Pow(x - 3, 2) / 2 * (4 * 4)));

            }
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            xValue.Text = x.ToString();
            NumbersRasult();
            mass = mass.OrderBy(x => x).ToArray();
            for (int i = 0; i < mass.Length; i++)
            {
                numbers.Text += (mass[i].ToString() + " \n");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewNumbers(mass);
            numbers.Text = string.Empty;
            mass = mass.Where(a => a != 0).ToArray();
            for (int i = 0; i < mass.Length; i++)
            {
                numbers.Text += ($"{i + 1}) " + mass[i].ToString() + " \n");
            }
            average = mass.Where(x => x < 0).Average();
            averageValue.Text = average.ToString();
            variance.Text = Disp(mass).ToString();
            Hist(mass);
        }
        private void Hist(double[] mass)
        {
            double[] values = ScottPlot.DataGen.RandomNormal(rand, pointCount: 80, mean: 10, stdDev: 10);
            (double[] counts, double[] binEdges) =ScottPlot.Statistics.Common.Histogram(values, min: 10, max: 80, binSize: 1);
            double[] leftEdges = binEdges.Take(binEdges.Length - 1).ToArray();
            var bar = Histogram.Plot.AddBar(values: counts, positions: leftEdges);
            bar.BarWidth = 1;
            Histogram.Plot.SetAxisLimits(yMin: 0);

            Histogram.Plot.SaveFig("stats_histogram.png");
            Histogram.Refresh(_contentLoaded);
        }
        private double Disp(double[] mass)
        {
            double disp = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] -= average;
                mass[i] = Math.Pow(mass[i], 2);

                int j = i + 1;
                if (j < mass.Length)
                {
                    mass[i] += mass[i + 1];
                }
                disp = mass[i] / mass.Length;
            }
            return disp;

        }
        private double[] NewNumbers(double[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                int j = i + 1;
                if (j < mass.Length)
                {
                    mass[i] -= mass[i + 1];
                }
            }
            return mass;
        }
    }
}
