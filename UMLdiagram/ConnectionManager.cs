using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Drawers;
using UMLdiagram.Models;

namespace UMLdiagram
{
    public class ConnectionManager
    {
        private ClassModel? selectedClass1 { get; set; }
        private ClassModel? selectedClass2 { get; set; }
        public List<ConnectionModel> connections { get; set; } = new List<ConnectionModel>();
        public bool AddToConnection(ClassModel objSelected, ArrowDrawer.Type type)
        {
            if (selectedClass1 == null)
            {
                selectedClass1 = objSelected;
                return true;
            } else
            {
                selectedClass2 = objSelected;
                if (CheckConnectionDups())
                {
                    connections.Add(new ConnectionModel(selectedClass1, selectedClass2, type));
                }
                
                
                selectedClass1 = null;
                selectedClass2 = null;
                return false;
            }
            
        }

        private bool CheckConnectionDups()
        {
            foreach (ConnectionModel connection in connections)
            {
                if ((connection.class1 == selectedClass1 && connection.class2 == selectedClass2) || (connection.class1 == selectedClass2 && connection.class2 == selectedClass1))
                {
                    return false;
                }
            }
            return true;
        }

        public int GetConnectionRequirementReturn()
        {
            if (selectedClass1 == null)
            {
                return 1;
            }
            else 
            {
                return 2;
            }
        }
    }
}
