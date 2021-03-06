﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public class Rectangle : ITool
    {
        public string[,] _canvas;
        string[] _args;


        public Rectangle(string[,] canvas, string[] args)
        {
            this._canvas = canvas;
            this._args = args;
        }

        public bool Validate()
        {
            if (_canvas.Length == 0)
                return false;
            if (_args.Length < 5)
                return false;
            int num;
            bool test = int.TryParse(_args[1], out num);
            if (test == false)
                return false;
            test = int.TryParse(_args[2], out num);
            if (test == false)
                return false;
            test = int.TryParse(_args[3], out num);
            if (test == false)
                return false;
            test = int.TryParse(_args[4], out num);
            if (test == false)
                return false;
            return true;
        }

        public string[,] Create()
        {
            Line line = new Line(_canvas, new string[] { _args[0], _args[1], _args[2], _args[3], _args[2] });
            line.Create();
            line = new Line(_canvas, new string[] { _args[0], _args[3], _args[2], _args[3], _args[4] });
            line.Create();
            line = new Line(_canvas, new string[] { _args[0], _args[1], _args[2], _args[1], _args[4] });
            line.Create();
            line = new Line(_canvas, new string[] { _args[0], _args[1], _args[4], _args[3], _args[4] });
            line.Create();
            return _canvas;
        }
    }
}
