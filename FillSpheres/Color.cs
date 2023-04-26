namespace FillSpheres
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

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

        //Setters
        public void SetRed(byte Red)
        {
            this.red = Red;
        }
        public void SetGreen(byte Green)
        {
            this.green = Green;
        }
        public void SetBlue(byte Blue)
        {
            this.blue = Blue;
        }
        public void SetAlpha(byte Alpha)
        {
            this.alpha = Alpha;
        }

        //GrayScale
        public byte GetGrey()
        {
            int grey = (red + green + blue)/3;
            return (byte)grey;
        }

        public override string ToString()
        {
            return $"Red: {red}, Green: {green}, Blue: {blue}, Alpha: {alpha} ";
        }

    }
}