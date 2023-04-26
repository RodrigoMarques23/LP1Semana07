namespace FillSpheres
{
    public class Color
    {

        public byte red { get; set; }
        public byte green { get; set; }
        public byte blue { get; set; }
        public byte alpha { get; set; }

        public string color  
        {
            get
            {
                return this switch
                {
                    null => "No Color",
                    { red: 255, green: 0, blue: 0 } => "Red 100%",
                    { red: 0, green: 255, blue: 0 } => "Green 100%",
                    { red: 0, green: 0, blue: 255 } => "Blue 100%",
                    _ => "Mixed Color"
                };

            }
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