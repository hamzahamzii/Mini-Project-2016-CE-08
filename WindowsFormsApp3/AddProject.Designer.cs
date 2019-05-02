namespace WindowsFormsApp3
{
    partial class AddProject
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
            this.Title = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ProjectTitleTextBox = new System.Windows.Forms.TextBox();
            this.AddStudentSaveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ProjectDescriptionLabel = new System.Windows.Forms.Label();
            this.ProjectDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.epDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("PanRoman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Title.Location = new System.Drawing.Point(234, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(225, 58);
            this.Title.TabIndex = 0;
            this.Title.Text = "Add Project";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBtn.Location = new System.Drawing.Point(124, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(216, 46);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ProjectTitleTextBox
            // 
            this.ProjectTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectTitleTextBox.Location = new System.Drawing.Point(166, 74);
            this.ProjectTitleTextBox.Name = "ProjectTitleTextBox";
            this.ProjectTitleTextBox.Size = new System.Drawing.Size(448, 20);
            this.ProjectTitleTextBox.TabIndex = 12;
            // 
            // AddStudentSaveBtn
            // 
            this.AddStudentSaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddStudentSaveBtn.Location = new System.Drawing.Point(467, 3);
            this.AddStudentSaveBtn.Name = "AddStudentSaveBtn";
            this.AddStudentSaveBtn.Size = new System.Drawing.Size(224, 46);
            this.AddStudentSaveBtn.TabIndex = 0;
            this.AddStudentSaveBtn.Text = "Save";
            this.AddStudentSaveBtn.UseVisualStyleBackColor = true;
            this.AddStudentSaveBtn.Click += new System.EventHandler(this.AddStudentSaveBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.90647F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.09352F));
            this.tableLayoutPanel3.Controls.Add(this.AddStudentSaveBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BackBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 287);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(694, 52);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ProjectTitleLabel
            // 
            this.ProjectTitleLabel.AutoSize = true;
            this.ProjectTitleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProjectTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitleLabel.Location = new System.Drawing.Point(3, 71);
            this.ProjectTitleLabel.Name = "ProjectTitleLabel";
            this.ProjectTitleLabel.Size = new System.Drawing.Size(157, 71);
            this.ProjectTitleLabel.TabIndex = 7;
            this.ProjectTitleLabel.Text = "Title";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.54268F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.45731F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Controls.Add(this.ProjectTitleTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ProjectTitleLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ProjectDescriptionLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProjectDescriptionRichTextBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 214);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ProjectDescriptionLabel
            // 
            this.ProjectDescriptionLabel.AutoSize = true;
            this.ProjectDescriptionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProjectDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDescriptionLabel.Location = new System.Drawing.Point(3, 0);
            this.ProjectDescriptionLabel.Name = "ProjectDescriptionLabel";
            this.ProjectDescriptionLabel.Size = new System.Drawing.Size(157, 71);
            this.ProjectDescriptionLabel.TabIndex = 1;
            this.ProjectDescriptionLabel.Text = "Description";
            // 
            // ProjectDescriptionRichTextBox
            // 
            this.ProjectDescriptionRichTextBox.Location = new System.Drawing.Point(166, 3);
            this.ProjectDescriptionRichTextBox.Name = "ProjectDescriptionRichTextBox";
            this.ProjectDescriptionRichTextBox.Size = new System.Drawing.Size(448, 65);
            this.ProjectDescriptionRichTextBox.TabIndex = 13;
            this.ProjectDescriptionRichTextBox.Text = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.Title, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(694, 58);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.77395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.36781F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.85824F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 342);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // epDescription
            // 
            this.epDescription.ContainerControl = this;
            // 
            // epTitle
            // 
            this.epTitle.ContainerControl = this;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox ProjectTitleTextBox;
        private System.Windows.Forms.Button AddStudentSaveBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label ProjectTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ProjectDescriptionLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox ProjectDescriptionRichTextBox;
        private System.Windows.Forms.ErrorProvider epDescription;
        private System.Windows.Forms.ErrorProvider epTitle;
    }
}