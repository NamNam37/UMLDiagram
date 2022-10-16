﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Drawers;

namespace UMLdiagram.Models
{
    public class ConnectionModel
    {
        public Class class1 { get; set; }
        public Class class2 { get; set; }
        public ArrowDrawer.Type type { get; set; }
        public int class1Count { get; set; } = 0;
        public int class2Count { get; set; }= 0;
        public ConnectionModel(Class class1, Class class2, ArrowDrawer.Type type)
        {
            this.class1 = class1;
            this.class2 = class2;
            this.type = type;
        }
    }
}
