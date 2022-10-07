using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLdiagram.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UMLdiagram
{
    public partial class AddClassForm : Form
    {
        public ClassModel newClass { get; set; } = new ClassModel(0, 0);
        
        public AddClassForm()
        {
            InitializeComponent();
        }
        public AddClassForm(ClassModel editedClass)
        {
            InitializeComponent();
            textBox_className.Text = editedClass.name;
            textBox_X.Text = editedClass.X.ToString();
            textBox_Y.Text = editedClass.Y.ToString();
            PropsList.Text = CreateStringForList(editedClass.props);
            MethodsList.Text = CreateStringForList(editedClass.methods);
            newClass = editedClass;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            newClass.name = textBox_className.Text;

            if (textBox_X.Text.Length == 0)
                textBox_X.Text = "20";
            if (textBox_Y.Text.Length == 0)
                textBox_Y.Text = "20";

            newClass.X = int.Parse(textBox_X.Text);
            newClass.Y = int.Parse(textBox_Y.Text);

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_addProps_Click(object sender, EventArgs e)
        {
            AddPropsForm addPropsForm = new AddPropsForm();
            addPropsForm.ShowDialog();
            if (addPropsForm.DialogResult == DialogResult.OK)
            {
                foreach (var item in addPropsForm.props)
                {
                   newClass.props.Add(item);
                }
            }
            PropsList.Text = CreateStringForList(newClass.props);
        }

        private void button_AddMethods_Click(object sender, EventArgs e)
        {
            AddMethodForm addMethodForm = new AddMethodForm();
            addMethodForm.ShowDialog();
            if (addMethodForm.DialogResult == DialogResult.OK)
            {
                foreach (var item in addMethodForm.methods)
                {
                    newClass.methods.Add(item);
                }
            }
            MethodsList.Text = CreateStringForList(newClass.methods);
        }
        private string CreateStringForList(List<MethodModel> list)
        {
            string output = "";
            foreach (var item in list)
            {
                output += item.name + " ; ";
            }
            if (output.Length > 0)
                output = output.Remove(output.Length - 3);
            return output;
        }
        private string CreateStringForList(List<PropertyModel> list)
        {
            string output = "";
            foreach (var item in list)
            {
                output += item.name + " ; ";
            }
            if (output.Length > 0)
                output = output.Remove(output.Length - 3);
            return output;
        }
    }
}
