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
        public List<ParameterModel> parameters { get; set; } = new List<ParameterModel>();
        public MethodModel(string accessMod, string type, string name, List<ParameterModel> parameters)
        {
            this.accessMod = accessMod;
            this.type = type;
            this.name = name;
            foreach (var item in parameters)
            {
                this.parameters.Add(item);
            }
        }
    }
}
