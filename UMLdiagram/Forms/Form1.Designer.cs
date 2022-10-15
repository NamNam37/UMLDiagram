namespace UMLdiagram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_AddClass = new System.Windows.Forms.Button();
            this.button_RemoveClass = new System.Windows.Forms.Button();
            this.button_EditClass = new System.Windows.Forms.Button();
            this.button_ClearPicbox = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.comboBox_ArrowType = new System.Windows.Forms.ComboBox();
            this.button_RemoveConnection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button_AddClass
            // 
            this.button_AddClass.Location = new System.Drawing.Point(12, 12);
            this.button_AddClass.Name = "button_AddClass";
            this.button_AddClass.Size = new System.Drawing.Size(110, 25);
            this.button_AddClass.TabIndex = 0;
            this.button_AddClass.Text = "New Class";
            this.button_AddClass.UseVisualStyleBackColor = true;
            this.button_AddClass.Click += new System.EventHandler(this.button_AddClass_Click);
            // 
            // button_RemoveClass
            // 
            this.button_RemoveClass.Location = new System.Drawing.Point(244, 12);
            this.button_RemoveClass.Name = "button_RemoveClass";
            this.button_RemoveClass.Size = new System.Drawing.Size(110, 25);
            this.button_RemoveClass.TabIndex = 2;
            this.button_RemoveClass.Text = "Remove Class";
            this.button_RemoveClass.UseVisualStyleBackColor = true;
            this.button_RemoveClass.Click += new System.EventHandler(this.button_RemoveClass_Click);
            // 
            // button_EditClass
            // 
            this.button_EditClass.Location = new System.Drawing.Point(128, 12);
            this.button_EditClass.Name = "button_EditClass";
            this.button_EditClass.Size = new System.Drawing.Size(110, 25);
            this.button_EditClass.TabIndex = 1;
            this.button_EditClass.Text = "Edit Class";
            this.button_EditClass.UseVisualStyleBackColor = true;
            this.button_EditClass.Click += new System.EventHandler(this.button_EditClass_Click);
            // 
            // button_ClearPicbox
            // 
            this.button_ClearPicbox.BackColor = System.Drawing.Color.OrangeRed;
            this.button_ClearPicbox.Location = new System.Drawing.Point(862, 12);
            this.button_ClearPicbox.Name = "button_ClearPicbox";
            this.button_ClearPicbox.Size = new System.Drawing.Size(110, 25);
            this.button_ClearPicbox.TabIndex = 6;
            this.button_ClearPicbox.Text = "Clear ALL";
            this.button_ClearPicbox.UseVisualStyleBackColor = false;
            this.button_ClearPicbox.Click += new System.EventHandler(this.button_ClearPicbox_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(360, 12);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(110, 25);
            this.button_Connect.TabIndex = 3;
            this.button_Connect.Text = "Connect Classes";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // comboBox_ArrowType
            // 
            this.comboBox_ArrowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ArrowType.FormattingEnabled = true;
            this.comboBox_ArrowType.Items.AddRange(new object[] {
            "Association",
            "Unidir. Association",
            "Inheritance",
            "Generalization",
            "Realization",
            "Dependency",
            "Abstraction",
            "Substitution",
            "Usage",
            "Aggregation",
            "Composiotion"});
            this.comboBox_ArrowType.Location = new System.Drawing.Point(476, 12);
            this.comboBox_ArrowType.Name = "comboBox_ArrowType";
            this.comboBox_ArrowType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ArrowType.TabIndex = 4;
            // 
            // button_RemoveConnection
            // 
            this.button_RemoveConnection.Location = new System.Drawing.Point(603, 12);
            this.button_RemoveConnection.Name = "button_RemoveConnection";
            this.button_RemoveConnection.Size = new System.Drawing.Size(125, 25);
            this.button_RemoveConnection.TabIndex = 5;
            this.button_RemoveConnection.Text = "Remove Connection";
            this.button_RemoveConnection.UseVisualStyleBackColor = true;
            this.button_RemoveConnection.Click += new System.EventHandler(this.button_RemoveConnection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button_RemoveConnection);
            this.Controls.Add(this.comboBox_ArrowType);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_ClearPicbox);
            this.Controls.Add(this.button_EditClass);
            this.Controls.Add(this.button_RemoveClass);
            this.Controls.Add(this.button_AddClass);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "UML Diagram Maker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_AddClass;
        private Button button_RemoveClass;
        private Button button_EditClass;
        private Button button_ClearPicbox;
        private Button button_Connect;
        private ComboBox comboBox_ArrowType;
        private Button button_RemoveConnection;
    }
}