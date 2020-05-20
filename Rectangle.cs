using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Rectangle : Shape
    {
        public int height { get; set; }
        public int width { get; set; }
        public string name { get; set; }
        public Color color { get; set; }
        public Location loc { get; set; }

        public Rectangle(string name, Location loc, int width, int height, Color color)
        {
            this.name = name;
            this.height = height;
            this.width = width;
            this.loc = loc;
            this.color = color;
        }

        public void drawShape(Graphics graphics)
        {
            Pen pen = new Pen(color, 3);
            graphics.DrawRectangle(pen, loc.x, loc.y, width, height);
        }

        public void fillShape(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.White);
            graphics.FillRectangle(brush, loc.x, loc.y, width, height);
        }

        public double shapeArea()
        {
            return height * width;
        }

        public double shapePerimeter()
        {
            return (height + width) * 2;
        }
    }
}
