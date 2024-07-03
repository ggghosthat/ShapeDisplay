﻿using System.Drawing;

namespace ShapeDisplay.Core.Models;

public class Rectangle : Shape
{
    public Rectangle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        X = cord.X;
        Y = cord.Y;
        Width = size.Width;
        Height = size.Height;
        BorderColor = borderColor;
        FillColor = fillColor;
    }

    public float Width { get; set; }
    public float Height { get; set; }

    private int CorrectEdge(Size size)
    {
        if (Math.Abs(size.Width) > Math.Abs(size.Height))
            return size.Width;
        else
            return size.Height;
    }

    public override bool ContainsDot(PointF point)
    {
        float xStart = X;        
        float xEnd = X + Width;

        float yStart = Y;
        float yEnd = Y + Height;

        bool isRangeX = RangeValue(point.X, xStart, xEnd);
        bool isRangeY = RangeValue(point.Y, yStart, yEnd);

        if (isRangeX && isRangeY)
            return true;
        else return false;
    }

    public override Graphics PrintShape(Graphics graphics)
    {
        var borderPen = new Pen(BorderColor);
        var fillBrush = new SolidBrush(FillColor);
        var rectangle = new RectangleF(X, Y, Width, Height);

        graphics.DrawRectangle(borderPen, rectangle);
        graphics.FillRectangle(fillBrush, rectangle);
        
        return graphics;
    }

    private bool RangeValue(float desired, float start, float end) =>
        (desired > start) && (desired < end);
}
