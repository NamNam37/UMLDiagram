using System.Diagnostics;

namespace UMLdiagram
{
    public partial class Form1 : Form
    {
        public Diagram diagram { get; set; }
        private ClassModel? objSelected { get; set; }
        private bool isMoved { get; set; }
        private int relMousePosToObjX { get; set; }
        private int relMousePosToObjY { get; set; }

        public Form1()
        {
            InitializeComponent();
            diagram = new Diagram() { winWidth = this.pictureBox1.Width, winHeight = this.pictureBox1.Height };
            isMoved = false;
        }
        private void button_AddClass_Click(object sender, EventArgs e)
        {
            AddClassForm addClassForm = new AddClassForm();
            addClassForm.ShowDialog();
            if (addClassForm.DialogResult == DialogResult.OK)
            {
                diagram.AddClass(addClassForm.newClass);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            diagram.Draw(e.Graphics, objSelected);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            objSelected = diagram.CheckObjOnMouse(e.X, e.Y);
            if (objSelected != null)
            {
                isMoved = true;
                relMousePosToObjX = e.X - objSelected.X;
                relMousePosToObjY = e.Y - objSelected.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMoved = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoved)
                diagram.Move(objSelected, e.X, e.Y, relMousePosToObjX, relMousePosToObjY);
        }



        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Debug.WriteLine("Double Click");
        }

        private void button_RemoveClass_Click(object sender, EventArgs e)
        {
            if (objSelected != null)
            {
                diagram.RemoveClass(objSelected);
                objSelected = null; 
            }
        }
    }
}