using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolSelector.Interfaces;

namespace ToolSelector.Classes
{
    public class Brush : ITool
    {
        public string Click()
        {
            return "Draw a line";
        }
    }
}
