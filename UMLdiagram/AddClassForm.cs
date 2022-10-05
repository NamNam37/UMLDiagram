using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            newClass.props.Add(new PropertyModel("private", "bool", "fooobfdaboo"));
            newClass.props.Add(new PropertyModel("private", "string", "bbfdbafdbadar"));
            newClass.props.Add(new PropertyModel("public", "int", "xxbfdbfdabfx"));
            newClass.props.Add(new PropertyModel("private", "string", "zzgfraaaaahtsrffffffffffffffffffffffffffffffffffhtfrsaaaaaaz"));
            newClass.props.Add(new PropertyModel("private", "string", "zzgfraaaaahtsrfrsaaaaaaz"));
            newClass.props.Add(new PropertyModel("protected", "string", "zffffffffffffffffffffffffffffffhtfrsaaaaaaz"));
            newClass.props.Add(new PropertyModel("private", "string", "zzgaaaaaaz"));
            foreach (var item in newClass.props)
            {
                PropsList.Text += item.name + " ; ";
            }
            PropsList.Text = PropsList.Text.Remove(PropsList.Text.Length - 3);
        }

        private void button_AddMethods_Click(object sender, EventArgs e)
        {

        }
    }
}
