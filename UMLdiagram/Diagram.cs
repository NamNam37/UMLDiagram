using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagram
{
    public class Diagram
    {
        public int winWidth { get; set; }
        public int winHeight { get; set; }
        public List<ClassModel> classes = new List<ClassModel>();

        public void AddClass(ClassModel addClass)
        {
            classes.Add(addClass);
        }
        public void RemoveClass(ClassModel objSelected)
        {
            classes.Remove(objSelected);
            
        }
        public void Draw(Graphics g, ClassModel objSelected)
        {
            foreach (var item in classes)
            {
                item.Draw(g);

                if (objSelected != null)
                    objSelected.DrawSelection(g);
            }
        }
        public void Move(ClassModel objSelected, int mouseX, int mouseY, int relMousePosToObjX, int relMousePosToObjY)
        {
            objSelected.Move(mouseX, mouseY, relMousePosToObjX, relMousePosToObjY);
        }
        public ClassModel? CheckObjOnMouse(int mouseX, int mouseY)
        {
            foreach (var item in classes)
            {
                int itemEndX = item.X + item.width;
                int itemEndY = item.Y + item.height;
                if (mouseX >= item.X & mouseX <= itemEndX & mouseY >= item.Y & mouseY <= itemEndY)
                {
                    return item;
                }
                
            }
            return null;
        }
    }
}
