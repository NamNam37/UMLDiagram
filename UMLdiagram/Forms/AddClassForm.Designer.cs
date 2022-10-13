namespace UMLdiagram
{
    partial class AddClassForm
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_className = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_interface = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button_RemoveMethod = new System.Windows.Forms.Button();
            this.button_RemoveProp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Properties = new System.Windows.Forms.TabPage();
            this.button_EditProp = new System.Windows.Forms.Button();
            this.listBox_Props = new System.Windows.Forms.ListBox();
            this.textBox_TypeProp = new System.Windows.Forms.TextBox();
            this.button_AddProp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_NameProp = new System.Windows.Forms.TextBox();
            this.comboBox_AccessModProp = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_EditMethod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_RemoveParam = new System.Windows.Forms.Button();
            this.comboBox_AccessModMethod = new System.Windows.Forms.ComboBox();
            this.listBox_Params = new System.Windows.Forms.ListBox();
            this.textBox_NameMethod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_NameParam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_TypeParam = new System.Windows.Forms.TextBox();
            this.button_AddMethod = new System.Windows.Forms.Button();
            this.button_AddParam = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ReturnTypeMethod = new System.Windows.Forms.TextBox();
            this.listBox_Methods = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Properties.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(527, 576);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(627, 576);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 14;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class Name:";
            // 
            // textBox_className
            // 
            this.textBox_className.Location = new System.Drawing.Point(105, 16);
            this.textBox_className.Name = "textBox_className";
            this.textBox_className.Size = new System.Drawing.Size(100, 23);
            this.textBox_className.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Is Interface?";
            // 
            // checkBox_interface
            // 
            this.checkBox_interface.AutoSize = true;
            this.checkBox_interface.Location = new System.Drawing.Point(368, 20);
            this.checkBox_interface.Name = "checkBox_interface";
            this.checkBox_interface.Size = new System.Drawing.Size(15, 14);
            this.checkBox_interface.TabIndex = 7;
            this.checkBox_interface.UseVisualStyleBackColor = true;
            this.checkBox_interface.CheckedChanged += new System.EventHandler(this.checkBox_interface_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Methods";
            // 
            // button_RemoveMethod
            // 
            this.button_RemoveMethod.Location = new System.Drawing.Point(535, 450);
            this.button_RemoveMethod.Name = "button_RemoveMethod";
            this.button_RemoveMethod.Size = new System.Drawing.Size(115, 23);
            this.button_RemoveMethod.TabIndex = 20;
            this.button_RemoveMethod.Text = "Remove Method";
            this.button_RemoveMethod.UseVisualStyleBackColor = true;
            this.button_RemoveMethod.Click += new System.EventHandler(this.button_RemoveMethod_Click);
            // 
            // button_RemoveProp
            // 
            this.button_RemoveProp.Location = new System.Drawing.Point(535, 450);
            this.button_RemoveProp.Name = "button_RemoveProp";
            this.button_RemoveProp.Size = new System.Drawing.Size(115, 23);
            this.button_RemoveProp.TabIndex = 19;
            this.button_RemoveProp.Text = "Remove Property";
            this.button_RemoveProp.UseVisualStyleBackColor = true;
            this.button_RemoveProp.Click += new System.EventHandler(this.button_RemoveProp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Properties";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Properties);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 521);
            this.tabControl1.TabIndex = 21;
            // 
            // Properties
            // 
            this.Properties.Controls.Add(this.button_EditProp);
            this.Properties.Controls.Add(this.listBox_Props);
            this.Properties.Controls.Add(this.textBox_TypeProp);
            this.Properties.Controls.Add(this.button_AddProp);
            this.Properties.Controls.Add(this.label3);
            this.Properties.Controls.Add(this.label6);
            this.Properties.Controls.Add(this.label7);
            this.Properties.Controls.Add(this.textBox_NameProp);
            this.Properties.Controls.Add(this.comboBox_AccessModProp);
            this.Properties.Controls.Add(this.label1);
            this.Properties.Controls.Add(this.button_RemoveProp);
            this.Properties.Location = new System.Drawing.Point(4, 24);
            this.Properties.Name = "Properties";
            this.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.Properties.Size = new System.Drawing.Size(702, 493);
            this.Properties.TabIndex = 0;
            this.Properties.Text = "Properties";
            this.Properties.UseVisualStyleBackColor = true;
            // 
            // button_EditProp
            // 
            this.button_EditProp.Location = new System.Drawing.Point(400, 450);
            this.button_EditProp.Name = "button_EditProp";
            this.button_EditProp.Size = new System.Drawing.Size(115, 23);
            this.button_EditProp.TabIndex = 32;
            this.button_EditProp.Text = "Edit Property";
            this.button_EditProp.UseVisualStyleBackColor = true;
            this.button_EditProp.Click += new System.EventHandler(this.button_EditProp_Click);
            // 
            // listBox_Props
            // 
            this.listBox_Props.FormattingEnabled = true;
            this.listBox_Props.ItemHeight = 15;
            this.listBox_Props.Location = new System.Drawing.Point(400, 40);
            this.listBox_Props.Name = "listBox_Props";
            this.listBox_Props.Size = new System.Drawing.Size(250, 394);
            this.listBox_Props.TabIndex = 31;
            // 
            // textBox_TypeProp
            // 
            this.textBox_TypeProp.Location = new System.Drawing.Point(180, 100);
            this.textBox_TypeProp.Name = "textBox_TypeProp";
            this.textBox_TypeProp.Size = new System.Drawing.Size(120, 23);
            this.textBox_TypeProp.TabIndex = 30;
            // 
            // button_AddProp
            // 
            this.button_AddProp.Location = new System.Drawing.Point(33, 220);
            this.button_AddProp.Name = "button_AddProp";
            this.button_AddProp.Size = new System.Drawing.Size(120, 23);
            this.button_AddProp.TabIndex = 26;
            this.button_AddProp.Text = "Add Property";
            this.button_AddProp.UseVisualStyleBackColor = true;
            this.button_AddProp.Click += new System.EventHandler(this.button_AddProp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Property Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Access Modifier:";
            // 
            // textBox_NameProp
            // 
            this.textBox_NameProp.Location = new System.Drawing.Point(180, 160);
            this.textBox_NameProp.Name = "textBox_NameProp";
            this.textBox_NameProp.Size = new System.Drawing.Size(120, 23);
            this.textBox_NameProp.TabIndex = 25;
            // 
            // comboBox_AccessModProp
            // 
            this.comboBox_AccessModProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AccessModProp.FormattingEnabled = true;
            this.comboBox_AccessModProp.Items.AddRange(new object[] {
            "private",
            "public",
            "protected"});
            this.comboBox_AccessModProp.Location = new System.Drawing.Point(180, 40);
            this.comboBox_AccessModProp.Name = "comboBox_AccessModProp";
            this.comboBox_AccessModProp.Size = new System.Drawing.Size(120, 23);
            this.comboBox_AccessModProp.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_EditMethod);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.listBox_Methods);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button_RemoveMethod);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Methods";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_EditMethod
            // 
            this.button_EditMethod.Location = new System.Drawing.Point(400, 450);
            this.button_EditMethod.Name = "button_EditMethod";
            this.button_EditMethod.Size = new System.Drawing.Size(115, 23);
            this.button_EditMethod.TabIndex = 37;
            this.button_EditMethod.Text = "Edit Method";
            this.button_EditMethod.UseVisualStyleBackColor = true;
            this.button_EditMethod.Click += new System.EventHandler(this.button_EditMethod_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button_RemoveParam);
            this.groupBox1.Controls.Add(this.comboBox_AccessModMethod);
            this.groupBox1.Controls.Add(this.listBox_Params);
            this.groupBox1.Controls.Add(this.textBox_NameMethod);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_NameParam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_TypeParam);
            this.groupBox1.Controls.Add(this.button_AddMethod);
            this.groupBox1.Controls.Add(this.button_AddParam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_ReturnTypeMethod);
            this.groupBox1.Location = new System.Drawing.Point(6, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 459);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Method";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Access Modifier:";
            // 
            // button_RemoveParam
            // 
            this.button_RemoveParam.Location = new System.Drawing.Point(173, 364);
            this.button_RemoveParam.Name = "button_RemoveParam";
            this.button_RemoveParam.Size = new System.Drawing.Size(120, 23);
            this.button_RemoveParam.TabIndex = 35;
            this.button_RemoveParam.Text = "Remove Parameter";
            this.button_RemoveParam.UseVisualStyleBackColor = true;
            this.button_RemoveParam.Click += new System.EventHandler(this.button_RemoveParam_Click);
            // 
            // comboBox_AccessModMethod
            // 
            this.comboBox_AccessModMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AccessModMethod.FormattingEnabled = true;
            this.comboBox_AccessModMethod.Items.AddRange(new object[] {
            "private",
            "public",
            "protected"});
            this.comboBox_AccessModMethod.Location = new System.Drawing.Point(173, 49);
            this.comboBox_AccessModMethod.Name = "comboBox_AccessModMethod";
            this.comboBox_AccessModMethod.Size = new System.Drawing.Size(120, 23);
            this.comboBox_AccessModMethod.TabIndex = 22;
            // 
            // listBox_Params
            // 
            this.listBox_Params.FormattingEnabled = true;
            this.listBox_Params.ItemHeight = 15;
            this.listBox_Params.Location = new System.Drawing.Point(173, 237);
            this.listBox_Params.Name = "listBox_Params";
            this.listBox_Params.Size = new System.Drawing.Size(120, 109);
            this.listBox_Params.TabIndex = 34;
            // 
            // textBox_NameMethod
            // 
            this.textBox_NameMethod.Location = new System.Drawing.Point(173, 155);
            this.textBox_NameMethod.Name = "textBox_NameMethod";
            this.textBox_NameMethod.Size = new System.Drawing.Size(120, 23);
            this.textBox_NameMethod.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Return Type:";
            // 
            // textBox_NameParam
            // 
            this.textBox_NameParam.Location = new System.Drawing.Point(28, 281);
            this.textBox_NameParam.Name = "textBox_NameParam";
            this.textBox_NameParam.PlaceholderText = "Name";
            this.textBox_NameParam.Size = new System.Drawing.Size(114, 23);
            this.textBox_NameParam.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Method Name:";
            // 
            // textBox_TypeParam
            // 
            this.textBox_TypeParam.Location = new System.Drawing.Point(28, 237);
            this.textBox_TypeParam.Name = "textBox_TypeParam";
            this.textBox_TypeParam.PlaceholderText = "Type";
            this.textBox_TypeParam.Size = new System.Drawing.Size(114, 23);
            this.textBox_TypeParam.TabIndex = 31;
            // 
            // button_AddMethod
            // 
            this.button_AddMethod.Location = new System.Drawing.Point(173, 424);
            this.button_AddMethod.Name = "button_AddMethod";
            this.button_AddMethod.Size = new System.Drawing.Size(120, 23);
            this.button_AddMethod.TabIndex = 28;
            this.button_AddMethod.Text = "Add Method";
            this.button_AddMethod.UseVisualStyleBackColor = true;
            this.button_AddMethod.Click += new System.EventHandler(this.button_AddMethod_Click);
            // 
            // button_AddParam
            // 
            this.button_AddParam.Location = new System.Drawing.Point(28, 323);
            this.button_AddParam.Name = "button_AddParam";
            this.button_AddParam.Size = new System.Drawing.Size(114, 23);
            this.button_AddParam.TabIndex = 30;
            this.button_AddParam.Text = "Add Parameter";
            this.button_AddParam.UseVisualStyleBackColor = true;
            this.button_AddParam.Click += new System.EventHandler(this.button_AddParam_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Method Parameters:";
            // 
            // textBox_ReturnTypeMethod
            // 
            this.textBox_ReturnTypeMethod.Location = new System.Drawing.Point(173, 103);
            this.textBox_ReturnTypeMethod.Name = "textBox_ReturnTypeMethod";
            this.textBox_ReturnTypeMethod.Size = new System.Drawing.Size(120, 23);
            this.textBox_ReturnTypeMethod.TabIndex = 29;
            // 
            // listBox_Methods
            // 
            this.listBox_Methods.FormattingEnabled = true;
            this.listBox_Methods.ItemHeight = 15;
            this.listBox_Methods.Location = new System.Drawing.Point(400, 40);
            this.listBox_Methods.Name = "listBox_Methods";
            this.listBox_Methods.Size = new System.Drawing.Size(250, 394);
            this.listBox_Methods.TabIndex = 33;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkBox_interface);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_className);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_cancel);
            this.Name = "AddClassForm";
            this.Text = "Add Class";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Properties.ResumeLayout(false);
            this.Properties.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_cancel;
        private Button button_confirm;
        private Label label4;
        private TextBox textBox_className;
        private Label label5;
        private CheckBox checkBox_interface;
        private ErrorProvider errorProvider;
        private Label label2;
        private Button button_RemoveMethod;
        private Button button_RemoveProp;
        private Label label1;
        private TabControl tabControl1;
        private TabPage Properties;
        private TabPage tabPage2;
        private Button button_AddProp;
        private Label label3;
        private Label label6;
        private Label label7;
        private TextBox textBox_NameProp;
        private ComboBox comboBox_AccessModProp;
        private TextBox textBox_ReturnTypeMethod;
        private Label label8;
        private Button button_AddMethod;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox_NameMethod;
        private ComboBox comboBox_AccessModMethod;
        private TextBox textBox_TypeProp;
        private ListBox listBox_Props;
        private Button button_RemoveParam;
        private ListBox listBox_Params;
        private ListBox listBox_Methods;
        private TextBox textBox_NameParam;
        private TextBox textBox_TypeParam;
        private Button button_AddParam;
        private Button button_EditMethod;
        private GroupBox groupBox1;
        private Button button_EditProp;
    }
}