using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Media;

namespace AvaloniaCanvasApp.Views
{
    public class Pizza : Shape
    {
        protected override Geometry? CreateDefiningGeometry()
        {
            var ratioX = Width / 200;
            var ratioY = Height / 200;

            var geometry = new StreamGeometry();
            using StreamGeometryContext c = geometry.Open();
            c.BeginFigure(new Point(200 * ratioX, 200 * ratioY), true);
            c.LineTo(new Point(175 * ratioX, 50 * ratioY));
            c.ArcTo(new Point(50 * ratioX, 150 * ratioY), new Size(1, 1), 0, true, SweepDirection.CounterClockwise);
            c.LineTo(new Point(200 * ratioX, 200 * ratioY));

            return geometry;
        }
    }
}