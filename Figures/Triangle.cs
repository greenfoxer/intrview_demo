namespace figures.Figures
{
    public class Triangle: AbstractFigure
    {
        public Point A { get; set;}
        public Point B { get; set;}
        public Point C { get; set;}
        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public override void Draw() 
        {
            System.Console.WriteLine($"Draw triangle with points: A=({A.X},{A.Y}) B = ({B.X},{B.Y}) C = ({C.X},{C.Y})");
        }
    }
}