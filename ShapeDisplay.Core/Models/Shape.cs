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

    public int X { get; set; }
    public int Y { get; set; }

    public Color BorderColor { get; set; }
    public Color FillColor { get; set; }

    public virtual void Draw(Graphics graphics)
    { }

    public virtual void Move(Point point)
    { }

    public virtual void Resize(Size size)
    { }
        
    public virtual bool HasDot(Point point) => 
        false;

    protected int CorrectCordinate(int startCord, int shift)
    {
        int endCord = (startCord + shift);
        if (startCord > endCord)
            return Math.Abs(endCord);
        else
            return startCord;
    }

    protected int AlignEdge(Size sizeBox) =>
        Math.Min(Math.Abs(sizeBox.Width), Math.Abs(sizeBox.Height));
}
