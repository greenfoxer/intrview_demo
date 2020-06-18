using System;
using figures.Figures;

namespace figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(4,5);
            point.Draw();
            AbstractFigure figure = new Circle(point, 10);
            figure.Draw();
            figure = new Triangle(point, new Point(0,0), new Point(3,10));
            figure.Draw();
        }
    }
}
