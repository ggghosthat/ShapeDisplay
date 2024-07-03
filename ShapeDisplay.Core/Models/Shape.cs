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

    // Print current shape on the input Graphics object
    public virtual void Draw(Graphics graphics)
    { }

    public virtual void Move(Point point)
    { }
        
    /// Check if figure (squre, circle) contains input point    
    public virtual bool ContainsDot(Point point) => 
        false;

    /// Check if polgon contains input point
    public virtual bool ContainsDot(IList<Point> polygon, Point point) =>
        false;

    /// Correct axis position with shifting
    protected int CorrectCordinate(int startCord, int shift)
    {
        int endCord = (startCord + shift);
        if (startCord > endCord)
            return Math.Abs(endCord);
        else
            return startCord;
    }

    //align edge distance based on size box
    protected int AlignEdge(Size sizeBox) =>
        Math.Min(Math.Abs(sizeBox.Width), Math.Abs(sizeBox.Height));
}
