using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CourseProject
{
    interface Shape
    {
        string color { get; set; }
        Location loc { get; set; }
        int size { get; set; }
        void drawShape();
    }
}
