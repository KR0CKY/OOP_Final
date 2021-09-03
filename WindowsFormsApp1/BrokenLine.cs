using System;
using System.Collections.Generic;
using System.Drawing;
using ShapesInterface;

namespace WindowsFormsApp1
{
    [Serializable]
    class BrokenLine : IShape
    {
        public List<Point> ListPoints = new List<Point>();
        public Point Point1;
        public Color Front;
        public int Thickness;

        public void Initialization(Point point, int thickness, Color front, Color back)
        {
            ListPoints.Add(point);
            Front = front;
            Thickness = thickness;
        }

        public void Draw(Graphics graph)
        {
            Pen pen = new Pen(Front, Thickness);

            for (int i = 1; i < ListPoints.Count; i++)
            {
                graph.DrawLine(pen, ListPoints[i - 1], ListPoints[i]);
            }

            graph.DrawLine(pen, ListPoints[ListPoints.Count - 1], Point1);

            pen.Dispose();
        }

        public void SetPoint(Point point)
        {
            Point1 = point;
        }

        public void AddPoint(Point point)
        {
            ListPoints.Add(point);
        }

        public bool IsSimpleShape()
        {
            return false;
        }

        public bool EndOfCurrentShape()
        {
            return true;
        }

        public void Save()
        {

        }
        
    }
    
    public class BrokenLineCreator : ICreator
    {
        public string Name
        {
            get
            {
                return "Ломаная линия";
            }
        }
    }
}
    