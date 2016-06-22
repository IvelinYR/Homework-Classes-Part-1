namespace PhoneComponents
{
    using System;
    using System.Text;

    public class Display
    {
        private int size;
        private int numberOfColors;

        public Display(int size, int numberOfColors)
        {
            this.numberOfColors = numberOfColors;
            this.size = size;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size must be positiv number");
                }
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Color must be positiv number");
                }
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            var infoDisplay = new StringBuilder();

            infoDisplay.AppendFormat("Size display: {0}\n", this.size);
            infoDisplay.AppendFormat("Number of color: {0}\n", this.numberOfColors);

            return infoDisplay.ToString();
        }
    }
}
