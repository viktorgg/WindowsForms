using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public int angle { get; set; }

        public Rectangle(string name, Location loc, int width, int height, Color color, int angle)
        {
            this.name = name;
            this.height = height;
            this.width = width;
            this.loc = loc;
            this.color = color;
            this.angle = angle;
        }

        public void drawShape(Graphics graphics)
        {

            Pen pen = new Pen(color, 3);
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(loc.x, loc.y));
                graphics.Transform = m;
                graphics.DrawRectangle(pen, loc.x - width / 2, loc.y - height / 2, width, height);
                graphics.ResetTransform();
            }
        }

        public void fillShape(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.White);
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(loc.x, loc.y));
                graphics.Transform = m;
                graphics.FillRectangle(brush, loc.x - width / 2, loc.y - height / 2, width, height);
                graphics.ResetTransform();
            }
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
