using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorMap
    {
        public static readonly Color[] colorMapMajor;
        public static readonly Color[] colorMapMinor;

        static ColorMap()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > colorMapMinor.Length * colorMapMajor.Length)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            return new ColorPair()
            {
                majorColor = colorMapMajor[(pairNumber-1)/colorMapMajor.Length],
                minorColor = colorMapMinor[(pairNumber-1)%colorMapMinor.Length]
            };
        }

        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = Utility.GetIndex(colorMapMajor, pair.majorColor);
            int minorIndex = Utility.GetIndex(colorMapMinor, pair.minorColor);

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
