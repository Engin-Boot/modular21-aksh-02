using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    class ColorManual
    {
        public static void PrintManual()
        {
            Console.WriteLine("\nMajor Color Manual");
            int majLength = ColorMap.colorMapMajor.Length;
            int minLength = ColorMap.colorMapMinor.Length;
            for (int i = 0; i < majLength; i++)
            {
                Console.WriteLine("{0} : {1}", i, ColorMap.colorMapMajor[i]);
            }

            Console.WriteLine("\nMinor Color Manual");
            for (int i = 0; i < minLength; i++)
            {
                Console.WriteLine("{0} : {1}", i, ColorMap.colorMapMinor[i]);
            }
        }
    }
}
