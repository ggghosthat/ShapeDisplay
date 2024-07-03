﻿using System.Drawing;

namespace ShapeDisplay.Core.Models;

public class Circle : Shape 
{
    public Circle(Point cord, Size size, Color borderColor, Color fillColor)
    {
        X = CorrectStartCordinate(cord.X, size.Width);
        Y = CorrectStartCordinate(cord.Y, size.Height);
        Diameter = CorrectEdge(size);
        BorderColor = borderColor;
        FillColor = fillColor;
    }

    public float Diameter { get; set; }

    public override bool ContainsDot(PointF point)
    {
        var circleCenter = new PointF(X + Diameter, Y + Diameter);
        return IsPointInsideCircle(point, circleCenter, Diameter);
    }

    public override Graphics PrintShape(Graphics graphics)
    {
        var borderPen = new Pen(BorderColor);
        var fillBrush = new SolidBrush(FillColor);
        var rectangle = new RectangleF(X, Y, Diameter, Diameter);
        
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
