using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace SD20308
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double[] rainfall = { 23, 45, 78, 120, 160, 200, 180, 150, 100, 60, 40, 25 };

            cartesianChart1.Series = new ISeries[]
            {
            new ColumnSeries<double>
            {
                Values = rainfall,
                Name = "Lượng mưa (mm)",
                Fill = new SolidColorPaint(SKColors.DeepSkyBlue)
            }
            };

            cartesianChart1.XAxes = new Axis[]
            {
            new Axis
            {
                Labels = new[] { "Th1", "Th2", "Th3", "Th4", "Th5", "Th6", "Th7", "Th8", "Th9", "Th10", "Th11", "Th12" },
                Name = "Tháng"
            }
            };

            cartesianChart1.YAxes = new Axis[]
            {
            new Axis
            {
                Name = "Lượng mưa (mm)"
            }
            };

        }
    }
}
