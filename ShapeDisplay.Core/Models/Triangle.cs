using System.Drawing;

namespace ShapeDisplay.Core.Models;

public class Triangle : Shape
{ 
    public float Edge { get; set; }
    public float Angle => 60f;

    public override bool ContainsDot(Graphics graphics, PointF point)
    {
        return false;
    }

    public override Graphics PrintShape(Graphics graphics)
    {
        return graphics;
    }
}
