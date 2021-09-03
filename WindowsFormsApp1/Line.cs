using System;
using System.Drawing;
using ShapesInterface;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Line : IShape
    
    {
        public Point StartPoint = new Point();
        public Point EndPoint = new Point();
        public int Width;
        public int Height;
        public int Thickness;
        public Color FillColor;

        public Line(Point _point,int _thickness, Color _colorRound, Color _colorFill)
        {
            this.StartPoint = _point;
            this.Thickness = _thickness;
            this.FillColor = _colorFill;
        }

        public Line()
        {
        }

        public void Initialization(Point startPoint, int penThickness, Color colorRound, Color colorFill)
        {
            StartPoint = startPoint;
            Thickness = penThickness;
            FillColor = colorRound;
            
        }

        public void Draw(Graphics _graphics)
        {
            Pen pen = new Pen(FillColor, Thickness);
            _graphics.DrawLine(pen, StartPoint, EndPoint);
            pen.Dispose();
        }

        public void SetPoint(Point _point)
        {
            EndPoint = _point;
            Width = Math.Abs(EndPoint.X - StartPoint.X) + 1;
            Height = Math.Abs(EndPoint.Y - StartPoint.Y) + 1; 
        }

        public void AddPoint(Point point)
        {
            
        }

        public bool IsSimpleShape()
        {
            return true;
        }

        public bool EndOfCurrentShape()
        {
            throw new NotImplementedException();
        }
    }
    
    public class LineCreator : ICreator
    {
        public string Name
        {
            get
            {
                return "Линия";
            }
        }
    }
}