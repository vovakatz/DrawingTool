using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public class CanvasArea : ITool
    {
        string[,] _canvas;
        string[] _args;

        public CanvasArea(string[,] canvas, string[] args)
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
            _canvas = new string[int.Parse(_args[1]) + 2, int.Parse(_args[2]) + 2];
            int width = _canvas.GetLength(0);
            int height = _canvas.GetLength(1);

            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    if (h == 0)
                        _canvas[w, h] = "-";
                    else if (h == height - 1)
                        _canvas[w, h] = "-";
                    else if (w == 0 || w == width - 1)
                        _canvas[w, h] = "|";
                    else
                        _canvas[w, h] = " ";
                }
            }
            return _canvas;
        }
    }
}
