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
            this.label1 = new System.Windows.Forms.Label();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MethodsList = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Class";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(115, 117);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(100, 23);
            this.textBox_X.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(301, 117);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(100, 23);
            this.textBox_Y.TabIndex = 5;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(217, 347);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(353, 347);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 7;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_addProps
            // 
            this.button_addProps.Location = new System.Drawing.Point(22, 170);
            this.button_addProps.Name = "button_addProps";
            this.button_addProps.Size = new System.Drawing.Size(100, 23);
            this.button_addProps.TabIndex = 8;
            this.button_addProps.Text = "Add Properties";
            this.button_addProps.UseVisualStyleBackColor = true;
            this.button_addProps.Click += new System.EventHandler(this.button_addProps_Click);
            // 
            // button_AddMethods
            // 
            this.button_AddMethods.Location = new System.Drawing.Point(247, 170);
            this.button_AddMethods.Name = "button_AddMethods";
            this.button_AddMethods.Size = new System.Drawing.Size(100, 23);
            this.button_AddMethods.TabIndex = 9;
            this.button_AddMethods.Text = "Add Methods";
            this.button_AddMethods.UseVisualStyleBackColor = true;
            this.button_AddMethods.Click += new System.EventHandler(this.button_AddMethods_Click);
            // 
            // PropsList
            // 
            this.PropsList.AutoSize = true;
            this.PropsList.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PropsList.Location = new System.Drawing.Point(39, 212);
            this.PropsList.MaximumSize = new System.Drawing.Size(200, 100);
            this.PropsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.PropsList.Name = "PropsList";
            this.PropsList.Size = new System.Drawing.Size(200, 100);
            this.PropsList.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Class Name:";
            // 
            // textBox_className
            // 
            this.textBox_className.Location = new System.Drawing.Point(115, 66);
            this.textBox_className.Name = "textBox_className";
            this.textBox_className.Size = new System.Drawing.Size(100, 23);
            this.textBox_className.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Is Interface?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(325, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MethodsList
            // 
            this.MethodsList.AutoSize = true;
            this.MethodsList.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MethodsList.Location = new System.Drawing.Point(247, 212);
            this.MethodsList.MaximumSize = new System.Drawing.Size(200, 100);
            this.MethodsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.MethodsList.Name = "MethodsList";
            this.MethodsList.Size = new System.Drawing.Size(200, 100);
            this.MethodsList.TabIndex = 15;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 410);
            this.Controls.Add(this.MethodsList);
            this.Controls.Add(this.checkBox1);
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
            this.Controls.Add(this.label1);
            this.Name = "AddClassForm";
            this.Text = "Add Class";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
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
        private CheckBox checkBox1;
        private Label MethodsList;
        private ErrorProvider errorProvider;
    }
}