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
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_addProps = new System.Windows.Forms.Button();
            this.button_AddMethods = new System.Windows.Forms.Button();
            this.PropsList = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_className = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_interface = new System.Windows.Forms.CheckBox();
            this.MethodsList = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(105, 45);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(100, 23);
            this.textBox_X.TabIndex = 3;
            this.textBox_X.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_coords_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(105, 74);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(100, 23);
            this.textBox_Y.TabIndex = 5;
            this.textBox_Y.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_coords_Validating);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(234, 284);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(350, 284);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 14;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_addProps
            // 
            this.button_addProps.Location = new System.Drawing.Point(12, 135);
            this.button_addProps.Name = "button_addProps";
            this.button_addProps.Size = new System.Drawing.Size(108, 23);
            this.button_addProps.TabIndex = 8;
            this.button_addProps.Text = "Add Properties";
            this.button_addProps.UseVisualStyleBackColor = true;
            this.button_addProps.Click += new System.EventHandler(this.button_addProps_Click);
            // 
            // button_AddMethods
            // 
            this.button_AddMethods.Location = new System.Drawing.Point(350, 135);
            this.button_AddMethods.Name = "button_AddMethods";
            this.button_AddMethods.Size = new System.Drawing.Size(100, 23);
            this.button_AddMethods.TabIndex = 10;
            this.button_AddMethods.Text = "Add Methods";
            this.button_AddMethods.UseVisualStyleBackColor = true;
            this.button_AddMethods.Click += new System.EventHandler(this.button_AddMethods_Click);
            // 
            // PropsList
            // 
            this.PropsList.AutoSize = true;
            this.PropsList.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PropsList.Location = new System.Drawing.Point(12, 170);
            this.PropsList.MaximumSize = new System.Drawing.Size(200, 100);
            this.PropsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.PropsList.Name = "PropsList";
            this.PropsList.Size = new System.Drawing.Size(200, 100);
            this.PropsList.TabIndex = 11;
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
            this.textBox_className.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_className_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Is Interface?";
            // 
            // checkBox_interface
            // 
            this.checkBox_interface.AutoSize = true;
            this.checkBox_interface.Location = new System.Drawing.Point(105, 103);
            this.checkBox_interface.Name = "checkBox_interface";
            this.checkBox_interface.Size = new System.Drawing.Size(15, 14);
            this.checkBox_interface.TabIndex = 7;
            this.checkBox_interface.UseVisualStyleBackColor = true;
            this.checkBox_interface.CheckedChanged += new System.EventHandler(this.checkBox_interface_CheckedChanged);
            // 
            // MethodsList
            // 
            this.MethodsList.AutoSize = true;
            this.MethodsList.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MethodsList.Location = new System.Drawing.Point(250, 170);
            this.MethodsList.MaximumSize = new System.Drawing.Size(200, 100);
            this.MethodsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.MethodsList.Name = "MethodsList";
            this.MethodsList.Size = new System.Drawing.Size(200, 100);
            this.MethodsList.TabIndex = 12;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(160, 135);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(149, 23);
            this.button_Remove.TabIndex = 9;
            this.button_Remove.Text = "Remove Props/Methods";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(484, 321);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.MethodsList);
            this.Controls.Add(this.checkBox_interface);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_className);
            this.Controls.Add(this.PropsList);
            this.Controls.Add(this.button_AddMethods);
            this.Controls.Add(this.button_addProps);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_X);
            this.Name = "AddClassForm";
            this.Text = "Add Class";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox_X;
        private Label label2;
        private Label label3;
        private TextBox textBox_Y;
        private Button button_cancel;
        private Button button_confirm;
        private Button button_addProps;
        private Button button_AddMethods;
        private Label PropsList;
        private Label label4;
        private TextBox textBox_className;
        private Label label5;
        private CheckBox checkBox_interface;
        private Label MethodsList;
        private ErrorProvider errorProvider;
        private Button button_Remove;
    }
}