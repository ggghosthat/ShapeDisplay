using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeDisplay.Core.Models;

public class RightTriangle : Shape
{
    private GraphicsPath _path;

    public RightTriangle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        InitializeParameters(cord, size, borderColor, fillColor);
        CreatePath();
    }
        
    public int Edge { get; set; }

    public int Angle => 60;
      
    public override bool ContainsDot(IList<Point> polygon, Point point)
    {
        int n = polygon.Count;
        bool result = false;
        for (int i = 0, j = n - 1; i < n; j = i++)
        {
            if (((polygon[i].Y > point.Y) != (polygon[j].Y > point.Y)) &&
                (point.X < (polygon[j].X - polygon[i].X) * (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) + polygon[i].X))
            {
                result = !result;
            }
        }
        return result;
    }

    public override void Draw(Graphics graphics)
    {
        var borderPen = new Pen(BorderColor);
        var fillBrush = new SolidBrush(FillColor);

        graphics.DrawPath(borderPen, _path);
        graphics.FillPath(fillBrush, _path);
    }

    public override void Move(Point destination)
    {
        X = destination.X;
        Y = destination.Y;
    }

    private void InitializeParameters(Point cord, Size size, Color borderColor, Color fillColor)
    {
        X = CorrectCordinate(cord.X, size.Width);
        Y = CorrectCordinate(cord.Y, size.Height);
        Edge = AlignEdge(size);
        BorderColor = borderColor;
        FillColor = fillColor;
    }

    private void CreatePath()
    {
        var rectangle = new System.Drawing.Rectangle(X, Y, Edge, Edge);

        Point[] points =
        [
            new Point(rectangle.Left, rectangle.Top),
            new Point(rectangle.Right, rectangle.Bottom),
            new Point(rectangle.Left, rectangle.Bottom)
        ];

        _path = new();
        _path.AddPolygon(points);
    }
}
