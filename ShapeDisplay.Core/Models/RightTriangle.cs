using System.Drawing;

namespace ShapeDisplay.Core.Models;

public class RightTriangle : Shape
{
    public RightTriangle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        X = CorrectStartCordinate(cord.X, size.Width);
        Y = CorrectStartCordinate(cord.Y, size.Height);
        Edge = CorrectEdge(size);
        BorderColor = borderColor;
        FillColor = fillColor;
    }

    public float Edge { get; set; }

    public float Angle => 60f;

    public override bool ContainsDot(IList<PointF> polygon, PointF point)
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

    public override Graphics PrintShape(Graphics graphics)
    {
        var borderPen = new Pen(BorderColor);
        var fillBrush = new SolidBrush(FillColor);
        var rectangle = new RectangleF(X, Y, Edge, Edge);

        PointF[] rtsh = 
        [
            new PointF(rectangle.Left, rectangle.Top),
            new PointF(rectangle.Right, rectangle.Bottom), 
            new PointF(rectangle.Left, rectangle.Bottom)
        ];

        graphics.DrawPolygon(borderPen, rtsh);
        graphics.FillPolygon(fillBrush, rtsh);
        return graphics;
    }
}
