using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeDisplay.Core.Models;

public class Rectangle : Shape
{
    public Rectangle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        InitializeParameters(cord, size, borderColor, fillColor);
        GetPath();
    }
     
    public int Width { get; set; }

    public int Height { get; set; }
        
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
        X = destination.X - (Width / 2);
        Y = destination.Y - (Height / 2);
    }

    public override void Resize(Size size)
    {
        if (size.Width > 0)
            Width = size.Width;
        if(size.Height > 0)
            Height = size.Height;
    }

    private void InitializeParameters(Point cord, Size size, Color borderColor, Color fillColor)
    {
        X = CorrectCordinate(cord.X, size.Width);
        Y = CorrectCordinate(cord.Y, size.Height);
        Width = Math.Abs(size.Width);
        Height = Math.Abs(size.Height);
        BorderColor = borderColor;
        FillColor = fillColor;
    }

    private GraphicsPath GetPath()
    {
        var rectangle = new System.Drawing.Rectangle(X, Y, Width, Height);
        var path = new GraphicsPath();
        path.AddRectangle(rectangle);
        return path;
    }
}
