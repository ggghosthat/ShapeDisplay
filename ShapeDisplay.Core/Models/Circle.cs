using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeDisplay.Core.Models;

public class Circle : Shape 
{
    public Circle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        InitializeParameters(cord, size, borderColor, fillColor);
    }

    public int Diameter { get; set; }

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
        using (var fillBrush = new SolidBrush(FillColor))
        {
            graphics.DrawPath(borderPen, path);
            graphics.FillPath(fillBrush, path);
        }
    }

    public override void Move(Point destination)
    {
        int radius = Diameter / 2;
        X = destination.X - radius;
        Y = destination.Y - radius;
    }

    private void InitializeParameters(Point cord, Size size, Color borderColor, Color fillColor)
    {
        X = CorrectCordinate(cord.X, size.Width);
        Y = CorrectCordinate(cord.Y, size.Height);
        Diameter = AlignEdge(size);
        BorderColor = borderColor;
        FillColor = fillColor;
    }
    
    private GraphicsPath GetPath()
    {
        var elliplseFrame = new System.Drawing.Rectangle(X, Y, Diameter, Diameter);
        var path = new GraphicsPath();
        path.AddEllipse(elliplseFrame);
        return path;
    }
}
