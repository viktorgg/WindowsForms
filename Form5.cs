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
    public partial class Form5 : BaseFormProperties
    {
        public Form5(Shape shape) : base(shape)
        {
            InitializeComponent();
            Triangle oldTriangle = (Triangle)shape;
            textBox1.Text = oldTriangle.side.ToString();
            textBox4.Text = oldTriangle.loc.x.ToString();
            textBox3.Text = oldTriangle.loc.y.ToString();
            textBox2.Text = oldTriangle.angle.ToString();
            comboBox1.Text = oldTriangle.color.Name;
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            int side = int.Parse(textBox1.Text);
            Color color = Color.FromName(comboBox1.SelectedItem.ToString());
            Location newLoc = new Location(int.Parse(textBox4.Text), int.Parse(textBox3.Text));
            int angle = int.Parse(textBox2.Text);
            shape = new Triangle(shape.name, newLoc, color, side, angle);
            Close();
        }
    }
}
