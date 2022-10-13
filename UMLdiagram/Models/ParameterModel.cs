using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagram.Models
{
    public class ParameterModel
    {
        public string type { get; set; }
        public string name { get; set; }
        public ParameterModel(string type, string name)
        {
            this.type = type;
            this.name = name;
        }
    }
}
