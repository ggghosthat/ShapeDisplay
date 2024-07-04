using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeDisplay.Core.Models;

public class RightTriangle : Shape
{
    public RightTriangle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        InitializeParameters(cord, size, borderColor, fillColor);
    }
        
    public int Edge { get; set; }

    public int Angle => 60;
      
    public override bool HasDot(Point point)
    {
        bool result = false;
        using (var path = GetPath())
            result = path.IsVisible(point);
        return result;
    }

    public override void Draw(Graphics graphics)
    {
        using (var path = GetPath())
        using (var borderPen = new Pen(BorderColor))
        using (var fillBrush= new SolidBrush(FillColor))
        {
            graphics.DrawPath(borderPen, path);
            graphics.FillPath(fillBrush, path);
        }
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

    private GraphicsPath GetPath()
    {
        var rectangle = new System.Drawing.Rectangle(X, Y, Edge, Edge);

        Point[] points =
        [
            new Point(rectangle.Left, rectangle.Top),
            new Point(rectangle.Right, rectangle.Bottom),
            new Point(rectangle.Left, rectangle.Bottom)
        ];

        var path =  new GraphicsPath();
        path.AddPolygon(points);
        return path;
    }

    private Point CountCenterPoint()
    {
        var x = (X + X + (X + Edge)) / 3;
        var y = (Y + Y + (Y + Edge)) / 3;
        return new Point(x, y);
    }
}
