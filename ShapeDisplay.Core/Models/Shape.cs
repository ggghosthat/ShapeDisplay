using System.Drawing;

namespace ShapeDisplay.Core.Models;

public class Shape
{
    public float X { get; set; }
    public float Y { get; set; }

    public Color BorderColor { get; set; }
    public Color FillColor { get; set; }

    public virtual Graphics PrintShape(Graphics graphics) =>
        graphics;

    public virtual bool ContainsDot(Graphics graphics, PointF point) => 
        false;
}
