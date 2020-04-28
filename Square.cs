using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Square : Shape
    {
        public int height { get; set; }
        public string color { get; set; }
        public Location loc { get; set; }
        public int size { get; set; }

        public Square(int height, Location loc, string color)
        {
            this.height = height;
            this.loc = loc;
            this.color = color;
        }

        public virtual void drawShape()
        {
            //
        }
    }
}
