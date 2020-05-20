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
        public Form3(string name, Location loc) : base(name, loc)
        {
            InitializeComponent();
            textBox4.Text = loc.x.ToString();
            textBox3.Text = loc.y.ToString();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            int width = int.Parse(textBox1.Text);
            int height = int.Parse(textBox2.Text);
            Color color = Color.FromName(comboBox1.SelectedItem.ToString());
            Location newLoc = new Location(int.Parse(textBox4.Text), int.Parse(textBox3.Text));
            shape = new Rectangle(name, newLoc, width, height, color);
            Close();
        }
    }
}
