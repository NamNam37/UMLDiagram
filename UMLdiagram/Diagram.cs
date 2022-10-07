using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Models;

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
        public void Modify(ClassModel objSelected, ClassModel newClass)
        {
            classes.Remove(objSelected);
            classes.Add(newClass);
        }
        public void DeleteAll()
        {
            classes = new List<ClassModel>();
        }
        public ClassModel? CheckObjOnMouse(int mouseX, int mouseY)
        {
            for (int i = classes.Count - 1; i >= 0; i--)
            {
                var item = classes[i];
                int itemEndX = item.X + item.width;
                int itemEndY = item.Y + item.height;
                if (mouseX >= item.X & mouseX <= itemEndX & mouseY >= item.Y & mouseY <= itemEndY)
                {
                    classes.Remove(item);
                    classes.Add(item);
                    return item;
                }
            }
            /*foreach (var item in classes)
            {
                int itemEndX = item.X + item.width;
                int itemEndY = item.Y + item.height;
                if (mouseX >= item.X & mouseX <= itemEndX & mouseY >= item.Y & mouseY <= itemEndY)
                {
                    classes.Remove(item);
                    classes.Add(item);
                    return item;
                }
                
            }*/
            return null;
        }
    }
}
