using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseProject
{
    class SaveFileManager
    {
        static XmlSerializer recSerializer = new XmlSerializer(typeof(Rectangle));
        static XmlSerializer circleSerializer = new XmlSerializer(typeof(Circle));
        static XmlSerializer triangleSerializer = new XmlSerializer(typeof(Triangle));

        static TextWriter recTxtWriter = new StreamWriter("./Rectangles.xml");
        static TextWriter circleTxtWriter = new StreamWriter("./Circles.xml");
        static TextWriter triangleTxtWriter = new StreamWriter("./Triangles.xml");
        public static void serializeShape(Shape shape)
        {
            if (shape is Rectangle)
            {
                recSerializer.Serialize(recTxtWriter, shape);
            }
            else if (shape is Circle)
            {
                circleSerializer.Serialize(circleTxtWriter, shape);
            }
            else
            {
                triangleSerializer.Serialize(triangleTxtWriter, shape);
            }
        }
        public static void deserializeShapes()
        {
            if (shape is Rectangle)
            {
                recSerializer.Serialize(recTxtWriter, shape);
            }
            else if (shape is Circle)
            {
                circleSerializer.Serialize(circleTxtWriter, shape);
            }
            else
            {
                triangleSerializer.Serialize(triangleTxtWriter, shape);
            }
        }
    }
}
