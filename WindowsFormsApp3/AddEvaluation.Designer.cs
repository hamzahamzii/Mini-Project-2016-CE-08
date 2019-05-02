namespace WindowsFormsApp3
{
    partial class AddEvaluation
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
            this.EvaluationMarksTextBox = new System.Windows.Forms.TextBox();
            this.AddEvaluationSaveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalMarksLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EvaluationNameLabel = new System.Windows.Forms.Label();
            this.EvaluationNameTextBox = new System.Windows.Forms.TextBox();
            this.TotalWeightageTextBox = new System.Windows.Forms.TextBox();
            this.TotalWeightageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTotalMarks = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTotalWeightage = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTotalMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTotalWeightage)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("PanRoman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Title.Location = new System.Drawing.Point(181, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(313, 68);
            this.Title.TabIndex = 0;
            this.Title.Text = "Add Evaluation";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBtn.Location = new System.Drawing.Point(122, 8);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(216, 46);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EvaluationMarksTextBox
            // 
            this.EvaluationMarksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EvaluationMarksTextBox.Location = new System.Drawing.Point(175, 63);
            this.EvaluationMarksTextBox.Name = "EvaluationMarksTextBox";
            this.EvaluationMarksTextBox.Size = new System.Drawing.Size(448, 20);
            this.EvaluationMarksTextBox.TabIndex = 12;
            // 
            // AddEvaluationSaveBtn
            // 
            this.AddEvaluationSaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEvaluationSaveBtn.Location = new System.Drawing.Point(463, 3);
            this.AddEvaluationSaveBtn.Name = "AddEvaluationSaveBtn";
            this.AddEvaluationSaveBtn.Size = new System.Drawing.Size(222, 56);
            this.AddEvaluationSaveBtn.TabIndex = 0;
            this.AddEvaluationSaveBtn.Text = "Save";
            this.AddEvaluationSaveBtn.UseVisualStyleBackColor = true;
            this.AddEvaluationSaveBtn.Click += new System.EventHandler(this.AddEvaluationSaveBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.90647F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.09352F));
            this.tableLayoutPanel3.Controls.Add(this.AddEvaluationSaveBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BackBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 332);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(688, 62);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // TotalMarksLabel
            // 
            this.TotalMarksLabel.AutoSize = true;
            this.TotalMarksLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalMarksLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalMarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarksLabel.Location = new System.Drawing.Point(3, 60);
            this.TotalMarksLabel.Name = "TotalMarksLabel";
            this.TotalMarksLabel.Size = new System.Drawing.Size(166, 49);
            this.TotalMarksLabel.TabIndex = 7;
            this.TotalMarksLabel.Text = "Total Marks";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.45349F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.54651F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Controls.Add(this.EvaluationMarksTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TotalMarksLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.EvaluationNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EvaluationNameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalWeightageTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TotalWeightageLabel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.09639F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.08032F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.82329F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(688, 249);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // EvaluationNameLabel
            // 
            this.EvaluationNameLabel.AutoSize = true;
            this.EvaluationNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EvaluationNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationNameLabel.Location = new System.Drawing.Point(3, 0);
            this.EvaluationNameLabel.Name = "EvaluationNameLabel";
            this.EvaluationNameLabel.Size = new System.Drawing.Size(166, 60);
            this.EvaluationNameLabel.TabIndex = 1;
            this.EvaluationNameLabel.Text = "Name";
            // 
            // EvaluationNameTextBox
            // 
            this.EvaluationNameTextBox.Location = new System.Drawing.Point(175, 3);
            this.EvaluationNameTextBox.Name = "EvaluationNameTextBox";
            this.EvaluationNameTextBox.Size = new System.Drawing.Size(448, 20);
            this.EvaluationNameTextBox.TabIndex = 13;
            // 
            // TotalWeightageTextBox
            // 
            this.TotalWeightageTextBox.Location = new System.Drawing.Point(175, 112);
            this.TotalWeightageTextBox.Name = "TotalWeightageTextBox";
            this.TotalWeightageTextBox.Size = new System.Drawing.Size(448, 20);
            this.TotalWeightageTextBox.TabIndex = 14;
            // 
            // TotalWeightageLabel
            // 
            this.TotalWeightageLabel.AutoSize = true;
            this.TotalWeightageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalWeightageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWeightageLabel.Location = new System.Drawing.Point(3, 109);
            this.TotalWeightageLabel.Name = "TotalWeightageLabel";
            this.TotalWeightageLabel.Size = new System.Drawing.Size(166, 140);
            this.TotalWeightageLabel.TabIndex = 15;
            this.TotalWeightageLabel.Text = "Total Weightage";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.87209F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.36628F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.61628F));
            this.tableLayoutPanel4.Controls.Add(this.Title, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(688, 68);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 397);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // epTotalMarks
            // 
            this.epTotalMarks.ContainerControl = this;
            // 
            // epTotalWeightage
            // 
            this.epTotalWeightage.ContainerControl = this;
            // 
            // AddEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 397);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEvaluation";
            this.Text = "AddEvaluation";
            this.Load += new System.EventHandler(this.AddEvaluation_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTotalMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTotalWeightage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox EvaluationMarksTextBox;
        private System.Windows.Forms.Button AddEvaluationSaveBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label TotalMarksLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label EvaluationNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox EvaluationNameTextBox;
        private System.Windows.Forms.TextBox TotalWeightageTextBox;
        private System.Windows.Forms.Label TotalWeightageLabel;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.ErrorProvider epTotalMarks;
        private System.Windows.Forms.ErrorProvider epTotalWeightage;
    }
}