using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Circle : Shape
    {
        public string name { get; set; }
        public int diameter { get; set; }
        public Color color { get; set; }
        public Location loc { get; set; }

        public Circle(string name, Location loc, int diameter, Color color)
        {
            this.name = name;
            this.diameter = diameter;
            this.loc = loc;
            this.color = color;
        }

        public void drawShape(Graphics graphics)
        {
            Pen pen = new Pen(color, 3);
            graphics.DrawEllipse(pen, loc.x, loc.y, diameter, diameter);
        }

        public void fillShape(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.White);
            graphics.FillEllipse(brush, loc.x, loc.y, diameter, diameter);
        }

        public double shapeArea()
        {
            int radius = diameter / 2;
            return Math.PI * radius * radius;
        }

        public double shapePerimeter()
        {
            int radius = diameter / 2;
            return 2 * Math.PI * radius;

        }
    }
}
