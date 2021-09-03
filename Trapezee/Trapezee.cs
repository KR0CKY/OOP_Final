using System;

using System.Drawing;
using ShapesInterface;

namespace Trapezee
{
    [Serializable]
    [Plugin("Трапеция")]
    public class DrawRhombus : IShape
    {
        public Point Point1 = new Point();
        public Point Point2 = new Point();
        public int Thickness;
        public Color Front;
        public Color Back;


        
        public void Initialization(Point point, int thickness, Color front, Color back)
        {
            Point1 = point;
            Thickness = thickness;
            Front = front;
            Back = back;
        }

        public void Draw(Graphics graph)
        {
            int start1, start2;
            
            if (Point1.X <= Point2.X) start1 = Point1.X;
            else start1 = Point2.X;
            
            if (Point1.Y <= Point2.Y) start2 = Point1.Y;
            else start2 = Point2.Y;
            
            int r = (int)(Point2.X - Point1.X) / 2;
            
            Point[] points = new Point[4];
            
            var center = new PointF(Point1.X + r, Point1.Y + r);
            points[0] = Point1;
            points[1] = new Point(Point1.X + r, Point1.Y);
            points[2] = Point2;
            points[3] = new Point(Point2.X - r - (int)(2 * r), Point2.Y);

            var brush = new SolidBrush(Back);
            Pen pen = new Pen(Front, Thickness);
        
            graph.DrawPolygon(pen, points);
            graph.FillPolygon(brush, points);
        
            brush.Dispose();
        }

        public void SetPoint(Point point)
        {
            Point2 = point;
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
}

