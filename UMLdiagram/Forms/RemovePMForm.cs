using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLdiagram.Models;

namespace UMLdiagram.Forms
{
    public partial class RemovePMForm : Form
    {
        public List<PropertyModel> props { get; set; }
        public List<MethodModel> methods { get; set; }
        public List<PropertyModel> newProps { get; set; } = new List<PropertyModel>();
        public List<MethodModel> newMethods { get; set; } = new List<MethodModel>();
        public RemovePMForm(List<PropertyModel> props, List<MethodModel> methods)
        {
            InitializeComponent();
            this.props = props;
            this.methods = methods;
            string[] propsNames = new string[props.Count];
            for (int i = 0; i < props.Count; i++)
            {
                propsNames[i] = props[i].name;
            }
            string[] methodsNames = new string[methods.Count];
            for (int i = 0; i < methods.Count; i++)
            {
                methodsNames[i] = methods[i].name;
            }
            listBox_Properties.Items.AddRange(propsNames);
            listBox_Methods.Items.AddRange(methodsNames);

        }

        private void button_RemoveProps_Click(object sender, EventArgs e)
        {
            CheckedListBox.ObjectCollection list = listBox_Properties.Items;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (listBox_Properties.GetItemChecked(i))
                    list.RemoveAt(i);
            }

        }

        private void button_RemoveMethods_Click(object sender, EventArgs e)
        {
            CheckedListBox.ObjectCollection list = listBox_Methods.Items;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (listBox_Methods.GetItemChecked(i))
                    list.RemoveAt(i);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox_Properties.Items)
            {
                foreach (var prop in props)
                {
                    if (prop.name == item.ToString())
                    {
                        newProps.Add(prop);
                    }
                }
            }
            foreach (var item in listBox_Methods.Items)
            {
                foreach (var method in methods)
                {
                    if (method.name == item.ToString())
                    {
                        newMethods.Add(method);
                    }
                }
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
