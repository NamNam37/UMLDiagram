using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Models;

namespace UMLdiagram
{
    public class ConnectionManager
    {
        private Class? selectedClass1 { get; set; }
        private Class? selectedClass2 { get; set; }
        public List<ConnectionModel> connections { get; set; } = new List<ConnectionModel>();
        public bool AddToConnection(Class objSelected)
        {
            if (selectedClass1 == null)
            {
                selectedClass1 = objSelected;
                return true;
            } else
            {
                selectedClass2 = objSelected;
                connections.Add(new ConnectionModel(selectedClass1, selectedClass2, ArrowDrawer.Type.diamond));
                
                selectedClass1 = null;
                selectedClass2 = null;
                return false;
            }
            
        }
    }
}
