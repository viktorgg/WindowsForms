using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location loc = new Location(5, 10);
            Shape rec = new Rectangle(1, 1, loc, "Blue");
            shapes.Add(rec);
            MessageBox.Show(rec.drawShape());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Location loc = new Location(5, 10);
            Shape square = new Square(1, loc, "Blue");
            shapes.Add(square);
            MessageBox.Show(square.drawShape());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Location loc = new Location(5, 10);
            Shape circle = new Circle(1, loc, "Blue");
            shapes.Add(circle);
            MessageBox.Show(circle.drawShape());
        }
    }
}
