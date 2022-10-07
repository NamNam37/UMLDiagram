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

namespace UMLdiagram
{
    public partial class AddMethodForm : Form
    {
        public List<MethodModel> methods = new List<MethodModel>();
        public AddMethodForm()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            methods.Add(new MethodModel(comboBox_AccessMod.Text, comboBox_Type.Text, textBox_Name.Text, textBox_ReturnedVar.Text));
            label_AddedMethod.Text = $"Property \"{textBox_Name.Text}\" has been added.";
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
    }
}
