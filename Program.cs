using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolSelector.Classes;

namespace ToolSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            canvas.Click();
            canvas.ChangeTool(new Erase());
            canvas.Click();
            Console.ReadKey();
        }
    }
}
