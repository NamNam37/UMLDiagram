namespace UMLdiagram
{
    partial class AddPropsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.comboBox_AccessMod = new System.Windows.Forms.ComboBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_AddedProp = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(106, 282);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(217, 282);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 1;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // comboBox_AccessMod
            // 
            this.comboBox_AccessMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AccessMod.FormattingEnabled = true;
            this.comboBox_AccessMod.Items.AddRange(new object[] {
            "private",
            "public",
            "protected"});
            this.comboBox_AccessMod.Location = new System.Drawing.Point(172, 29);
            this.comboBox_AccessMod.Name = "comboBox_AccessMod";
            this.comboBox_AccessMod.Size = new System.Drawing.Size(120, 23);
            this.comboBox_AccessMod.TabIndex = 2;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "string",
            "int",
            "bool",
            "double",
            "char"});
            this.comboBox_Type.Location = new System.Drawing.Point(172, 83);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(120, 23);
            this.comboBox_Type.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(172, 139);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(120, 23);
            this.textBox_Name.TabIndex = 4;
            this.textBox_Name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Name_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Access Modifier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Property Name:";
            // 
            // label_AddedProp
            // 
            this.label_AddedProp.AutoSize = true;
            this.label_AddedProp.Location = new System.Drawing.Point(27, 243);
            this.label_AddedProp.MaximumSize = new System.Drawing.Size(250, 0);
            this.label_AddedProp.MinimumSize = new System.Drawing.Size(250, 0);
            this.label_AddedProp.Name = "label_AddedProp";
            this.label_AddedProp.Size = new System.Drawing.Size(250, 15);
            this.label_AddedProp.TabIndex = 8;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(27, 188);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(120, 23);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "Add Property";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddPropsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(334, 331);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_AddedProp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.comboBox_AccessMod);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.button_Cancel);
            this.Name = "AddPropsForm";
            this.Text = "Add Properties";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Cancel;
        private Button button_Confirm;
        private ComboBox comboBox_AccessMod;
        private ComboBox comboBox_Type;
        private TextBox textBox_Name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_AddedProp;
        private Button button_Add;
        private ErrorProvider errorProvider;
    }
}