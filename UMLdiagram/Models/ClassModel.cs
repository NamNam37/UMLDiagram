using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagram.Models
{
    public class ClassModel
    {
        public int X { get; set; } = 20;
        public int Y { get; set; } = 20;
        public int width { get; set; }
        public int height { get; set; }
        public string name { get; set; }
        public bool isInterface { get; set; } = false;
        public List<PropertyModel> props { get; set; } = new List<PropertyModel>();
        public List<MethodModel> methods { get; set; } = new List<MethodModel>();
        public int topConnections { get; set; } = 0;
        public int leftConnections { get; set; } = 0;
        public int rightConnections { get; set; } = 0;
        public int bottomConnections { get; set; } = 0;
        public ClassModel(int x, int y, int width, int height, string name, bool isInterface, List<PropertyModel> props, List<MethodModel> methods)
        {
            X = x;
            Y = y;
            this.width = width;
            this.height = height;
            this.name = name;
            this.isInterface = isInterface;
            this.props = props;
            this.methods = methods;
        }
    }
}
