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
using System.Runtime.CompilerServices;

namespace UMLdiagram
{
    public partial class AddClassForm : Form
    {
        
        public ClassMaker classMaker { get; set; } = new ClassMaker();

        public AddClassForm()
        {
            InitializeComponent();
            comboBox_AccessModProp.Text = "private";
            comboBox_AccessModMethod.Text = "private";
        }
        public AddClassForm(ClassModel editedClass)
        {
            InitializeComponent();
            comboBox_AccessModProp.Text = "private";
            comboBox_AccessModMethod.Text = "private";
            textBox_className.Text = editedClass.name;
            checkBox_interface.Checked = editedClass.isInterface;
            foreach (var item in editedClass.props)
            {
                listBox_Props.Items.Add(item.name);
            }
            foreach (var item in editedClass.methods)
            {
                listBox_Methods.Items.Add(item.name);
            }
            classMaker.newClass = editedClass;
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
                classMaker.newClass.name = char.ToUpper(textBox_className.Text[0]) + textBox_className.Text.Substring(1);
                classMaker.newClass.isInterface = classMaker.isInterface;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void checkBox_interface_CheckedChanged(object sender, EventArgs e)
        {
            classMaker.isInterface = checkBox_interface.Checked;
        }

        private void button_AddProp_Click(object sender, EventArgs e)
        {
            classMaker.AddProp(comboBox_AccessModProp.Text, textBox_TypeProp.Text, textBox_NameProp.Text);
            listBox_Props.Items.Add(textBox_NameProp.Text);
            ClearProp();
            textBox_TypeProp.Focus();
        }
        private void ClearProp()
        {
            textBox_TypeProp.Text = "";
            textBox_NameProp.Text = "";
        }
        private void ClearMethod()
        {
            textBox_ReturnTypeMethod.Text = "";
            textBox_NameMethod.Text = "";
            listBox_Params.Items.Clear();
        }
        private void ClearParams()
        {
            textBox_TypeParam.Text = "";
            textBox_NameParam.Text = "";
        }

        private void button_EditProp_Click(object sender, EventArgs e)
        {
            if (listBox_Props.SelectedIndex != -1)
            {
                PropertyModel propToEdit = classMaker.newClass.props[listBox_Props.SelectedIndex];
                comboBox_AccessModProp.Text = propToEdit.accessMod;
                textBox_TypeProp.Text = propToEdit.type;
                textBox_NameProp.Text = propToEdit.name;
                classMaker.RemoveProp(listBox_Props.SelectedIndex);
                listBox_Props.Items.RemoveAt(listBox_Props.SelectedIndex);
                textBox_TypeProp.Focus();
            }
        }

        private void button_RemoveProp_Click(object sender, EventArgs e)
        {
            if (listBox_Props.SelectedIndex != -1)
            {
                classMaker.RemoveProp(listBox_Props.SelectedIndex);
                listBox_Props.Items.RemoveAt(listBox_Props.SelectedIndex);
            }
        }

        private void button_AddParam_Click(object sender, EventArgs e)
        {
            classMaker.AddParam(textBox_TypeParam.Text, textBox_NameParam.Text);
            listBox_Params.Items.Add(textBox_NameParam.Text);
            ClearParams();
            textBox_TypeParam.Focus();
        }

        private void button_RemoveParam_Click(object sender, EventArgs e)
        {
            if (listBox_Params.SelectedIndex != -1)
            {
                classMaker.RemoveParam(listBox_Params.SelectedIndex);
                listBox_Params.Items.RemoveAt(listBox_Params.SelectedIndex);
            }
        }

        private void button_AddMethod_Click(object sender, EventArgs e)
        {
            classMaker.AddMethod(comboBox_AccessModMethod.Text, textBox_ReturnTypeMethod.Text, textBox_NameMethod.Text);
            listBox_Methods.Items.Add(textBox_NameMethod.Text);
            ClearMethod();
            ClearParams();
        }

        private void button_EditMethod_Click(object sender, EventArgs e)
        {
            if (listBox_Methods.SelectedIndex != -1)
            {
                MethodModel methodToEdit = classMaker.newClass.methods[listBox_Methods.SelectedIndex];
                comboBox_AccessModMethod.Text = methodToEdit.accessMod;
                textBox_ReturnTypeMethod.Text = methodToEdit.type;
                textBox_NameMethod.Text = methodToEdit.name;
                foreach (var item in methodToEdit.parameters)
                {
                    listBox_Params.Items.Add(item.name);
                }
                foreach (var item in methodToEdit.parameters)
                {
                    classMaker.AddParam(item.type, item.name);
                }

                classMaker.RemoveMethod(listBox_Methods.SelectedIndex);
                listBox_Methods.Items.RemoveAt(listBox_Methods.SelectedIndex);
                textBox_ReturnTypeMethod.Focus();
            }
        }

        private void button_RemoveMethod_Click(object sender, EventArgs e)
        {
            if (listBox_Methods.SelectedIndex != -1)
            {
                classMaker.RemoveMethod(listBox_Methods.SelectedIndex);
                listBox_Methods.Items.RemoveAt(listBox_Methods.SelectedIndex);
            }
        }
        private void textBox_NotEmpty_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(textBox_className, null);

            if (string.IsNullOrWhiteSpace(textBox_className.Text))
            {
                this.errorProvider.SetError(textBox_className, "This field cannot be empty.");
                e.Cancel = true;
            }
        }
    }
}
