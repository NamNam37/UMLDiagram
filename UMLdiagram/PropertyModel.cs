using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagram
{
    public class PropertyModel
    {
        public string accessMod { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public PropertyModel (string accessMod, string type, string name)
        {
            this.accessMod = accessMod;
            this.type = type;
            this.name = name;
        }
    }
}
