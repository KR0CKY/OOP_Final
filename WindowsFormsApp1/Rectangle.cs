using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using ShapesInterface;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Rectangle : IShape

    {   public Point Point1 = new Point();
        public Point Point2 = new Point();
        public int Width;
        public int Height;
        public int Thickness;
        public Color Front;
        public Color Back;
        
        public Rectangle()
        {
        }

        public void Initialization(Point startPoint, int penThickness, Color colorRound, Color colorFill)
        {
            Point1 = startPoint;
            Thickness = penThickness;
            Front = colorRound;
            Back = colorFill;
        }

        public void Draw(Graphics graph)
        {
            int start1, start2;

            if (Point1.X <= Point2.X) start1 = Point1.X;
            else start1 = Point2.X;

            if (Point1.Y <= Point2.Y) start2 = Point1.Y;
            else start2 = Point2.Y;

            Pen pen = new Pen(Front, Thickness);
            pen.Alignment = PenAlignment.Inset;
            graph.DrawRectangle(pen, start1, start2, Width, Height);
            pen.Dispose();

            SolidBrush brush = new SolidBrush(Back);
            graph.FillRectangle(brush, start1 + Thickness, start2 + Thickness, Width - Thickness * 2, Height - Thickness * 2);
            brush.Dispose();
        }

        public void SetPoint(Point point)
        {
            Point2 = point;
            Width = Math.Abs(Point2.X - Point1.X) + 1;
            Height = Math.Abs(Point2.Y - Point1.Y) + 1;  
        }

        public void AddPoint(Point point)
        {

        }

        public void Save()
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
    
    public class RectangleCreator : ICreator
    {
        public string Name
        {
            get
            {
                return "Прямоугольник";
            }
        }
    }

}