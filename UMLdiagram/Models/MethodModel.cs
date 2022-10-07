using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagram.Models
{
    public class MethodModel
    {
        public string accessMod { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string returnedName { get; set; }
        public MethodModel(string accessMod, string type, string name, string returnedName = "")
        {
            this.accessMod = accessMod;
            this.type = type;
            this.name = name;
            this.returnedName = returnedName;
        }
    }
}
