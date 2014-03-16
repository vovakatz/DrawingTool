using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public class BucketFill : ITool
    {
        public string[,] _canvas { get; set; }
        string[] _args;
        Coordinate _pixel;
        string _color;

        public BucketFill(string[,] canvas, string[] args)
        {
            this._canvas = canvas;
            this._args = args;
        }

        public bool Validate()
        {
            if (_canvas.Length == 0)
                return false;
            if (_args.Length < 4)
                return false;
            int num;
            bool test = int.TryParse(_args[1], out num);
            if (test == false)
                return false;
            test = int.TryParse(_args[2], out num);
            if (test == false)
                return false;
            if (_args[3].Length > 1)
                return false;
            return true;
        }

        public string[,] Create()
        {
            _pixel = new Coordinate(int.Parse(_args[1]), int.Parse(_args[2]));
            _color = _args[3];
            DoBucketFill(_pixel, _color);
            return _canvas;
        }

        private void DoBucketFill(Coordinate pixel, string color)
        {
            string currentColor = _canvas[pixel.X, pixel.Y];
            _canvas[pixel.X, pixel.Y] = color;
            for (int x = pixel.X - 1; x <= pixel.X + 1; x++)
            {
                for (int y = pixel.Y - 1; y <= pixel.Y + 1; y++)
                {
                    if (_canvas[x, y] == currentColor)
                        DoBucketFill(new Coordinate(x, y), color);
                }
            }
        }
    }
}
