using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeDisplay.Core.Models;

public class Circle : Shape 
{
    private GraphicsPath _path;

    public Circle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        InitializeParameters(cord, size, borderColor, fillColor);
        CreatePath();
    }

    public int Diameter { get; set; }

    public override bool ContainsDot(Point point)
    {
        int radius = Diameter / 2;
        var circleCenter = new Point(X + radius, Y + radius);
        return IsPointInsideCircle(point, circleCenter, radius);
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

    private bool IsPointInsideCircle(Point point, Point circleCenter, int radius)
    {
        //calculate distance between circle's center and desired point
        float distanceSquared = (point.X - circleCenter.X) * (point.X - circleCenter.Y) + (point.Y - circleCenter.Y) * (point.Y - circleCenter.Y);
        float distance = (float)Math.Sqrt(distanceSquared);

        //if ditance fewer than radius, point inside the circle
        return distance <= radius;
    }

    private void CreatePath()
    {
        _path = new();
        var elliplseFrame = new System.Drawing.Rectangle(X, Y, Diameter, Diameter);
        _path.AddEllipse(elliplseFrame);
    }

    private void InitializeParameters(Point cord, Size size, Color borderColor, Color fillColor)
    {
        X = CorrectCordinate(cord.X, size.Width);
        Y = CorrectCordinate(cord.Y, size.Height);
        Diameter = AlignEdge(size);
        BorderColor = borderColor;
        FillColor = fillColor;
    }

}
