using ShapeDisplay.Core.Models;

using System.Drawing.Drawing2D;

namespace ShapeDisplay;

public partial class Form1 : Form
{
    private List<Shape> _shapes = [];
    private Shape _shape;
    private ShapeType _shapeType = ShapeType.NONE;

    private bool _moving;
    private Point _mouseStartPoint = Point.Empty;
    private Point _mouseMovePoint = Point.Empty;
    private Point _mouseEndPoint = Point.Empty;

    private Color _borderColor = Color.Red;
    private Color _fillColor = Color.Yellow;

    public Form1()
    {
        InitializeComponent();
    }

    private void canvas_Paint(object sender, PaintEventArgs e)
    {
        var _graphic = e.Graphics;
        _graphic.SmoothingMode = SmoothingMode.HighQuality;

        foreach (var shape in _shapes)
            shape.Draw(_graphic);
    }

    private void canvas_MouseDown(object sender, MouseEventArgs e)
    {
        _mouseStartPoint = e.Location;
        _mouseMovePoint = e.Location;

        bool detected = TryDetectShapeByPoint(e.Location);

        if (_shape != null && detected)
        {
            _moving = true;
        }
        else
        {
            _shape = null;
            _moving = false;
        }
    }

    private void canvas_MouseMove(object sender, MouseEventArgs e)
    {
        if (_moving)
        {
            _mouseMovePoint = e.Location;
            _shape.Move(_mouseMovePoint);
            canvas.Invalidate();
        }
    }

    private void canvas_MouseUp(object sender, MouseEventArgs e)
    {
        _mouseEndPoint = e.Location;
        if (_moving)
        {
            _moving = false;
            _mouseMovePoint = Point.Empty;
        }
        else
        {
            DrawShape();
        }

        canvas.Invalidate();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var color = GetColor(_borderColor);
        btnPen.BackColor = color;
        _borderColor = color;
    }

    private void btnFill_Click(object sender, EventArgs e)
    {
        var color = GetColor(_fillColor);
        btnFill.BackColor = color;
        _fillColor = color;
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton4.Checked)
            _shapeType = ShapeType.RECTANGLE;
    }

    private void radioButton5_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton5.Checked)
            _shapeType = ShapeType.RIGHT_TRIANGLE;
    }

    private void radioButton6_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton6.Checked)
            _shapeType = ShapeType.CIRCLE;
    }

    private void sizeBar_Scroll(object sender, EventArgs e)
    {
        if (_shape is ShapeDisplay.Core.Models.Rectangle rectangle)
        {
            int width = (int)rtWidthSizeBar.Value;
            var size = new Size(width, 0);
            rectangle.Resize(size);
            canvas.Invalidate();
        }
    }

    private void rtHeightSizeBar_Scroll(object sender, EventArgs e)
    {
        if (_shape is ShapeDisplay.Core.Models.Rectangle rectangle)
        {
            int height = (int)rtHeightSizeBar.Value;
            var size = new Size(0, height);
            rectangle.Resize(size);
            canvas.Invalidate();
        }
    }

    private void rTriangleSizeBar_Scroll(object sender, EventArgs e)
    {
        if (_shape is RightTriangle rTriangle)
        {
            int edge = (int)rTriangleSizeBar.Value;
            var size = new Size(edge, 0);
            rTriangle.Resize(size);
            canvas.Invalidate();
        }
    }

    private void cSizeBar_Scroll(object sender, EventArgs e)
    {
        if (_shape is Circle circle)
        {
            int radius = (int)cSizeBar.Value;
            var size = new Size(radius, 0);
            circle.Resize(size);
            canvas.Invalidate();
        }
    }


    private bool TryDetectShapeByPoint(Point point)
    {
        foreach (var shape in _shapes)
        {
            if (shape.HasDot(point))
            {
                _shape = shape;
                UpdateSizebars();

                return true;
            }
        }

        return false;
    }

    private void DrawShape()
    {
        Shape shape = null;

        var size = new Size
        {
            Width = _mouseEndPoint.X - _mouseStartPoint.X,
            Height = _mouseEndPoint.Y - _mouseStartPoint.Y
        };

        switch (_shapeType)
        {
            case ShapeType.RIGHT_TRIANGLE:
                var rightTriangle = new RightTriangle(_mouseStartPoint, size, _borderColor, _fillColor);
                rTriangleSizeBar.Value = rightTriangle.Edge;
                shape = rightTriangle;
                break;
            case ShapeType.CIRCLE:
                var circle = new Circle(_mouseStartPoint, size, _borderColor, _fillColor);
                cSizeBar.Value = circle.Radius;
                shape = circle;
                break;
            case ShapeType.RECTANGLE:
                var rectangle = new Core.Models.Rectangle(_mouseStartPoint, size, _borderColor, _fillColor);
                rtWidthSizeBar.Value = rectangle.Width;
                rtHeightSizeBar.Value = rectangle.Height;
                shape = rectangle;
                break;
            case ShapeType.NONE:
                break;
        }

        if (shape != null)
            _shapes.Add(shape);
    }

    private Color GetColor(Color defaultColor)
    {
        using var coldlg = new ColorDialog();
        if (coldlg.ShowDialog() == DialogResult.OK)
            return coldlg.Color;

        return defaultColor;
    }

    private void UpdateSizebars()
    {
        if (_shape is RightTriangle rTriangle)
        {
            rTriangleSizeBar.Value = rTriangle.Edge;
        }
        else if (_shape is Circle circle)
        {
            cSizeBar.Value = circle.Radius;
        }
        else if (_shape is ShapeDisplay.Core.Models.Rectangle rectangle)
        {
            rtWidthSizeBar.Value = rectangle.Width;
            rtHeightSizeBar.Value = rectangle.Height;
        }
    }
}
