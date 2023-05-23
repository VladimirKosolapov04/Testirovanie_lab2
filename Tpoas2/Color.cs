namespace Tpoas2
{
    public class Color
    {
        static void Main(string[] args)
        {
        }

        public double yarkost(int r, int g, int b)
        {
            if (r > 255) r = 255;
            if (g > 255) g = 255;
            if (b > 255) b = 255;
            if (r < 0) r = 0;
            if (g < 0) g = 0;
            if (b < 0) b = 0;
            return 0.3 * r + 0.59 * g + 0.11 * b;
        }
    }
}
