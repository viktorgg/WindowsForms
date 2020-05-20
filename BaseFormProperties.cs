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
    public partial class BaseFormProperties : Form
    {
        public Shape shape { get; set; }
        public string name;
        public Location loc;

        public BaseFormProperties()
        {
            InitializeComponent();
        }

        public BaseFormProperties(string name, Location loc)
        {
            InitializeComponent();
            this.name = name;
            this.loc = loc;
        }

        public virtual void button1_Click(object sender, EventArgs e) { }
    }
}
