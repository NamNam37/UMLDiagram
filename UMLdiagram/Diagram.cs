using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Drawers;
using UMLdiagram.Models;

namespace UMLdiagram
{
    public class Diagram
    {
        public int winWidth { get; set; }
        public int winHeight { get; set; }
        public List<Class> classes = new List<Class>();
        public List<ConnectionModel> connections = new List<ConnectionModel>();

        public void AddClass(Class addClass)
        {
            classes.Add(addClass);
        }
        public void SetConnection(List<ConnectionModel> connections)
        {
            this.connections = connections;
        }
        public void RemoveClass(Class objSelected)
        {
            classes.Remove(objSelected);
            
        }
        public void Draw(Graphics g, Class objSelected)
        {
            foreach (var item in classes)
            {
                item.DrawShadow(g);
            }

            new ConnectionDrawer(g).Draw(connections);

            foreach (var item in classes)
            {
                item.Draw(g);

                if (objSelected != null)
                    objSelected.DrawSelection(g);
            }
            
        }
        public void Move(Class objSelected, int mouseX, int mouseY, int relMousePosToObjX, int relMousePosToObjY)
        {
            objSelected.Move(mouseX, mouseY, relMousePosToObjX, relMousePosToObjY);
        }
        public void Modify(Class objSelected, Class newClass)
        {
            classes.Remove(objSelected);
            classes.Add(newClass);
        }
        public void DeleteAll()
        {
            classes = new List<Class>();
        }
        public Class? CheckObjOnMouse(int mouseX, int mouseY)
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
            return null;
        }

        public void CheckConnectionOnMouse(int x, int y)
        {
            new ConnectionDrawer().CheckObj(connections, x, y);
        }
    }
}
