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
            this.label_ModeDisplay = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_GenerateCode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 508);
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
            this.button_AddClass.Location = new System.Drawing.Point(8, 22);
            this.button_AddClass.Name = "button_AddClass";
            this.button_AddClass.Size = new System.Drawing.Size(110, 25);
            this.button_AddClass.TabIndex = 0;
            this.button_AddClass.Text = "New Class";
            this.button_AddClass.UseVisualStyleBackColor = true;
            this.button_AddClass.Click += new System.EventHandler(this.button_AddClass_Click);
            // 
            // button_RemoveClass
            // 
            this.button_RemoveClass.Location = new System.Drawing.Point(6, 53);
            this.button_RemoveClass.Name = "button_RemoveClass";
            this.button_RemoveClass.Size = new System.Drawing.Size(110, 25);
            this.button_RemoveClass.TabIndex = 2;
            this.button_RemoveClass.Text = "Remove Class";
            this.button_RemoveClass.UseVisualStyleBackColor = true;
            this.button_RemoveClass.Click += new System.EventHandler(this.button_RemoveClass_Click);
            // 
            // button_EditClass
            // 
            this.button_EditClass.Location = new System.Drawing.Point(124, 22);
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
            this.button_ClearPicbox.Location = new System.Drawing.Point(793, 87);
            this.button_ClearPicbox.Name = "button_ClearPicbox";
            this.button_ClearPicbox.Size = new System.Drawing.Size(116, 25);
            this.button_ClearPicbox.TabIndex = 6;
            this.button_ClearPicbox.Text = "Clear ALL";
            this.button_ClearPicbox.UseVisualStyleBackColor = false;
            this.button_ClearPicbox.Click += new System.EventHandler(this.button_ClearPicbox_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(6, 22);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(125, 25);
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
            this.comboBox_ArrowType.Location = new System.Drawing.Point(137, 24);
            this.comboBox_ArrowType.Name = "comboBox_ArrowType";
            this.comboBox_ArrowType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ArrowType.TabIndex = 4;
            // 
            // button_RemoveConnection
            // 
            this.button_RemoveConnection.Location = new System.Drawing.Point(6, 53);
            this.button_RemoveConnection.Name = "button_RemoveConnection";
            this.button_RemoveConnection.Size = new System.Drawing.Size(125, 25);
            this.button_RemoveConnection.TabIndex = 5;
            this.button_RemoveConnection.Text = "Remove Connection";
            this.button_RemoveConnection.UseVisualStyleBackColor = true;
            this.button_RemoveConnection.Click += new System.EventHandler(this.button_RemoveConnection_Click);
            // 
            // label_ModeDisplay
            // 
            this.label_ModeDisplay.AutoSize = true;
            this.label_ModeDisplay.Location = new System.Drawing.Point(340, 148);
            this.label_ModeDisplay.MinimumSize = new System.Drawing.Size(110, 0);
            this.label_ModeDisplay.Name = "label_ModeDisplay";
            this.label_ModeDisplay.Size = new System.Drawing.Size(110, 15);
            this.label_ModeDisplay.TabIndex = 7;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(656, 56);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(55, 25);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(717, 56);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(55, 25);
            this.button_Load.TabIndex = 9;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_GenerateCode
            // 
            this.button_GenerateCode.Location = new System.Drawing.Point(656, 87);
            this.button_GenerateCode.Name = "button_GenerateCode";
            this.button_GenerateCode.Size = new System.Drawing.Size(116, 25);
            this.button_GenerateCode.TabIndex = 10;
            this.button_GenerateCode.Text = "Generate Code";
            this.button_GenerateCode.UseVisualStyleBackColor = true;
            this.button_GenerateCode.Click += new System.EventHandler(this.button_GenerateCode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AddClass);
            this.groupBox1.Controls.Add(this.button_EditClass);
            this.groupBox1.Controls.Add(this.button_RemoveClass);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Connect);
            this.groupBox2.Controls.Add(this.comboBox_ArrowType);
            this.groupBox2.Controls.Add(this.button_RemoveConnection);
            this.groupBox2.Location = new System.Drawing.Point(364, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connections";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_GenerateCode);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_ModeDisplay);
            this.Controls.Add(this.button_ClearPicbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "UML Diagram Maker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label_ModeDisplay;
        private Button button_Save;
        private Button button_Load;
        private Button button_GenerateCode;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}