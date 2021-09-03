using System;
using System.Drawing;

namespace ShapesInterface
{
    public interface IShape
    {
        void Initialization(Point _point, int _thickness, Color _colorRound, Color _colorFill);
        void Draw(Graphics _graphics);
        void SetPoint(Point _point);
        
        void AddPoint(Point point);
        
        bool IsSimpleShape();

        bool EndOfCurrentShape();

    }
    
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class PluginAttribute : Attribute
    {
        private string _Name;
        public PluginAttribute(string name) { _Name = name; }
        public string Name { get { return _Name; } }
    };
    
    public interface ICreator
    {
        string Name { get; }
    }
}