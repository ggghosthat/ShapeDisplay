using System.Drawing;

namespace ShapeDisplay.Core.Models;

public class Shape
{
    private Guid _shapeId;

    public Shape()
    {
        _shapeId = Guid.NewGuid();
    }

    public Guid ShapeId => _shapeId;

    public float X { get; set; }
    public float Y { get; set; }

    public Color BorderColor { get; set; }
    public Color FillColor { get; set; }

    /// <summary>
    /// Print current shape on the input Graphics object
    /// </summary>
    /// <param name="graphics">input Graphics object</param>
    /// <returns>Graphics with the shape</returns>
    public virtual Graphics PrintShape(Graphics graphics) =>
        graphics;

    /// <summary>
    /// Check if figure (squre, circle) contains input point
    /// </summary>
    /// <param name="point"></param>
    /// <returns>True - if contains, False - if does not contains</returns>
    public virtual bool ContainsDot(PointF point) => 
        false;

    /// <summary>
    /// Check if polgon contains input point
    /// </summary>
    /// <param name="polygon">polygon</param>
    /// <param name="point">point</param>
    /// <returns></returns>
    public virtual bool ContainsDot(IList<PointF> polygon, PointF point) =>
        false;
}
