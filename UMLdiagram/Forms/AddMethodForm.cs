using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLdiagram.Models;

namespace UMLdiagram
{
    public partial class AddMethodForm : Form
    {
        public List<MethodModel> methods = new List<MethodModel>();
        private const string invalidCharacters = @"><@{}[]#&()/|*-+$%~\";
        private bool isInterface { get; set; } = false;
        public AddMethodForm(List<MethodModel> methods, bool isInterface)
        {
            InitializeComponent();
            this.methods = methods; 
            this.isInterface = isInterface;
            comboBox_AccessMod.Text = "private";
            comboBox_Type.Text = "string";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                methods.Add(new MethodModel(comboBox_AccessMod.Text, comboBox_Type.Text, char.ToUpper(textBox_Name.Text[0])+textBox_Name.Text.Substring(1), textBox_ReturnedVar.Text));
                label_AddedMethod.Text = $"Property \"{textBox_Name.Text}\" has been added.";
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox_Name_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(textBox_Name, null);

            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                this.errorProvider.SetError(textBox_Name, "Enter name for method.");
                e.Cancel = true;
            }

            foreach (var item in methods)
            {
                if (item.name == char.ToUpper(textBox_Name.Text[0]) + textBox_Name.Text.Substring(1))
                {
                    this.errorProvider.SetError(textBox_Name, "Method with this name exists.");
                    e.Cancel = true;
                }
            }

            foreach (char item in invalidCharacters)
            {
                if (textBox_Name.Text.Contains(item))
                {
                    this.errorProvider.SetError(textBox_Name, "Name uses one of these letters: \n" + @"> < @ () {} [] # & / | \ * - + $ % ~");
                    e.Cancel = true;
                }
            }
        }
        private void textBox_ReturnedVar_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(textBox_ReturnedVar, null);

            if (string.IsNullOrWhiteSpace(textBox_ReturnedVar.Text))
            {
                this.errorProvider.SetError(textBox_ReturnedVar, "Enter name for returned variable.");
                e.Cancel = true;
            }
        }
    }
}
