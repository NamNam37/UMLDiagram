using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Models;

namespace UMLdiagram.Utilities
{
    public class JsonFileUtility
    {
        private string? json { get; set; }
        public void SaveObject(object objectToSave, string savePath)
        {
            json = JsonConvert.SerializeObject(objectToSave, Formatting.Indented);
            File.WriteAllText(savePath, json);
        }
        public void SaveList<T>(List<T> objectsToSave, string savePath)
        {

            json = JsonConvert.SerializeObject(objectsToSave, Formatting.Indented);
            File.WriteAllText(savePath, json);
        }
        public object? ReadObject(string loadPath)
        {
            string json = File.ReadAllText(loadPath);
            return JsonConvert.DeserializeObject(json);
        }
        public JArray? ReadList(string loadPath)
        {
            string json = File.ReadAllText(loadPath);
            return JsonConvert.DeserializeObject<JArray>(json);
        }
        //public object DeserializeList()
    }
}
