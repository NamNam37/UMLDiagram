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
        public List<ClassModel> classes = new List<ClassModel>();
        public List<ConnectionModel> connections = new List<ConnectionModel>();

        public void AddClass(ClassModel addClass)
        {
            classes.Add(addClass);
        }
        public void SetConnection(List<ConnectionModel> connections)
        {
            this.connections = connections;
        }
        public void RemoveClass(ClassModel objSelected)
        {
            classes.Remove(objSelected);
            
        }
        public void Draw(Graphics g, ClassModel objSelected)
        {
            foreach (var item in classes)
            {
                new ClassDrawer(item).DrawShadow(g);
            }

            new ConnectionDrawer(g).Draw(connections);

            foreach (var item in classes)
            {
                new ClassDrawer(item).Draw(g);

                if (objSelected != null)
                    new ClassDrawer(objSelected).DrawSelection(g);
            }
            
        }
        public void Move(ClassModel objSelected, int mouseX, int mouseY, int relMousePosToObjX, int relMousePosToObjY)
        {
            new ClassDrawer(objSelected).Move(mouseX, mouseY, relMousePosToObjX, relMousePosToObjY);
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
            return null;
        }

        public void RemoveConnectionOnMouse(int x, int y)
        {
            ConnectionModel? connection = new ConnectionDrawer().CheckObj(connections, x, y);
            if (connection != null)
            {
                connections.Remove(connection);
            }
        }
    }
}
