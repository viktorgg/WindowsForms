using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    class CanvasManager
    {
        private static ListBox canvasList = new ListBox();
        private static List<Form2> canvases = new List<Form2>();
        private static int numIncrement = 1;

        public static void InitListBox(ListBox listBox)
        {
            canvasList = listBox;
        }

        public static void AddCanvas(Form2 form)
        {
            canvasList.Items.Add(form.name);
            canvases.Add(form);
            numIncrement++;
        }

        public static bool OpenCanvas()
        {
            string selectedCanvas = "";
            if (canvasList.SelectedItem != null)
            {
                selectedCanvas = canvasList.SelectedItem.ToString();
                Form2 form = canvases.Find(item => item.name.Equals(selectedCanvas));
                form.Show();
                form.restoreShapes();
                return true;
            }
            return false;
        }

        public static void RemoveCanvas()
        {
            string selectedCanvas = "";
            if (canvasList.SelectedItem != null)
            {
                selectedCanvas = canvasList.SelectedItem.ToString();
                Form2 canvas = canvases.Find(item => item.name.Equals(selectedCanvas));
                canvases.Remove(canvas);
                canvasList.Items.Remove(selectedCanvas);
            }
        }

        public static int GetNumIncrement()
        {
            return numIncrement;
        }
    }
}
