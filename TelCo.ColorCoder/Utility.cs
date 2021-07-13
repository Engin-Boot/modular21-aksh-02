using System.Drawing;
using System;

namespace TelCo.ColorCoder
{
    class Utility
    {
        public static int GetIndex(Color[] colorMap, Color color)
        {
            int index = -1;
            for (int i = 0; i < colorMap.Length; i++)
            {
                if (colorMap[i] == color)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
