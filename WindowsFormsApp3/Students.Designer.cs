namespace WindowsFormsApp3
{
    partial class Students
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddStudentsBtn = new System.Windows.Forms.Button();
            this.StudentsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.StudentsGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateStudentBtn = new System.Windows.Forms.Button();
            this.DeleteStudentBtn = new System.Windows.Forms.Button();
            this.BackStudentsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.17172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.82829F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.90654F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.09346F));
            this.tableLayoutPanel2.Controls.Add(this.AddStudentsBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.StudentsLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(663, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // AddStudentsBtn
            // 
            this.AddStudentsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddStudentsBtn.AutoSize = true;
            this.AddStudentsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddStudentsBtn.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.AddStudentsBtn.Location = new System.Drawing.Point(542, 8);
            this.AddStudentsBtn.Name = "AddStudentsBtn";
            this.AddStudentsBtn.Size = new System.Drawing.Size(41, 35);
            this.AddStudentsBtn.TabIndex = 0;
            this.AddStudentsBtn.Text = "+";
            this.AddStudentsBtn.UseVisualStyleBackColor = false;
            this.AddStudentsBtn.Click += new System.EventHandler(this.AddStudentsButton_Click);
            // 
            // StudentsLabel
            // 
            this.StudentsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentsLabel.AutoSize = true;
            this.StudentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StudentsLabel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsLabel.Location = new System.Drawing.Point(140, 5);
            this.StudentsLabel.Name = "StudentsLabel";
            this.StudentsLabel.Size = new System.Drawing.Size(182, 41);
            this.StudentsLabel.TabIndex = 1;
            this.StudentsLabel.Text = "STUDENTS";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48148F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel3.Controls.Add(this.StudentsGridView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(663, 279);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // StudentsGridView
            // 
            this.StudentsGridView.AllowUserToAddRows = false;
            this.StudentsGridView.AllowUserToDeleteRows = false;
            this.StudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsGridView.Location = new System.Drawing.Point(3, 3);
            this.StudentsGridView.Name = "StudentsGridView";
            this.StudentsGridView.ReadOnly = true;
            this.StudentsGridView.Size = new System.Drawing.Size(534, 273);
            this.StudentsGridView.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.UpdateStudentBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DeleteStudentBtn, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BackStudentsBtn, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(543, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(99, 231);
            this.tableLayoutPanel4.TabIndex = 1;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // UpdateStudentBtn
            // 
            this.UpdateStudentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateStudentBtn.Location = new System.Drawing.Point(3, 3);
            this.UpdateStudentBtn.Name = "UpdateStudentBtn";
            this.UpdateStudentBtn.Size = new System.Drawing.Size(93, 64);
            this.UpdateStudentBtn.TabIndex = 0;
            this.UpdateStudentBtn.Text = "Update";
            this.UpdateStudentBtn.UseVisualStyleBackColor = true;
            this.UpdateStudentBtn.Click += new System.EventHandler(this.UpdateStudentBtn_Click);
            // 
            // DeleteStudentBtn
            // 
            this.DeleteStudentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteStudentBtn.Location = new System.Drawing.Point(3, 73);
            this.DeleteStudentBtn.Name = "DeleteStudentBtn";
            this.DeleteStudentBtn.Size = new System.Drawing.Size(93, 72);
            this.DeleteStudentBtn.TabIndex = 1;
            this.DeleteStudentBtn.Text = "Delete";
            this.DeleteStudentBtn.UseVisualStyleBackColor = true;
            this.DeleteStudentBtn.Click += new System.EventHandler(this.DeleteStudentBtn_Click);
            // 
            // BackStudentsBtn
            // 
            this.BackStudentsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackStudentsBtn.Location = new System.Drawing.Point(3, 151);
            this.BackStudentsBtn.Name = "BackStudentsBtn";
            this.BackStudentsBtn.Size = new System.Drawing.Size(93, 77);
            this.BackStudentsBtn.TabIndex = 2;
            this.BackStudentsBtn.Text = "Back";
            this.BackStudentsBtn.UseVisualStyleBackColor = true;
            this.BackStudentsBtn.Click += new System.EventHandler(this.BackStudentsBtn_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView StudentsGridView;
        private System.Windows.Forms.Button AddStudentsBtn;
        private System.Windows.Forms.Label StudentsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button UpdateStudentBtn;
        private System.Windows.Forms.Button DeleteStudentBtn;
        private System.Windows.Forms.Button BackStudentsBtn;
    }
}