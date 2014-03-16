using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] canvas = new string [0,0];
            bool quit = false;
            ITool tool = null;

            while (!quit)
            {
                System.Console.Write("enter command: ");
                string line;
                while ((line = System.Console.ReadLine().Trim()) == "") ;
                args = line.Split(' ');
                switch (args[0].ToUpper())
                {
                    case "C":
                        tool = new CanvasArea(canvas, args);
                        break;
                    case "L":
                        tool = new Line(canvas, args);
                        break;
                    case "R":
                        tool = new Rectangle(canvas, args);
                        break;
                    case "B":
                        tool = new BucketFill(canvas, args);
                        break;
                    case "Q":
                        quit = true;
                        break;
                    default:
                        System.Console.WriteLine("you entered invalid command");
                        tool = null;
                        break;
                }

                if (tool != null)
                {
                    if (tool.Validate())
                    {
                        canvas = tool.Create();
                        DrawHelper.DisplayDrawing(canvas);
                    }
                }
            }
        }
    }
}
