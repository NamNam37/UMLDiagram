using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Drawers;
using UMLdiagram.Models;
using UMLdiagram.Utilities;

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
        public void EditClass(ClassModel editedClass)
        {
            AddClassForm addClassForm = new AddClassForm(editedClass);
            addClassForm.ShowDialog();
            classes.Remove(editedClass);
            classes.Add(addClassForm.classMaker.newClass);
        }
        public void SetConnection(List<ConnectionModel> connections)
        {
            this.connections = connections;
        }
        public void RemoveClass(ClassModel classSelected)
        {
            classes.Remove(classSelected);
            RemoveRelatedConnectionsToRemovedClass(classSelected);
            
        }
        private void RemoveRelatedConnectionsToRemovedClass(ClassModel classSelected)
        {
            List<ConnectionModel> connectionsToRemove = new List<ConnectionModel>();
            foreach (ConnectionModel connection in connections)
            {
                if (connection.class1.name == classSelected.name || connection.class2.name == classSelected.name)
                {
                    connectionsToRemove.Add(connection);
                }
            }
            foreach (ConnectionModel connection in connectionsToRemove)
            {
                connections.Remove(connection);
            }
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
        public void DeleteAll()
        {
            classes = new List<ClassModel>();
            connections = new List<ConnectionModel>();
        }
        public ClassModel? CheckClassOnMouse(int mouseX, int mouseY)
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

        public DialogResult NewClassDialog()
        {
            AddClassForm addClassForm = new AddClassForm();
            addClassForm.ShowDialog();
            if (addClassForm.DialogResult == DialogResult.OK)
            {
                AddClass(addClassForm.classMaker.newClass);
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }

        public void Save(string savePath)
        {
            JsonFileUtility jsonFileUtility = new JsonFileUtility();
            List<object> jsonList = new List<object>() { classes, connections };
            jsonFileUtility.SaveList(jsonList, savePath);
        }

        public void Load(string loadPath)
        {
            JsonFileUtility jsonFileUtility = new JsonFileUtility();
            JArray? jsonList = jsonFileUtility.ReadList(loadPath);
            if (jsonList != null)
            {
                classes = jsonList[0].ToObject<List<ClassModel>>();
                connections = jsonList[1].ToObject<List<ConnectionModel>>();
            }
            JoinClassesToConnections();
        }
        private void JoinClassesToConnections()
        {
            foreach (ConnectionModel connection in connections)
            {
                foreach (ClassModel classModel in classes)
                {
                    if (connection.class1.name == classModel.name)
                    {
                        connection.class1 = classModel;
                    }
                    else if (connection.class2.name == classModel.name)
                    {
                        connection.class2 = classModel;
                    }
                }
            }
        }

        public void GenerateCode()
        {
            throw new NotImplementedException();
        }
    }
}
