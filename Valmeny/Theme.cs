using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Valmeny
{
    public class Theme
    {
        public Theme() { }
        public Theme(string name, Color backColour, Color foreColor, Color textColor)
        {
            colours = new Color[3];
            colours[0] = backColour;
            colours[1] = foreColor;
            colours[2] = textColor;
            visibleName = name;
        }
        public string visibleName { get; set; }
        public Color[] colours { get; set; }
    }
}
