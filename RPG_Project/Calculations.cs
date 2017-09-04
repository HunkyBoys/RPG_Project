using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class Calculations
    {
            public static Random r = new Random(DateTime.Now.Millisecond);


            //generate a random color
            public static Color RandomColor()
            {

                byte red = (byte)r.Next(0, 255);
                byte green = (byte)r.Next(0, 255);
                byte blue = (byte)r.Next(0, 255);

                return new Color(red, green, blue);
            }
            
            //convert a texture2d to readable color array
            public static Color[,] TextureTo2DArray(Texture2D texture)
            {
            Color[] colorsOne = new Color[texture.Width * texture.Height]; //The hard to read,1D array
            texture.GetData(colorsOne); //Get the colors and add them to the array

            Color[,] colorsTwo = new Color[texture.Width, texture.Height]; //The new, easy to read 2D array
            for (int x = 0; x < texture.Width; x++) //Convert!
                for (int y = 0; y < texture.Height; y++)
                    colorsTwo[x, y] = colorsOne[x + y * texture.Width];

            return colorsTwo; //Done!
            }
    }
}

