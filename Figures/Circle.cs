namespace figures.Figures
{
    public class Circle: AbstractFigure
    {
        //Cords of circle center and radius
        public Point C { get; set;}
        public int R { get; set;}

        public Circle(Point center, int r)
        {
            this.C = center;
            this.R = r;
        }
        public override void Draw()
        {
            System.Console.WriteLine($"Draw circle with center in ({C.X},{C.Y}) and Radius = {R}");
        }
    }
}