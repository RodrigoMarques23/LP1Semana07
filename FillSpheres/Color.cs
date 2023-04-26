namespace FillSpheres
{
    public class Color
    {
        private readonly byte red;
        private readonly byte green;
        private readonly byte blue;
        private readonly byte alpha;

        public Color(byte Red, byte Green, byte Blue, byte Alpha)
        {
            red = Red;
            green = Green;
            blue = Blue;
            alpha = Alpha;
        }
        public Color(byte Red, byte Green, byte Blue)
        {
            red = Red;
            green = Green;
            blue = Blue;
            alpha = byte.MaxValue;
        }

        //Getters
        public byte GetRed()
        {
            return red;
        }
        public byte GetGreen()
        {
            return green;
        }
        public byte GetBlue()
        {
            return blue;
        }
        public byte GetAlpha()
        {
            return alpha;
        }

        //GrayScale
        public byte GetGrey()
        {
            int grey = (red + green + blue) / 3;
            return (byte)grey;
        }

        public override string ToString()
        {
            return $"Red: {red}, Green: {green}, Blue: {blue}, Alpha: {alpha} ";
        }

    }
}