using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Threading;
using UMLdiagram.Drawers;

namespace UMLdiagram
{
    public partial class Form1 : Form
    {
        public Diagram diagram { get; set; }
        public ConnectionManager connectionManager { get; set; }
        private Class? objSelected { get; set; }
        private bool isMoved { get; set; }
        private int relMousePosToObjX { get; set; }
        private int relMousePosToObjY { get; set; }
        private bool connectSelectMode { get; set; }
        public Form1()
        {
            InitializeComponent();
            diagram = new Diagram() { winWidth = this.pictureBox1.Width, winHeight = this.pictureBox1.Height };
            connectionManager = new ConnectionManager();
            isMoved = false;
            comboBox_ArrowType.Text = "Association";
            Class class1 = new Class() { name = "test", X = 20, Y = 50 };
            Class class2 = new Class() { name = "test2", X = 200, Y = 50 };
            diagram.AddClass(class1);
            diagram.AddClass(class2);
        }
        private void button_AddClass_Click(object sender, EventArgs e)
        {
            AddClassForm addClassForm = new AddClassForm();
            addClassForm.ShowDialog();
            if (addClassForm.DialogResult == DialogResult.OK)
            {
                diagram.AddClass(addClassForm.classMaker.newClass);
                objSelected = null;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, pictureBox1.Size.Width-1, pictureBox1.Size.Height-1);
            diagram.Draw(e.Graphics, objSelected);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LeftClick(e.X, e.Y);
            }
            
        }
        private void LeftClick(int mouseX, int mouseY)
        {
            objSelected = diagram.CheckObjOnMouse(mouseX, mouseY);
            if (objSelected != null)
            {
                if (!connectSelectMode)
                {
                        isMoved = true;
                        relMousePosToObjX = mouseX - objSelected.X;
                        relMousePosToObjY = mouseY - objSelected.Y;
                  
                }
                else
                {
                    connectSelectMode = connectionManager.AddToConnection(objSelected, ConvertArrTypeToEnum());
                }
            }
            
        }
        private ArrowDrawer.Type ConvertArrTypeToEnum()
        {
            if (comboBox_ArrowType.Text == "Association")
            {
                return ArrowDrawer.Type.none;
            }
            if (comboBox_ArrowType.Text == "Unidir. Association")
            {
                return ArrowDrawer.Type.classic;
            }
            if (comboBox_ArrowType.Text == "Inheritance" || comboBox_ArrowType.Text == "Generalization")
            {
                return ArrowDrawer.Type.triangle;
            }
            if (comboBox_ArrowType.Text == "Realization")
            {
                return ArrowDrawer.Type.triangleDotdash;
            }
            if (comboBox_ArrowType.Text == "Dependency" || comboBox_ArrowType.Text == "Abstraction" || comboBox_ArrowType.Text == "Substitution" || comboBox_ArrowType.Text == "Usage")
            {
                return ArrowDrawer.Type.classicDotdash;
            }
            if (comboBox_ArrowType.Text == "Aggregation")
            {
                return ArrowDrawer.Type.diamondEmpty;
            }
            if (comboBox_ArrowType.Text == "Composiotion")
            {
                return ArrowDrawer.Type.diamond;
            }
            return ArrowDrawer.Type.none;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMoved = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();

            if (isMoved)
                diagram.Move(objSelected, e.X, e.Y, relMousePosToObjX, relMousePosToObjY);
        }

        private void button_RemoveClass_Click(object sender, EventArgs e)
        {
            if (objSelected != null)
            {
                diagram.RemoveClass(objSelected);
                objSelected = null; 
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Class? editedClass = diagram.CheckObjOnMouse(e.X, e.Y);
            if (editedClass != null)
            {
                EditClass(editedClass);
            }
        }

        private void button_EditClass_Click(object sender, EventArgs e)
        {
            if (objSelected != null)
            {
                EditClass(objSelected);
            }
        }
        private void EditClass(Class editedClass)
        {
            AddClassForm addClassForm = new AddClassForm(editedClass);
            addClassForm.ShowDialog();
            diagram.Modify(editedClass, addClassForm.classMaker.newClass);           
        }

        private void button_ClearPicbox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all \ncurrent classes on the diagram?", "Clear ALL",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                diagram.DeleteAll();
            }

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            connectSelectMode = true;
            diagram.SetConnection(connectionManager.connections);
        }

        private void button_RemoveConnection_Click(object sender, EventArgs e)
        {

        }
        /*
cara - asociace
sipka - jednosmerna-asociace
trojuhelnik - dědičnost generalizace
cerchovana sipka a trojuhelnik - realizace
cerchovana cara a sipka - dependence abstrakce substituce pouziti
prazdnej diamant - agregace
diamant - kompozice
*/
    }
}
