using System.Drawing;

namespace ShapeDisplay.Core.Models;

public class Circle : Shape 
{

    public Circle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        X = cord.X;
        Y = cord.Y;
        Radius = CorrectEdge(size);
        BorderColor = borderColor;
        FillColor = fillColor;
    }

    public float Radius { get; set; }

    private int CorrectEdge(Size size)
    {
        if (Math.Abs(size.Width) > Math.Abs(size.Height))
            return size.Width;
        else
            return size.Height;
    }

    public override bool ContainsDot(PointF point)
    {
        var circleCenter = new PointF(X + Radius, Y + Radius);
        return IsPointInsideCircle(point, circleCenter, Radius);
    }

    public override Graphics PrintShape(Graphics graphics)
    {
        var borderPen = new Pen(BorderColor);
        var fillBrush = new SolidBrush(FillColor);
        var diameter = 2 * Radius;
        var rectangle = new RectangleF(X, Y, diameter, diameter);
        
        graphics.DrawEllipse(borderPen, rectangle);
        graphics.FillEllipse(fillBrush, rectangle);

        return graphics;
    }

    private bool IsPointInsideCircle(PointF point, PointF circleCenter, float radius)
    {
        //calculate distance between circle's center and desired point
        float distanceSquared = (point.X - circleCenter.X) * (point.X - circleCenter.Y) + (point.Y - circleCenter.Y) * (point.Y - circleCenter.Y);
        float distance = (float)Math.Sqrt(distanceSquared);

        //if ditance fewer than radius, point inside the circle
        return distance <= radius;
    }
}
