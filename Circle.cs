using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Circle : Shape
    {
        public int radius { get; set; }
        public string color { get; set; }
        public Location loc { get; set; }
        public int size { get; set; }

        public Circle(int radius, Location loc, string color)
        {
            this.radius = radius;
            this.loc = loc;
            this.color = color;
        }

        public string drawShape()
        {
            return "Circle";
        }

        public int shapeArea()
        {
            throw new NotImplementedException();
        }
    }
}
