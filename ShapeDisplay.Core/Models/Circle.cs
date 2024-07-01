using System.Drawing;

namespace ShapeDisplay.Core.Models;

public class Circle : Shape 
{
    public float Radius { get; set; }

    public override bool ContainsDot(PointF point)
    {
        var circleCenter = new PointF(X + Radius, Y + Radius);
        return IsPointInsideCircle(point, circleCenter, Radius);
    }

    public override Graphics PrintShape(Graphics graphics)
    {
        var borderPen = new Pen(BorderColor);
        var fillBrush = new SolidBrush(FillColor);
        var rectangle = new RectangleF(X, Y, 2*Radius, 2*Radius);
        
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
