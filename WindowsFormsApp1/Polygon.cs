using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using ShapesInterface;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Polygon : IShape
    {public List<Point> ListPoints = new List<Point>();
        public Point Point1;
        public Color Front;
        public Color Back;
        public int Thickness;
        public bool EndOfDrawing;

        public Polygon()
        {
        }
        
        public void Initialization(Point startPoint, int penThickness, Color colorRound, Color colorFill)
        {
            ListPoints.Add(startPoint);
            Back = colorFill;
            Front = colorRound;
            Thickness = penThickness;
        }

        public void Draw(Graphics graph)
        {
            Pen pen = new Pen(Front, Thickness);
            
            if (EndOfDrawing)
            {
                var brush = new SolidBrush(Back);
                graph.DrawPolygon(pen, ListPoints.ToArray());
                graph.FillPolygon(brush, ListPoints.ToArray());
                brush.Dispose();
            }
            else
            {
                int N = ListPoints.Count;
                if (N > 1)
                {
                    for (int i = 0; i < N - 1; i++)
                    {
                        graph.DrawLine(pen, ListPoints.ElementAt<Point>(i), ListPoints.ElementAt<Point>(i + 1));
                    }

                }

            }
        }

        public void SetPoint(Point point)
        {
            Point1 = point;
        }

        public void AddPoint(Point point)
        {
            ListPoints.Add(point);
        }

        public void Save()
        {
            ListPoints.Add(Point1);
            ListPoints.Add(ListPoints[0]);
        }

        public bool IsSimpleShape()
        {
            return false;
        }

        public bool EndOfCurrentShape()
        {
            EndOfDrawing = true;
            return true;
        }
    }
    
    public class PolygonCreator : ICreator
    {
        public string Name
        {
            get
            {
                return "Многоугольник";
            }
        }
        
    }
    
    
    
    
}