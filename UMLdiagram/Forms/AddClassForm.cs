using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLdiagram.Models;
using System.Windows.Forms;
using UMLdiagram.Forms;

namespace UMLdiagram
{
    public partial class AddClassForm : Form
    {
        public ClassModel newClass { get; set; } = new ClassModel(0, 0);
        public bool isInterface { get; set; } = false;

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
            checkBox_interface.Checked = editedClass.isInterface;
            newClass = editedClass;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                newClass.name = char.ToUpper(textBox_className.Text[0]) + textBox_className.Text.Substring(1);

                if (textBox_X.Text.Length == 0)
                    textBox_X.Text = "20";
                if (textBox_Y.Text.Length == 0)
                    textBox_Y.Text = "20";

                newClass.X = int.Parse(textBox_X.Text);
                newClass.Y = int.Parse(textBox_Y.Text);
                newClass.isInterface = isInterface;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button_addProps_Click(object sender, EventArgs e)
        {
            AddPropsForm addPropsForm = new AddPropsForm(newClass.props, isInterface);
            addPropsForm.ShowDialog();
            if (addPropsForm.DialogResult == DialogResult.OK)
            {
                newClass.props = addPropsForm.props;
            }
            PropsList.Text = CreateStringForList(newClass.props);
        }

        private void button_AddMethods_Click(object sender, EventArgs e)
        {
            AddMethodForm addMethodForm = new AddMethodForm(newClass.methods, isInterface);
            addMethodForm.ShowDialog();
            if (addMethodForm.DialogResult == DialogResult.OK)
            {
                newClass.methods = addMethodForm.methods;
            }
            MethodsList.Text = CreateStringForList(newClass.methods);
        }
        private string CreateStringForList(List<MethodModel> list)
        {
            string output = "";
            foreach (var item in list)
            {
                output += item.name + "() ; ";
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

        private void checkBox_interface_CheckedChanged(object sender, EventArgs e)
        {
            this.isInterface = checkBox_interface.Checked;
        }

        private void textBox_className_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(textBox_className, null);

            if (string.IsNullOrWhiteSpace(textBox_className.Text))
            {
                this.errorProvider.SetError(textBox_className, "Enter name for this Class.");
                e.Cancel = true;
            }
        }
        private void textBox_coords_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = sender as TextBox;

            this.errorProvider.SetError(textbox, null);

            if (textbox.Text.Length > 0 && !Regex.IsMatch(textbox.Text, @"^[0-9]{1,4}$"))
            {
                this.errorProvider.SetError(textbox, "This coordinate has to be an integer.");
                e.Cancel = true;
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            RemovePMForm removePMForm = new RemovePMForm(newClass.props, newClass.methods);
            removePMForm.ShowDialog();
            if (removePMForm.DialogResult == DialogResult.OK)
            {
                newClass.props = removePMForm.newProps;
                newClass.methods = removePMForm.newMethods;
                PropsList.Text = CreateStringForList(newClass.props);
                MethodsList.Text = CreateStringForList(newClass.methods);
            }
        }
    }
}
