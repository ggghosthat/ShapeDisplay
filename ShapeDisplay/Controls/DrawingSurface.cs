using ShapeDisplay.Core.Models;
using System.Drawing.Drawing2D;

namespace ShapeDisplay.Controls;

public partial class DrawingSurface : PictureBox
{
    private bool _moving;
    private Point _previousPoint = Point.Empty;
    private Point _movePoint = Point.Empty;
    private Shape _selectedShape;

    public DrawingSurface()
    {
        InitializeComponent();
        Shapes = new();
    }

    public Color BorderColor { get; set; }
    
    public Color FillColor { get; set; }

    public ShapeType ShapeType { get; set; }

    public List<Shape> Shapes { get; private set; }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

        foreach (var shape in Shapes)
            shape.Draw(e.Graphics);
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

        foreach (var shape in Shapes)
            shape.Draw(e.Graphics);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        for (int i = Shapes.Count - 1; i >= 0; i--)
        {
            if (Shapes[i].HasDot(e.Location))
            {
                _selectedShape = Shapes[i];
                break;
            }
        }

        if (_selectedShape != null)
        {
            _moving = true;
            _movePoint = e.Location;
        }
        base.OnMouseDown(e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        if (_moving)
        {
            var currentPosition = new Point(e.X - _movePoint.X, e.Y - _movePoint.Y);
            _selectedShape.Move(currentPosition);
            _movePoint = e.Location;
            this.Invalidate();
        }
        base.OnMouseMove(e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        if (_moving)
        {
            _selectedShape = null;
            _moving = false;
            //_movePoint = Point.Empty;
        }

        DisplayShape(e.Location);

        this.Invalidate();
        base.OnMouseUp(e);
    }
        
    public void AddShape(Shape shape)
    {
        Shapes.Add(shape);
    }

    private void DisplayShape(Point point)
    {
        _movePoint = point;

        var size = new Size
        {
            Width = _movePoint.X - _previousPoint.X,
            Height = _movePoint.Y - _previousPoint.Y
        };

        Shape? shape = ShapeType switch
        {
            ShapeType.RIGHT_TRIANGLE => new RightTriangle(_previousPoint, size, BorderColor, FillColor),
            ShapeType.CIRCLE => new Circle(_previousPoint, size, BorderColor, FillColor),
            ShapeType.RECTANGLE => new Core.Models.Rectangle(_previousPoint, size, BorderColor, FillColor),
            ShapeType.NONE => null
        };

        if (shape != null)
            Shapes.Add(shape);
    }
}
