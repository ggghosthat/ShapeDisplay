using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeDisplay.Core.Models;

public class Rectangle : Shape
{
    private GraphicsPath _path;

    public Rectangle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        InitializeParameters(cord, size, borderColor, fillColor);
        CreatePath();
    }
     
    public int Width { get; set; }

    public int Height { get; set; }
        
    public override bool ContainsDot(Point point)
    {
        int xStart = X;        
        int xEnd = X + Width;

        int yStart = Y;
        int yEnd = Y + Height;

        bool isRangeX = CheckValue(point.X, xStart, xEnd);
        bool isRangeY = CheckValue(point.Y, yStart, yEnd);

        if (isRangeX && isRangeY)
            return true;
        else return false;
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

    private bool CheckValue(int desired, int start, int end)
    {
        return Enumerable.Range(start, end).Contains(desired);
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

    private void CreatePath()
    {
        _path = new();
        var rectangle = new System.Drawing.Rectangle(X, Y, Width, Height);
        _path.AddRectangle(rectangle);
    }
}
