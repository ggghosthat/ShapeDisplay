using ShapeDisplay.Core.Models;

using System.Drawing.Drawing2D;

namespace ShapeDisplay;

public partial class Form1 : Form
{
    private List<Shape> _shapes = [];
    private Shape _shape;

    private Graphics _graphic;
    private ShapeType _shapeType = ShapeType.NONE;

    private Color _borderColor = Color.Red;
    private Color _fillColor = Color.Yellow;
    private bool _moving;

    private Point _mouseStartPoint = Point.Empty;
    private Point _mouseMovePoint = Point.Empty;
    private Point _mouseEndPoint = Point.Empty;

    public Form1()
    {
        InitializeComponent();
    }

    private void canvas_Paint(object sender, PaintEventArgs e)
    {
        _graphic = e.Graphics;
        _graphic.SmoothingMode = SmoothingMode.HighQuality;

        foreach (var shape in _shapes)
            shape.Draw(_graphic);
    }

    private void canvas_MouseDown(object sender, MouseEventArgs e)
    {
        _mouseStartPoint = e.Location;
        for (int i = _shapes.Count - 1; i >= 0; i--)
        {
            if (_shapes[i].HasDot(e.Location))
            {
                _shape = _shapes[i];
                break;
            }
        }

        if (_shape!= null)
        {
            _moving = true;
            _mouseMovePoint = e.Location;
        }
    }
    
    private void canvas_MouseMove(object sender, MouseEventArgs e)
    {
        if (_moving)
        {
            _shape.Move(e.Location);
            _mouseMovePoint = e.Location;
            canvas.Invalidate();
        }
    }

    private void canvas_MouseUp(object sender, MouseEventArgs e)
    {
        _mouseEndPoint = e.Location;
        if (_moving)
        {
            _shape = null;
            _moving = false;
            _mouseMovePoint = Point.Empty;
        }
        else
        {
            DrawShape();
        }
        
        canvas.Invalidate();
    }

    private void DrawShape()
    {
        var size = new Size
        {
            Width = _mouseEndPoint.X - _mouseStartPoint.X,
            Height = _mouseEndPoint.Y - _mouseStartPoint.Y
        };

        Shape? shape = _shapeType switch
        {
            ShapeType.RIGHT_TRIANGLE => new RightTriangle(_mouseStartPoint, size, _borderColor, _fillColor),
            ShapeType.CIRCLE => new Circle(_mouseStartPoint, size, _borderColor, _fillColor),
            ShapeType.RECTANGLE => new Core.Models.Rectangle(_mouseStartPoint, size, _borderColor, _fillColor),
            ShapeType.NONE => null
        };

        if (shape != null)
            _shapes.Add(shape);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var defaultColor = Color.Red;
        var color = GetColor(defaultColor);
        btnPen.BackColor = color;
        _borderColor = color;
    }

    private void btnFill_Click(object sender, EventArgs e)
    {
        var defaultColor = Color.Red;
        var color = GetColor(defaultColor);
        btnFill.BackColor = color;
        _fillColor = color;
    }

    //return color for color selection buttons
    //if its canceled return standart palette 
    private Color GetColor(Color defaultColor)
    {
        var coldlg = new ColorDialog();

        if (coldlg.ShowDialog() == DialogResult.OK)
            return coldlg.Color;

        return defaultColor;
    }


    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton4.Checked)
        {
            _shapeType = ShapeType.RECTANGLE;
        }
    }

    private void radioButton5_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton5.Checked)
        {
            _shapeType = ShapeType.RIGHT_TRIANGLE;
        }
    }

    private void radioButton6_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton6.Checked)
        {
            _shapeType = ShapeType.CIRCLE;
        }
    }    
}
