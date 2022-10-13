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
        
        public Class newClass { get; set; } = new Class();
        public bool isInterface { get; set; } = false;
        public void AddProp(string accessMod, string type, string name)
        {
            newClass.props.Add(new PropertyModel(accessMod, type, name));
        }
        public void EditProp(int selectedItemIndex)
        {
            throw new NotImplementedException();
        }
        public void RemoveProp(int selectedItemIndex)
        {
            newClass.props.RemoveAt(selectedItemIndex);
        }
        public void AddMethod(string accessMod, string type, string name)
        {
            throw new NotImplementedException();
        }
        public void EditMethod(int selectedItemIndex)
        {
            throw new NotImplementedException();
        }
        public void RemoveMethod(int selectedItemIndex)
        {
            throw new NotImplementedException();
        }
        public void AddParam(string type, string name)
        {
            throw new NotImplementedException();
        }
        public void RemoveParam(int selectedItemIndex)
        {
            throw new NotImplementedException();
        }
    }
}
