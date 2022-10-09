namespace UMLdiagram.Forms
{
    partial class RemovePMForm
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
            this.listBox_Properties = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_RemoveProps = new System.Windows.Forms.Button();
            this.button_RemoveMethods = new System.Windows.Forms.Button();
            this.listBox_Methods = new System.Windows.Forms.CheckedListBox();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Properties
            // 
            this.listBox_Properties.FormattingEnabled = true;
            this.listBox_Properties.Location = new System.Drawing.Point(21, 54);
            this.listBox_Properties.Name = "listBox_Properties";
            this.listBox_Properties.Size = new System.Drawing.Size(201, 310);
            this.listBox_Properties.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Properties";
            // 
            // button_RemoveProps
            // 
            this.button_RemoveProps.Location = new System.Drawing.Point(21, 380);
            this.button_RemoveProps.Name = "button_RemoveProps";
            this.button_RemoveProps.Size = new System.Drawing.Size(201, 23);
            this.button_RemoveProps.TabIndex = 4;
            this.button_RemoveProps.Text = "Remove Selected Properties";
            this.button_RemoveProps.UseVisualStyleBackColor = true;
            this.button_RemoveProps.Click += new System.EventHandler(this.button_RemoveProps_Click);
            // 
            // button_RemoveMethods
            // 
            this.button_RemoveMethods.Location = new System.Drawing.Point(284, 380);
            this.button_RemoveMethods.Name = "button_RemoveMethods";
            this.button_RemoveMethods.Size = new System.Drawing.Size(201, 23);
            this.button_RemoveMethods.TabIndex = 5;
            this.button_RemoveMethods.Text = "Remove Selected Methods";
            this.button_RemoveMethods.UseVisualStyleBackColor = true;
            this.button_RemoveMethods.Click += new System.EventHandler(this.button_RemoveMethods_Click);
            // 
            // listBox_Methods
            // 
            this.listBox_Methods.FormattingEnabled = true;
            this.listBox_Methods.Location = new System.Drawing.Point(284, 54);
            this.listBox_Methods.Name = "listBox_Methods";
            this.listBox_Methods.Size = new System.Drawing.Size(201, 310);
            this.listBox_Methods.TabIndex = 3;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(410, 451);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 7;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(284, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Methods";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(329, 451);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // RemovePMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 486);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.listBox_Methods);
            this.Controls.Add(this.button_RemoveMethods);
            this.Controls.Add(this.button_RemoveProps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Properties);
            this.Name = "RemovePMForm";
            this.Text = "Remove Properties or Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckedListBox listBox_Properties;
        private Label label1;
        private Button button_RemoveProps;
        private Button button_RemoveMethods;
        private CheckedListBox listBox_Methods;
        private Button button_Confirm;
        private Label label2;
        private Button button_Cancel;
    }
}