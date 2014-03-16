using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public class Line : ITool
    {
        public string[,] _canvas { get; set; }
        string[] _args;


        public Line(string[,] canvas, string [] args)
        {
            this._canvas = canvas;
            this._args = args;
        }

        public bool Validate()
        {
            return true;
        }

        public string[,] Create()
        {
            Coordinate start = new Coordinate(int.Parse(_args[1]), int.Parse(_args[2]));
            Coordinate end = new Coordinate(int.Parse(_args[3]), int.Parse(_args[4]));

            if (start.X != end.X && start.Y != end.Y)
            {
                Console.WriteLine("Only vertical or horizontal lines are supported");
            }
            else
            {
                if (start.Y == end.Y) //horizontal line
                {
                    if (start.X > end.X)// allow to draw lines backwords
                    {
                        int temp = end.X;
                        end.X = start.X;
                        start.X = temp;
                    }
                    for (int x = start.X; x <= end.X; x++)
                    {
                        _canvas[x, start.Y] = "x";
                    }
                }
                else //vertical line
                {
                    if (start.Y > end.Y)// allow to draw lines backwords
                    {
                        int temp = end.Y;
                        end.Y = start.Y;
                        start.Y = temp;
                    }
                    for (int y = start.Y; y <= end.Y; y++)
                    {
                        _canvas[start.X, y] = "x";
                    }
                }
            }
            return _canvas;
        }
    }
}
