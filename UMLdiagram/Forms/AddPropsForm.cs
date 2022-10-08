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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UMLdiagram
{
    public partial class AddPropsForm : Form
    {
        public List<PropertyModel> props = new List<PropertyModel>();
        private const string invalidCharacters = @"><@{}[]#&()/|*-+$%~\";
        public AddPropsForm()
        {
            InitializeComponent();
            comboBox_AccessMod.Text = "private";
            comboBox_Type.Text = "string";
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                props.Add(new PropertyModel(comboBox_AccessMod.Text, comboBox_Type.Text, textBox_Name.Text));
                label_AddedProp.Text = $"Property \"{textBox_Name.Text}\" has been added.";
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
                this.errorProvider.SetError(textBox_Name, "Enter name for property.");
                e.Cancel = true;
            }

            foreach (var item in props)
            {
                if (item.name == textBox_Name.Text)
                {
                    this.errorProvider.SetError(textBox_Name, "Variable with this name exists.");
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
    }
}
