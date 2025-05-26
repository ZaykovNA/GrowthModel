using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GrowthModelWinForms
{
    public partial class Form1 : Form
    {
        private double[] timeArray;
        private double[] valueArray;
        private int animationIndex = 0;
        private Timer animationTimer;
        private double[] xExact;

        public Form1()
        {
            InitializeComponent();
            comboBoxMethod.Items.Clear();
            comboBoxMethod.Items.AddRange(new[] { "Эйлер", "Рунге-Кутта 2", "Рунге-Кутта 4", "Аналитический" });
            comboBoxMethod.SelectedItem = "Аналитический";

            buttonCompute.Text = "Вычислить";
            buttonCompute.Click += buttonCompute_Click;

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Время (год)";
            chart1.ChartAreas[0].AxisY.Title = "Популяция (млрд)";
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ToolTip toolTip = new ToolTip
            {
                AutoPopDelay = 10000,
                InitialDelay = 500,
                ReshowDelay = 500,
                ShowAlways = true
            };

            toolTip.SetToolTip(textBoxR, "Коэффициент роста r (например, от 0.01 до 2.0)");
            toolTip.SetToolTip(textBoxK, "Предельная популяция K (> 0)");
            toolTip.SetToolTip(textBoxX0, "Начальное значение популяции x₀ (0 < x₀ < K)");
            toolTip.SetToolTip(textBoxt0, "Начальное время t₀ (например, 0)");
            toolTip.SetToolTip(textBoxT, "Конечное время T (T > t₀)");
            toolTip.SetToolTip(textBoxN, "Число шагов по времени N (целое число > 0)");
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxR.Text.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double r) ||
                !double.TryParse(textBoxK.Text.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double K) ||
                !double.TryParse(textBoxX0.Text.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double x0) ||
                !double.TryParse(textBoxt0.Text.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double t0) ||
                !double.TryParse(textBoxT.Text.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double T) ||
                !int.TryParse(textBoxN.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int N))
            {
                MessageBox.Show("Некорректные параметры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double h = (T - t0) / N;
            var t = new double[N + 1];
            for (int i = 0; i <= N; i++)
                t[i] = t0 + i * h;

            string method = comboBoxMethod.SelectedItem.ToString();

            Func<double, double, double> f = (xi, ti) => r * xi * (1 - xi / K);

            double[] x;
            switch (method)
            {
                case "Эйлер":
                    x = EulerMethod(f, x0, t, h);
                    break;
                case "Рунге-Кутта 2":
                    x = RK2Method(f, x0, t, h);
                    break;
                case "Рунге-Кутта 4":
                    x = RK4Method(f, x0, t, h);
                    break;
                case "Аналитический":
                default:
                    x = AnalyticalSolution(r, K, x0, t);
                    break;
            }

            xExact = AnalyticalSolution(r, K, x0, t);

            timeArray = t;
            valueArray = x;
            animationIndex = 0;

            chart1.Series.Clear();
            var series = new Series(method)
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            chart1.Series.Add(series);

            if (method != "Аналитический")
            {
                var exactSeries = new Series("Аналитический")
                {
                    ChartType = SeriesChartType.Line,
                    BorderDashStyle = ChartDashStyle.Dash,
                    Color = Color.Black
                };
                for (int i = 0; i < t.Length; i++)
                    exactSeries.Points.AddXY(t[i], xExact[i]);
                chart1.Series.Add(exactSeries);
            }

            chart1.ChartAreas[0].AxisX.Minimum = t0;
            chart1.ChartAreas[0].AxisX.Maximum = T;

            double minY = Math.Min(x0, K * 0.9); 
            double maxY = K * 1.05;              

            chart1.ChartAreas[0].AxisY.Minimum = minY;
            chart1.ChartAreas[0].AxisY.Maximum = maxY;


            animationTimer = new Timer();
            animationTimer.Interval = 40;
            animationTimer.Tick += AnimateChart;
            animationTimer.Start();
        }

        private void AnimateChart(object sender, EventArgs e)
        {
            if (animationIndex >= timeArray.Length)
            {
                animationTimer.Stop();
                return;
            }

            chart1.Series[0].Points.AddXY(timeArray[animationIndex], valueArray[animationIndex]);
            animationIndex++;
        }

        private double[] EulerMethod(Func<double, double, double> f, double x0, double[] t, double h)
        {
            int n = t.Length;
            var x = new double[n];
            x[0] = x0;
            for (int i = 1; i < n; i++)
                x[i] = x[i - 1] + h * f(x[i - 1], t[i - 1]);
            return x;
        }

        private double[] RK2Method(Func<double, double, double> f, double x0, double[] t, double h)
        {
            int n = t.Length;
            var x = new double[n];
            x[0] = x0;
            for (int i = 1; i < n; i++)
            {
                double k1 = f(x[i - 1], t[i - 1]);
                double k2 = f(x[i - 1] + h * k1, t[i - 1] + h);
                x[i] = x[i - 1] + h * (k1 + k2) / 2;
            }
            return x;
        }

        private double[] RK4Method(Func<double, double, double> f, double x0, double[] t, double h)
        {
            int n = t.Length;
            var x = new double[n];
            x[0] = x0;
            for (int i = 1; i < n; i++)
            {
                double k1 = f(x[i - 1], t[i - 1]);
                double k2 = f(x[i - 1] + 0.5 * h * k1, t[i - 1] + 0.5 * h);
                double k3 = f(x[i - 1] + 0.5 * h * k2, t[i - 1] + 0.5 * h);
                double k4 = f(x[i - 1] + h * k3, t[i - 1] + h);
                x[i] = x[i - 1] + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
            }
            return x;
        }

        private double[] AnalyticalSolution(double r, double K, double x0, double[] t)
        {
            int n = t.Length;
            var x = new double[n];
            for (int i = 0; i < n; i++)
            {
                double expTerm = Math.Exp(-r * (t[i] - t[0]));
                x[i] = K / (1 + ((K - x0) / x0) * expTerm);
            }
            return x;
        }
    }
}
