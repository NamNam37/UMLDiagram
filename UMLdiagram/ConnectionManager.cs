﻿using System;
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
        private Class? selectedClass1 { get; set; }
        private Class? selectedClass2 { get; set; }
        public List<ConnectionModel> connections { get; set; } = new List<ConnectionModel>();
        public bool AddToConnection(Class objSelected, ArrowDrawer.Type type)
        {
            if (selectedClass1 == null)
            {
                selectedClass1 = objSelected;
                return true;
            } else
            {
                selectedClass2 = objSelected;
                connections.Add(new ConnectionModel(selectedClass1, selectedClass2, type));
                
                selectedClass1 = null;
                selectedClass2 = null;
                return false;
            }
            
        }
    }
}