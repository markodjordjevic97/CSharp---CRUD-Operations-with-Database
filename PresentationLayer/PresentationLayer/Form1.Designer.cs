namespace PresentationLayer
{
    partial class Form1
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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showStudents = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameStudent = new System.Windows.Forms.TextBox();
            this.indexStudent = new System.Windows.Forms.TextBox();
            this.averageStudent = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.updateStudent = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 20;
            this.listBoxStudents.Location = new System.Drawing.Point(25, 74);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(261, 264);
            this.listBoxStudents.TabIndex = 0;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Students";
            // 
            // showStudents
            // 
            this.showStudents.Location = new System.Drawing.Point(78, 363);
            this.showStudents.Name = "showStudents";
            this.showStudents.Size = new System.Drawing.Size(142, 43);
            this.showStudents.TabIndex = 2;
            this.showStudents.Text = "Show Students";
            this.showStudents.UseVisualStyleBackColor = true;
            this.showStudents.Click += new System.EventHandler(this.showStudents_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IndexNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Student";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Average Mark";
            // 
            // nameStudent
            // 
            this.nameStudent.Location = new System.Drawing.Point(563, 71);
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.Size = new System.Drawing.Size(143, 26);
            this.nameStudent.TabIndex = 8;
            // 
            // indexStudent
            // 
            this.indexStudent.Location = new System.Drawing.Point(565, 117);
            this.indexStudent.Name = "indexStudent";
            this.indexStudent.Size = new System.Drawing.Size(140, 26);
            this.indexStudent.TabIndex = 9;
            // 
            // averageStudent
            // 
            this.averageStudent.Location = new System.Drawing.Point(567, 163);
            this.averageStudent.Name = "averageStudent";
            this.averageStudent.Size = new System.Drawing.Size(138, 26);
            this.averageStudent.TabIndex = 10;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(409, 238);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 38);
            this.add.TabIndex = 11;
            this.add.Text = "Add Student";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // updateStudent
            // 
            this.updateStudent.Location = new System.Drawing.Point(523, 238);
            this.updateStudent.Name = "updateStudent";
            this.updateStudent.Size = new System.Drawing.Size(129, 38);
            this.updateStudent.TabIndex = 12;
            this.updateStudent.Text = "Update student";
            this.updateStudent.UseVisualStyleBackColor = true;
            this.updateStudent.Click += new System.EventHandler(this.updateStudent_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(658, 238);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(123, 37);
            this.deleteStudent.TabIndex = 13;
            this.deleteStudent.Text = "Delete student";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.updateStudent);
            this.Controls.Add(this.add);
            this.Controls.Add(this.averageStudent);
            this.Controls.Add(this.indexStudent);
            this.Controls.Add(this.nameStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameStudent;
        private System.Windows.Forms.TextBox indexStudent;
        private System.Windows.Forms.TextBox averageStudent;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button updateStudent;
        private System.Windows.Forms.Button deleteStudent;
    }
}

