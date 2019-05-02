namespace WindowsFormsApp3
{
    partial class MainPage
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
            this.MainPageFYPLabel = new System.Windows.Forms.Label();
            this.StudentBtn = new System.Windows.Forms.Button();
            this.AdvisorsBtn = new System.Windows.Forms.Button();
            this.ProjectsBtn = new System.Windows.Forms.Button();
            this.EvaluationsBtn = new System.Windows.Forms.Button();
            this.GroupsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.MainPageFYPLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StudentBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdvisorsBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProjectsBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EvaluationsBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.GroupsBtn, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.73034F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53933F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.41573F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.57303F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.41573F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.44944F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 356);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // MainPageFYPLabel
            // 
            this.MainPageFYPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPageFYPLabel.AutoSize = true;
            this.MainPageFYPLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPageFYPLabel.Location = new System.Drawing.Point(224, 11);
            this.MainPageFYPLabel.Name = "MainPageFYPLabel";
            this.MainPageFYPLabel.Size = new System.Drawing.Size(295, 32);
            this.MainPageFYPLabel.TabIndex = 0;
            this.MainPageFYPLabel.Text = "FYP Management System";
            // 
            // StudentBtn
            // 
            this.StudentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentBtn.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentBtn.Location = new System.Drawing.Point(3, 58);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.Size = new System.Drawing.Size(738, 59);
            this.StudentBtn.TabIndex = 1;
            this.StudentBtn.Text = "Students";
            this.StudentBtn.UseVisualStyleBackColor = true;
            this.StudentBtn.Click += new System.EventHandler(this.StudentBtn_Click);
            // 
            // AdvisorsBtn
            // 
            this.AdvisorsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvisorsBtn.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvisorsBtn.Location = new System.Drawing.Point(3, 123);
            this.AdvisorsBtn.Name = "AdvisorsBtn";
            this.AdvisorsBtn.Size = new System.Drawing.Size(738, 55);
            this.AdvisorsBtn.TabIndex = 5;
            this.AdvisorsBtn.Text = "Advisors";
            this.AdvisorsBtn.UseVisualStyleBackColor = true;
            this.AdvisorsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectsBtn
            // 
            this.ProjectsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsBtn.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsBtn.Location = new System.Drawing.Point(3, 184);
            this.ProjectsBtn.Name = "ProjectsBtn";
            this.ProjectsBtn.Size = new System.Drawing.Size(738, 52);
            this.ProjectsBtn.TabIndex = 6;
            this.ProjectsBtn.Text = "Projects";
            this.ProjectsBtn.UseVisualStyleBackColor = true;
            this.ProjectsBtn.Click += new System.EventHandler(this.ProjectsBtn_Click_1);
            // 
            // EvaluationsBtn
            // 
            this.EvaluationsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluationsBtn.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationsBtn.Location = new System.Drawing.Point(3, 242);
            this.EvaluationsBtn.Name = "EvaluationsBtn";
            this.EvaluationsBtn.Size = new System.Drawing.Size(738, 55);
            this.EvaluationsBtn.TabIndex = 7;
            this.EvaluationsBtn.Text = "Evaluations";
            this.EvaluationsBtn.UseVisualStyleBackColor = true;
            this.EvaluationsBtn.Click += new System.EventHandler(this.EvaluationsBtn_Click_1);
            // 
            // GroupsBtn
            // 
            this.GroupsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupsBtn.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupsBtn.Location = new System.Drawing.Point(3, 303);
            this.GroupsBtn.Name = "GroupsBtn";
            this.GroupsBtn.Size = new System.Drawing.Size(738, 50);
            this.GroupsBtn.TabIndex = 8;
            this.GroupsBtn.Text = "Groups";
            this.GroupsBtn.UseVisualStyleBackColor = true;
            this.GroupsBtn.Click += new System.EventHandler(this.GroupsBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label MainPageFYPLabel;
        private System.Windows.Forms.Button StudentBtn;
        private System.Windows.Forms.Button AdvisorsBtn;
        private System.Windows.Forms.Button ProjectsBtn;
        private System.Windows.Forms.Button EvaluationsBtn;
        private System.Windows.Forms.Button GroupsBtn;
    }
}