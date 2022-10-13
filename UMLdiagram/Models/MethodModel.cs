﻿using System;
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
        public List<ParameterModel> parameters { get; set; }
        public MethodModel(string accessMod, string type, string name, List<ParameterModel> paramaters)
        {
            this.accessMod = accessMod;
            this.type = type;
            this.name = name;
            this.parameters = paramaters;
        }
    }
}
