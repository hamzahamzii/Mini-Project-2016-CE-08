namespace WindowsFormsApp3
{
    partial class Projects
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
            this.DeleteProjectBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddProjectsBtn = new System.Windows.Forms.Button();
            this.ProjectsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ProjectsGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateProjectBtn = new System.Windows.Forms.Button();
            this.BackProjectBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteProjectBtn
            // 
            this.DeleteProjectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteProjectBtn.Location = new System.Drawing.Point(3, 73);
            this.DeleteProjectBtn.Name = "DeleteProjectBtn";
            this.DeleteProjectBtn.Size = new System.Drawing.Size(93, 72);
            this.DeleteProjectBtn.TabIndex = 1;
            this.DeleteProjectBtn.Text = "Delete";
            this.DeleteProjectBtn.UseVisualStyleBackColor = true;
            this.DeleteProjectBtn.Click += new System.EventHandler(this.DeleteProjectBtn_Click);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 334);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.90654F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.09346F));
            this.tableLayoutPanel2.Controls.Add(this.AddProjectsBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProjectsLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(713, 51);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // AddProjectsBtn
            // 
            this.AddProjectsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProjectsBtn.AutoSize = true;
            this.AddProjectsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddProjectsBtn.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.AddProjectsBtn.Location = new System.Drawing.Point(585, 8);
            this.AddProjectsBtn.Name = "AddProjectsBtn";
            this.AddProjectsBtn.Size = new System.Drawing.Size(41, 35);
            this.AddProjectsBtn.TabIndex = 0;
            this.AddProjectsBtn.Text = "+";
            this.AddProjectsBtn.UseVisualStyleBackColor = false;
            this.AddProjectsBtn.Click += new System.EventHandler(this.AddProjectsBtn_Click);
            // 
            // ProjectsLabel
            // 
            this.ProjectsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProjectsLabel.AutoSize = true;
            this.ProjectsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProjectsLabel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsLabel.Location = new System.Drawing.Point(164, 5);
            this.ProjectsLabel.Name = "ProjectsLabel";
            this.ProjectsLabel.Size = new System.Drawing.Size(169, 41);
            this.ProjectsLabel.TabIndex = 1;
            this.ProjectsLabel.Text = "PROJECTS";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48148F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel3.Controls.Add(this.ProjectsGridView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(713, 271);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ProjectsGridView
            // 
            this.ProjectsGridView.AllowUserToAddRows = false;
            this.ProjectsGridView.AllowUserToDeleteRows = false;
            this.ProjectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsGridView.Location = new System.Drawing.Point(3, 3);
            this.ProjectsGridView.Name = "ProjectsGridView";
            this.ProjectsGridView.ReadOnly = true;
            this.ProjectsGridView.Size = new System.Drawing.Size(574, 265);
            this.ProjectsGridView.TabIndex = 0;
            this.ProjectsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsGridView_CellContentClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.UpdateProjectBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DeleteProjectBtn, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BackProjectBtn, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(583, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(99, 231);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // UpdateProjectBtn
            // 
            this.UpdateProjectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateProjectBtn.Location = new System.Drawing.Point(3, 3);
            this.UpdateProjectBtn.Name = "UpdateProjectBtn";
            this.UpdateProjectBtn.Size = new System.Drawing.Size(93, 64);
            this.UpdateProjectBtn.TabIndex = 0;
            this.UpdateProjectBtn.Text = "Update";
            this.UpdateProjectBtn.UseVisualStyleBackColor = true;
            this.UpdateProjectBtn.Click += new System.EventHandler(this.UpdateProjectBtn_Click);
            // 
            // BackProjectBtn
            // 
            this.BackProjectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackProjectBtn.Location = new System.Drawing.Point(3, 151);
            this.BackProjectBtn.Name = "BackProjectBtn";
            this.BackProjectBtn.Size = new System.Drawing.Size(93, 77);
            this.BackProjectBtn.TabIndex = 2;
            this.BackProjectBtn.Text = "Back";
            this.BackProjectBtn.UseVisualStyleBackColor = true;
            this.BackProjectBtn.Click += new System.EventHandler(this.BackProjectBtn_Click);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 334);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Projects";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Projects_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteProjectBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddProjectsBtn;
        private System.Windows.Forms.Label ProjectsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView ProjectsGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button UpdateProjectBtn;
        private System.Windows.Forms.Button BackProjectBtn;
    }
}