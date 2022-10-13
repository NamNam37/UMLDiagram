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

namespace UMLdiagram
{
    public partial class AddClassForm : Form
    {
        
        public ClassMaker classMaker { get; set; } = new ClassMaker();

        public AddClassForm()
        {
            InitializeComponent();
        }
        public AddClassForm(Class editedClass)
        {
            InitializeComponent();
            textBox_className.Text = editedClass.name;
            checkBox_interface.Checked = editedClass.isInterface;
            comboBox_AccessModProp.Text = "private";
            comboBox_AccessModMethod.Text = "private";
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
        }

        private void button_EditProp_Click(object sender, EventArgs e)
        {
            classMaker.EditProp(listBox_Props.SelectedIndex);
        }

        private void button_RemoveProp_Click(object sender, EventArgs e)
        {
            classMaker.RemoveProp(listBox_Props.SelectedIndex);
        }

        private void button_AddParam_Click(object sender, EventArgs e)
        {
            classMaker.AddParam(textBox_TypeParam.Text, textBox_NameParam.Text);
        }

        private void button_RemoveParam_Click(object sender, EventArgs e)
        {
            classMaker.RemoveParam(listBox_Params.SelectedIndex);
        }

        private void button_AddMethod_Click(object sender, EventArgs e)
        {
            classMaker.AddMethod(comboBox_AccessModMethod.Text, textBox_ReturnTypeMethod.Text, textBox_NameMethod.Text);
        }

        private void button_EditMethod_Click(object sender, EventArgs e)
        {
            classMaker.EditMethod(listBox_Props.SelectedIndex);
        }

        private void button_RemoveMethod_Click(object sender, EventArgs e)
        {
            classMaker.RemoveMethod(listBox_Props.SelectedIndex);
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
