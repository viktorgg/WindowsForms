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
    public partial class Form3 : BaseFormProperties
    {
        public Form3(Shape shape) : base(shape)
        {
            InitializeComponent();
            Rectangle oldRec = (Rectangle)shape;
            textBox1.Text = oldRec.width.ToString();
            textBox2.Text = oldRec.height.ToString();
            textBox4.Text = oldRec.loc.x.ToString();
            textBox3.Text = oldRec.loc.y.ToString();
            textBox5.Text = oldRec.angle.ToString();
            comboBox1.Text = oldRec.color.Name;
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            int width = int.Parse(textBox1.Text);
            int height = int.Parse(textBox2.Text);
            Color color = Color.FromName(comboBox1.SelectedItem.ToString());
            Location loc = new Location(int.Parse(textBox4.Text), int.Parse(textBox3.Text));
            int angle = int.Parse(textBox5.Text);
            shape = new Rectangle(shape.name, loc, width, height, color, angle);
            Close();
        }
    }
}
