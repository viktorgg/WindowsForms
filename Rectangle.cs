using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Rectangle : Square
    {
        public int width { get; set; }
        public Rectangle(int height, int width, Location loc, string color) : base(height, loc, color)
        {
            this.height = height;
            this.width = width;
            this.loc = loc;
            this.color = color;
        }

        public override void drawShape()
        {
            //
        }
    }
}
