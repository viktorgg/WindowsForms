using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CourseProject
{
    public interface Shape
    {
        string name { get; set; }
        Color color { get; set; }
        Location loc { get; set; }
        double shapeArea();
        double shapePerimeter();
        void drawShape(Graphics graphics);
        void fillShape(Graphics graphics);
    }
}
