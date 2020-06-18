namespace figures.Figures
{
    public class Point : AbstractFigure
    {
        public int X { get; set;}
        public int Y { get; set;}

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Draw()
        {
            System.Console.WriteLine($"Draw single point on ({X},{Y})");
        }
    }
}