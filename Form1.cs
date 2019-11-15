using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Comp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Chart1.Series.Clear();
            Chart2.Series.Clear();
            Chart3.Series.Clear();

            double x0 = Double.Parse(textBoxX0.Text);
            double y0 = Double.Parse(textBoxY0.Text);
            double max = Double.Parse(textBoxX.Text);
            int num = int.Parse(textBoxSteps.Text);
            int max_err = int.Parse(textBoxIntervalFrom.Text);

            SeriesCollection[] series = new SeriesCollection[3];
            for (int i = 0; i < 3; i++) series[i] = new SeriesCollection();
            ChartValues<ObservablePoint>[] values = new ChartValues<ObservablePoint>[10];
            for (int i= 0; i<10; i++) values[i] = new ChartValues<ObservablePoint>();

            List<PointD> exact =  Exact.Solve(x0,y0,max, num);
            foreach (var value in exact) { values[0].Add(new ObservablePoint(value.X,value.Y)); }
            series[0].Add(new LiveCharts.Wpf.LineSeries() { Title = "Exact", Values = values[0], PointGeometrySize = 0 });

            
            List<PointD>[] result_euler = (new Euler()).Solve(x0, y0, max, num, max_err);
            foreach (var value in result_euler[0]) { values[1].Add(new ObservablePoint(value.X, value.Y)); }
            series[0].Add(new LiveCharts.Wpf.LineSeries() { Title = "Euler", Values = values[1], PointGeometrySize = 0});

            List<PointD>[] result_ext = (new Euler_ex()).Solve(x0, y0, max, num, max_err);
            foreach (var value in result_ext[0]) { values[2].Add(new ObservablePoint(value.X, value.Y)); }
            series[0].Add(new LiveCharts.Wpf.LineSeries() { Title = "Euler_ex", Values = values[2], PointGeometrySize = 0 });

            List<PointD>[] result_ru = (new Runge_Kutta()).Solve(x0, y0, max, num, max_err);
            foreach (var value in result_ru[0]) { values[3].Add(new ObservablePoint(value.X, value.Y)); }
            series[0].Add(new LiveCharts.Wpf.LineSeries() { Title = "Runge_Kutta", Values = values[3], PointGeometrySize = 0 });

            Chart1.Series = series[0];

            foreach (var value in result_euler[1]) { values[4].Add(new ObservablePoint(value.X, value.Y)); }
            series[1].Add(new LiveCharts.Wpf.LineSeries() { Title = "Euler", Values = values[4], PointGeometrySize = 0 });

            foreach (var value in result_ext[1]) { values[5].Add(new ObservablePoint(value.X, value.Y)); }
            series[1].Add(new LiveCharts.Wpf.LineSeries() { Title = "Euler_ex", Values = values[5], PointGeometrySize = 0 });

            foreach (var value in result_ru[1]) { values[6].Add(new ObservablePoint(value.X, value.Y)); }
            series[1].Add(new LiveCharts.Wpf.LineSeries() { Title = "Runge_Kutta", Values = values[6], PointGeometrySize = 0 });

            Chart2.Series = series[1];

            foreach (var value in result_euler[2]) { values[7].Add(new ObservablePoint(value.X, value.Y)); }
            series[2].Add(new LiveCharts.Wpf.LineSeries() { Title = "Euler", Values = values[7], PointGeometrySize = 0 });

            foreach (var value in result_ext[2]) { values[8].Add(new ObservablePoint(value.X, value.Y)); }
            series[2].Add(new LiveCharts.Wpf.LineSeries() { Title = "Euler_ex", Values = values[8], PointGeometrySize = 0 });

            foreach (var value in result_ru[2]) { values[9].Add(new ObservablePoint(value.X, value.Y)); }
            series[2].Add(new LiveCharts.Wpf.LineSeries() { Title = "Runge_Kutta", Values = values[9], PointGeometrySize = 0 });

            Chart3.Series = series[2];

        }
    }
}
