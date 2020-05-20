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
    enum AvailableShapes
    {
        None,
        Rectangle,
        Triangle,
        Circle
    }

    public partial class Form2 : Form
    {
        public string name { get; set; }
        private List<Shape> shapes;
        private int shapeNumIncrement;
        private AvailableShapes selectedShape;
        private Shape shapeToEdit;
        private Graphics graphics;
        private Form mainMenu;
        private Location loc;
        private bool canDraw;

        public Form2(Form mainMenu)
        {
            InitializeComponent();
            selectedShape = AvailableShapes.None;
            shapeToEdit = null;
            shapes = new List<Shape>();
            shapeNumIncrement = 1;
            name = "Canvas " + CanvasManager.GetNumIncrement();
            graphics = panel1.CreateGraphics();
            this.mainMenu = mainMenu;
            loc = new Location(0, 0);
            canDraw = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pick a position with mouse on canvas!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            selectedShape = AvailableShapes.Rectangle;
            canDraw = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pick a position with mouse on canvas!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            selectedShape = AvailableShapes.Circle;
            canDraw = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            Hide();
            selectedShape = AvailableShapes.None;
        }

        // Select a point at canvas for shape positioning
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (canDraw)
            {
                loc = new Location(e.X, e.Y);
                panel1_Paint(sender, null);
                canDraw = false;
            }
        }

        // Open Dialog for shape properties input and draw the shape
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (selectedShape.Equals(AvailableShapes.Rectangle))
            {
                string shapeName = "Shape" + shapeNumIncrement;
                Form3 form = new Form3(shapeName, loc);
                form.ShowDialog();

                if (form.shape != null)
                {
                    Rectangle rec = (Rectangle)form.shape;
                    rec.loc.x -= rec.width / 2;
                    rec.loc.y -= rec.height / 2;

                    addShape(rec);
                    rec.drawShape(graphics);
                    shapeNumIncrement++;
                }
            }
            else if (selectedShape.Equals(AvailableShapes.Circle))
            {
                string shapeName = "Shape" + shapeNumIncrement;
                Form4 form = new Form4(shapeName, loc);
                form.ShowDialog();

                if (form.shape != null)
                {
                    Circle circle = (Circle)form.shape;
                    circle.loc.x -= circle.diameter / 2;
                    circle.loc.y -= circle.diameter / 2;

                    addShape(circle);
                    circle.drawShape(graphics);
                    shapeNumIncrement++;
                }
            }
        }

        // Draws all shapes that should be on canvas
        public void restoreShapes()
        {
            foreach (Shape shape in shapes)
            {
                shape.drawShape(graphics);
            }
        }

        // Select a shape form list of drawn items
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedItem = "";
            if (listBox1.SelectedItem != null)
            {
                refreshCanvas();
                selectedItem = listBox1.SelectedItem.ToString();
                Shape shape = shapes.Find(item => item.name.Equals(selectedItem));
                shape.fillShape(graphics);
                shapeToEdit = shape;
            }
        }

        private void addShape(Shape shape)
        {
            shapes.Add(shape);
            listBox1.Items.Add(shape.name);
        }
        private void removeShape(Shape shape)
        {
            shapes.Remove(shape);
            listBox1.Items.Remove(shape.name);
        }

        private void refreshCanvas()
        {
            selectedShape = AvailableShapes.None;
            Hide();
            Show();
            restoreShapes();
        }

        // Select the 'Edit' button
        private void button2_Click(object sender, EventArgs e)
        {
            if (shapeToEdit is Rectangle)
            {
                Form3 form = new Form3(shapeToEdit.name, shapeToEdit.loc);
                form.ShowDialog();
                shapes.Remove(shapeToEdit);
                shapes.Add(form.shape);
                refreshCanvas();
                shapeToEdit = null;
            }
            else if (shapeToEdit is Circle)
            {
                Form4 form = new Form4(shapeToEdit.name, shapeToEdit.loc);
                form.ShowDialog();
                shapes.Remove(shapeToEdit);
                shapes.Add(form.shape);
                refreshCanvas();
                shapeToEdit = null;
            }
        }

        // Select the 'X' button to remove shape
        private void button6_Click(object sender, EventArgs e)
        {
            if (shapeToEdit != null)
            {
                removeShape(shapeToEdit);
                refreshCanvas();
                shapeToEdit = null;
            }
        }

        // Select the 'Area' button to get area of shape
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Round(shapeToEdit.shapeArea(), 3).ToString(), "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Select the 'P' button to get perimeter of shape
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Round(shapeToEdit.shapePerimeter(), 3).ToString(), "Perimeter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Select the 'Clear Canvas' button to clear all drawings
        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Shape shape in shapes.ToArray())
            {
                removeShape(shape);
            }
            selectedShape = AvailableShapes.None;
            Hide();
            Show();
        }
    }
}
