using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Triangle : Shape
    {
        public string name { get; set; }
        public Color color { get; set; }
        public Location loc { get; set; }

        public void drawShape(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public void fillShape(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public double shapeArea()
        {
            throw new NotImplementedException();
        }

        public double shapePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
