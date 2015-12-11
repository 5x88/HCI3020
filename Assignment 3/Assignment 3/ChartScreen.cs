using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assignment_3 {
    public partial class ChartScreen : Form {
        public ChartScreen(MovieList results) {
            InitializeComponent();
            int total = results.movielist.Count;
            DataPoint[] points = new DataPoint[total];
            chart1.Series.Clear();
            chart1.Series.Add("Movies");
            chart1.Series["Movies"].ChartType = SeriesChartType.Point;

            
            for (int i = 0; i < results.movielist.Count; i++) {
                points[i] = new DataPoint();
                points[i].SetValueXY(results.movielist[i].year, results.movielist[i].rating);
                chart1.Series["Movies"].Points.Add(points[i]);
            }
        }
    }
}
