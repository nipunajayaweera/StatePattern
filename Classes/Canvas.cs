using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolSelector.Interfaces;

namespace ToolSelector.Classes
{
    public class Canvas
    {
        public ITool SelectedTool { get; set; }

        public Canvas()
        {
            SelectedTool = new Brush();
        }

        public void ChangeTool(ITool tool)
        {
            SelectedTool = tool;
        }

        public void Click()
        {
            Console.WriteLine(SelectedTool.Click());
        }


    }
}
