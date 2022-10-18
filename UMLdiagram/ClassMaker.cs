using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Models;

namespace UMLdiagram
{
    public class ClassMaker
    {
        
        public ClassModel newClass { get; set; } = new ClassModel("", false);
        List<ParameterModel> parameters = new List<ParameterModel>();
        public bool isInterface { get; set; } = false;
        public void AddProp(string accessMod, string type, string name)
        {
            newClass.props.Add(new PropertyModel(accessMod, type, name));
        }
        public void RemoveProp(int selectedItemIndex)
        {
            newClass.props.RemoveAt(selectedItemIndex);
        }
        public void AddMethod(string accessMod, string type, string name)
        {
            newClass.methods.Add(new MethodModel(accessMod, type, name, parameters));
            parameters.Clear();
        }
        public void RemoveMethod(int selectedItemIndex)
        {
            newClass.methods.RemoveAt(selectedItemIndex);
        }
        public void AddParam(string type, string name)
        {
            parameters.Add(new ParameterModel(type, name));
        }
        public void RemoveParam(int selectedItemIndex)
        {
            parameters.RemoveAt(selectedItemIndex);
        }
    }
}
