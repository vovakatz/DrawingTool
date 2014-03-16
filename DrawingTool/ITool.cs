using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public interface ITool
    {
        bool Validate();
        string[,] Create();
    }
}
