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
    public partial class Form4 : BaseFormProperties
    {
        public Form4(Shape shape) : base(shape)
        {
            InitializeComponent();
            Circle oldCircle = (Circle)shape;
            textBox1.Text = oldCircle.diameter.ToString();
            textBox2.Text = oldCircle.loc.x.ToString();
            textBox3.Text = oldCircle.loc.y.ToString();
            comboBox1.Text = oldCircle.color.Name;
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            int diamater = int.Parse(textBox1.Text);
            Color color = Color.FromName(comboBox1.SelectedItem.ToString());
            Location newLoc = new Location(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            shape = new Circle(shape.name, newLoc, diamater, color);
            Close();
        }
    }
}
