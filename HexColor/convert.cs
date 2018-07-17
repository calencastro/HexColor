using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex_Color
{
    class convert
    {
        public string toHex(string Red, string Green, string Blue)
        {
            return "#" + Int32.Parse(Red).ToString("X2")
                + Int32.Parse(Green).ToString("X2")
                + Int32.Parse(Blue).ToString("X2");
             
        }

        public string[] todec(string hex)
        {
            string[] RGB = new string[3];
            int i = 0;
            int dec;
            for (int j = 1; j < hex.Length; j = j + 2)
            {
                dec = Convert.ToInt32(hex.Substring(j, 2), 16);
                RGB[i] = dec.ToString();
                i++;
            }
            return RGB;
        }

        public string[] toCMYK(string Red, string Green, string Blue)
        {
            string[] cmyk = new string[4];

            float R = float.Parse(Red)/255;
            float G = float.Parse(Green)/255;
            float B = float.Parse(Blue)/255;

            float K = 1 - Math.Max(R, Math.Max(G, B));
            float C = 0;
            float Y = 0;
            float M = 0;
            if(K != 1)
            {
                 C = ((1 - R - K) / (1 - K)) * 100;
                 Y = ((1 - G - K) / (1 - K)) * 100;
                 M = ((1 - B - K) / (1 - K)) * 100;
            }

            K = K * 100;

            
            cmyk[0] = C.ToString("n4");
            cmyk[1] = Y.ToString("n4");
            cmyk[2] = M.ToString("n4");
            cmyk[3] = K.ToString("n4");

            return cmyk;

        }


        public string[] fromCMYK(string Cyan, string Yellow, string Magent, string Black)
        {
            string[] RGB = new string[3];

            
            float K = float.Parse(Black) / 100;
            float C = float.Parse(Cyan) / 100;
            float Y = float.Parse(Yellow) / 100;
            float M = float.Parse(Magent) / 100;

            float R = 255 * (1 - C) * (1 - K);
            float G = 255 * (1 - M) * (1 - K);
            float B = 255 * (1 - Y) * (1 - K);

            RGB[0] = R.ToString("n0");
            RGB[1] = G.ToString("n0");
            RGB[2] = B.ToString("n0");
           
            return RGB;

        }


    }
}
