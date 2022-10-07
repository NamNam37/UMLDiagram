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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_AddClass = new System.Windows.Forms.Button();
            this.button_RemoveClass = new System.Windows.Forms.Button();
            this.button_EditClass = new System.Windows.Forms.Button();
            this.button_ClearPicbox = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(140, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 528);
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
            this.button_AddClass.Size = new System.Drawing.Size(112, 23);
            this.button_AddClass.TabIndex = 1;
            this.button_AddClass.Text = "New Class";
            this.button_AddClass.UseVisualStyleBackColor = true;
            this.button_AddClass.Click += new System.EventHandler(this.button_AddClass_Click);
            // 
            // button_RemoveClass
            // 
            this.button_RemoveClass.Location = new System.Drawing.Point(12, 41);
            this.button_RemoveClass.Name = "button_RemoveClass";
            this.button_RemoveClass.Size = new System.Drawing.Size(112, 23);
            this.button_RemoveClass.TabIndex = 2;
            this.button_RemoveClass.Text = "Remove Class";
            this.button_RemoveClass.UseVisualStyleBackColor = true;
            this.button_RemoveClass.Click += new System.EventHandler(this.button_RemoveClass_Click);
            // 
            // button_EditClass
            // 
            this.button_EditClass.Location = new System.Drawing.Point(12, 70);
            this.button_EditClass.Name = "button_EditClass";
            this.button_EditClass.Size = new System.Drawing.Size(112, 23);
            this.button_EditClass.TabIndex = 3;
            this.button_EditClass.Text = "Edit Class";
            this.button_EditClass.UseVisualStyleBackColor = true;
            this.button_EditClass.Click += new System.EventHandler(this.button_EditClass_Click);
            // 
            // button_ClearPicbox
            // 
            this.button_ClearPicbox.BackColor = System.Drawing.Color.OrangeRed;
            this.button_ClearPicbox.Location = new System.Drawing.Point(12, 99);
            this.button_ClearPicbox.Name = "button_ClearPicbox";
            this.button_ClearPicbox.Size = new System.Drawing.Size(112, 23);
            this.button_ClearPicbox.TabIndex = 4;
            this.button_ClearPicbox.Text = "Clear ALL";
            this.button_ClearPicbox.UseVisualStyleBackColor = false;
            this.button_ClearPicbox.Click += new System.EventHandler(this.button_ClearPicbox_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 244);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 552);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
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
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private System.Windows.Forms.Timer timer1;
    }
}