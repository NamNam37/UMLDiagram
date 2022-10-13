using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagram.Models
{
    public class ConnectionModel
    {
        public Class class1 { get; set; }
        public Class class2 { get; set; }
        public ConnectionModel(Class class1, Class class2)
        {
            this.class1 = class1;
            this.class2 = class2;
        }
    }
}
