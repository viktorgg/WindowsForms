using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Triangle : Shape
    {
        private Location firstAngle { get; set; }
        private Location secondAngle { get; set; }
        private Location thirdAngle { get; set; }
        public string name { get; set; }
        public Color color { get; set; }
        public Location loc { get; set; }
        public int side { get; set; }
        public int angle { get; set; }

        public Triangle(string name, Location loc, Color color, int side, int angle)
        {
            this.name = name;
            this.loc = loc;
            this.color = color;
            this.side = side;
            this.angle = angle;
            firstAngle = new Location(loc.x - side / 2, loc.y + side / 2);
            secondAngle = new Location(loc.x + side / 2, loc.y + side / 2);
            thirdAngle = new Location(loc.x, loc.y - side / 2);
        }

        public void drawShape(Graphics graphics)
        {
            Pen pen = new Pen(color, 3);
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(loc.x, loc.y));
                graphics.Transform = m;
                graphics.DrawPolygon(pen, configurePoints());
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
                graphics.FillPolygon(brush, configurePoints());
                graphics.ResetTransform();
            }
        }

        public double shapeArea()
        {
            int h = firstAngle.y - thirdAngle.y;
            return side * h / 2;
        }

        public double shapePerimeter()
        {
            return side * 3;
        }

        private PointF[] configurePoints()
        {
            PointF angle = new PointF(firstAngle.x, firstAngle.y);
            PointF angle2 = new PointF(secondAngle.x, secondAngle.y);
            PointF angle3 = new PointF(thirdAngle.x, thirdAngle.y);
            PointF[] curvePoints = { angle, angle2, angle3 };
            return curvePoints;
        }
    }
}
