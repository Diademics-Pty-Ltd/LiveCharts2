﻿using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.Drawing;
using LiveChartsCore.Kernel;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using SkiaSharp;

namespace ViewModelsSamples.General.VisualElements;

public partial class ViewModel : ObservableObject
{
    public IEnumerable<ChartElement<SkiaSharpDrawingContext>> VisualElements { get; set; } = new List<ChartElement<SkiaSharpDrawingContext>>
    {
         new GeometryVisual<RectangleGeometry>
         {
             X = 2.5,
             Y = 3.5,
             LocationUnit = MeasureUnit.ChartValues,
             Width = 4,
             Height = 2,
             SizeUnit = MeasureUnit.ChartValues,
             Fill = new SolidColorPaint(new SKColor(239, 83, 80, 220)) { ZIndex = 10 },
             Stroke = new SolidColorPaint(new SKColor(239, 83, 80)) { ZIndex = 10, StrokeThickness = 1.5f },
             Label = "Hello!",
             LabelPaint = new SolidColorPaint(new SKColor(220, 220, 220)) { ZIndex = 11 },
             LabelSize = 12
         },
         new GeometryVisual<OvalGeometry>
         {
             X = 5.5,
             Y = 6,
             LocationUnit = MeasureUnit.ChartValues,
             Width = 4,
             Height = 5,
             SizeUnit = MeasureUnit.ChartValues,
             Fill = new SolidColorPaint(new SKColor(100, 221, 23, 50)) { ZIndex = - 10 },
             Stroke = new SolidColorPaint(new SKColor(100, 221, 23)) { ZIndex = -10, StrokeThickness = 1.5f },
         },
         new LabelVisual
         {
             Text = "What happened here?",
             X = 11,
             Y = 1,
             TextSize = 16,
             Paint = new SolidColorPaint(new SKColor(250, 250, 250)) { ZIndex = 11 },
             BackgroundColor = new LvcColor(55, 71, 79),
             Padding = new Padding(12),
             LocationUnit = MeasureUnit.ChartValues,
             Translate = new LvcPoint(0, -35)
         },
         new SVGVisual
         {
             Path = SVGPoints.Star,
             X = 80,
             Y = 80,
             LocationUnit = MeasureUnit.Pixels,
             Width = 100,
             Height = 100,
             SizeUnit = MeasureUnit.Pixels,
             Fill = new SolidColorPaint(new SKColor(251, 192, 45, 50)) { ZIndex = 10 },
             Stroke = new SolidColorPaint(new SKColor(251, 192, 45)) { ZIndex = 10, StrokeThickness = 1.5f },
             Label = "This one is fixed",
             LabelPaint = new SolidColorPaint(SKColors.Black) { ZIndex = 11 },
             LabelSize = 10
         },
    };

    public ISeries[] Series { get; set; } =
    {
        new LineSeries<int>
        {
            GeometrySize = 13,
            Values = new int[] { 2,2,3,4,2,2,3,6,3,5,2,1,4,5,2,3,2,4,5,3,2,6 }
        }
    };
}
