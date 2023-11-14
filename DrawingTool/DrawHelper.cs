using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this is a helper.
namespace DrawingTool
{
    public class DrawHelper
    {
        public static void DisplayDrawing(string[,] canvas)
        {
            int width = canvas.GetLength(0);
            int height = canvas.GetLength(1);

            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    Console.Write(canvas[w, h]);
                }
                Console.WriteLine();
            }
        }
    }
}
