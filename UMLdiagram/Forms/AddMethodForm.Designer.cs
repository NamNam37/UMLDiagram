namespace UMLdiagram
{
    partial class AddMethodForm
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
            this.button_Add = new System.Windows.Forms.Button();
            this.label_AddedMethod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.comboBox_AccessMod = new System.Windows.Forms.ComboBox();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ReturnedVar = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(28, 232);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(120, 23);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "Add Method";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_AddedMethod
            // 
            this.label_AddedMethod.AutoSize = true;
            this.label_AddedMethod.Location = new System.Drawing.Point(28, 287);
            this.label_AddedMethod.MaximumSize = new System.Drawing.Size(250, 0);
            this.label_AddedMethod.MinimumSize = new System.Drawing.Size(250, 0);
            this.label_AddedMethod.Name = "label_AddedMethod";
            this.label_AddedMethod.Size = new System.Drawing.Size(250, 15);
            this.label_AddedMethod.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Method Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access Modifier:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(173, 133);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(120, 23);
            this.textBox_Name.TabIndex = 5;
            this.textBox_Name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Name_Validating);
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
            this.comboBox_Type.Location = new System.Drawing.Point(173, 81);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(120, 23);
            this.comboBox_Type.TabIndex = 3;
            // 
            // comboBox_AccessMod
            // 
            this.comboBox_AccessMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AccessMod.FormattingEnabled = true;
            this.comboBox_AccessMod.Items.AddRange(new object[] {
            "private",
            "public",
            "protected"});
            this.comboBox_AccessMod.Location = new System.Drawing.Point(173, 27);
            this.comboBox_AccessMod.Name = "comboBox_AccessMod";
            this.comboBox_AccessMod.Size = new System.Drawing.Size(120, 23);
            this.comboBox_AccessMod.TabIndex = 1;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(218, 326);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 11;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(107, 326);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Variable Returned:";
            // 
            // textBox_ReturnedVar
            // 
            this.textBox_ReturnedVar.Location = new System.Drawing.Point(173, 181);
            this.textBox_ReturnedVar.Name = "textBox_ReturnedVar";
            this.textBox_ReturnedVar.Size = new System.Drawing.Size(120, 23);
            this.textBox_ReturnedVar.TabIndex = 7;
            this.textBox_ReturnedVar.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ReturnedVar_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ReturnedVar);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_AddedMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.comboBox_AccessMod);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.button_Cancel);
            this.Name = "AddMethodForm";
            this.Text = "Add Methods";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Add;
        private Label label_AddedMethod;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_Name;
        private ComboBox comboBox_Type;
        private ComboBox comboBox_AccessMod;
        private Button button_Confirm;
        private Button button_Cancel;
        private Label label4;
        private TextBox textBox_ReturnedVar;
        private ErrorProvider errorProvider;
    }
}