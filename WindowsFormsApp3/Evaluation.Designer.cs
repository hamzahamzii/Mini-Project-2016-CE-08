namespace WindowsFormsApp3
{
    partial class Evaluation
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
            this.DeleteEvaluationsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddEvaluationsBtn = new System.Windows.Forms.Button();
            this.EvaluationsLavel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.EvaluationsGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateEvaluationsBtn = new System.Windows.Forms.Button();
            this.BackEvaluationsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvaluationsGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteEvaluationsBtn
            // 
            this.DeleteEvaluationsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteEvaluationsBtn.Location = new System.Drawing.Point(3, 73);
            this.DeleteEvaluationsBtn.Name = "DeleteEvaluationsBtn";
            this.DeleteEvaluationsBtn.Size = new System.Drawing.Size(93, 72);
            this.DeleteEvaluationsBtn.TabIndex = 1;
            this.DeleteEvaluationsBtn.Text = "Delete";
            this.DeleteEvaluationsBtn.UseVisualStyleBackColor = true;
            this.DeleteEvaluationsBtn.Click += new System.EventHandler(this.DeleteEvaluationsBtn_Click);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 354);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.90654F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.09346F));
            this.tableLayoutPanel2.Controls.Add(this.AddEvaluationsBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.EvaluationsLavel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(712, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // AddEvaluationsBtn
            // 
            this.AddEvaluationsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEvaluationsBtn.AutoSize = true;
            this.AddEvaluationsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddEvaluationsBtn.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.AddEvaluationsBtn.Location = new System.Drawing.Point(584, 11);
            this.AddEvaluationsBtn.Name = "AddEvaluationsBtn";
            this.AddEvaluationsBtn.Size = new System.Drawing.Size(41, 32);
            this.AddEvaluationsBtn.TabIndex = 0;
            this.AddEvaluationsBtn.Text = "+";
            this.AddEvaluationsBtn.UseVisualStyleBackColor = false;
            this.AddEvaluationsBtn.Click += new System.EventHandler(this.AddEvaluationsBtn_Click);
            // 
            // EvaluationsLavel
            // 
            this.EvaluationsLavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EvaluationsLavel.AutoSize = true;
            this.EvaluationsLavel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EvaluationsLavel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationsLavel.Location = new System.Drawing.Point(129, 6);
            this.EvaluationsLavel.Name = "EvaluationsLavel";
            this.EvaluationsLavel.Size = new System.Drawing.Size(238, 41);
            this.EvaluationsLavel.TabIndex = 1;
            this.EvaluationsLavel.Text = "EVALUATIONS";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48148F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel3.Controls.Add(this.EvaluationsGridView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(712, 288);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // EvaluationsGridView
            // 
            this.EvaluationsGridView.AllowUserToAddRows = false;
            this.EvaluationsGridView.AllowUserToDeleteRows = false;
            this.EvaluationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EvaluationsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluationsGridView.Location = new System.Drawing.Point(3, 3);
            this.EvaluationsGridView.Name = "EvaluationsGridView";
            this.EvaluationsGridView.ReadOnly = true;
            this.EvaluationsGridView.Size = new System.Drawing.Size(574, 282);
            this.EvaluationsGridView.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.UpdateEvaluationsBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DeleteEvaluationsBtn, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BackEvaluationsBtn, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(583, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(99, 231);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // UpdateEvaluationsBtn
            // 
            this.UpdateEvaluationsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateEvaluationsBtn.Location = new System.Drawing.Point(3, 3);
            this.UpdateEvaluationsBtn.Name = "UpdateEvaluationsBtn";
            this.UpdateEvaluationsBtn.Size = new System.Drawing.Size(93, 64);
            this.UpdateEvaluationsBtn.TabIndex = 0;
            this.UpdateEvaluationsBtn.Text = "Update";
            this.UpdateEvaluationsBtn.UseVisualStyleBackColor = true;
            this.UpdateEvaluationsBtn.Click += new System.EventHandler(this.UpdateEvaluationsBtn_Click);
            // 
            // BackEvaluationsBtn
            // 
            this.BackEvaluationsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackEvaluationsBtn.Location = new System.Drawing.Point(3, 151);
            this.BackEvaluationsBtn.Name = "BackEvaluationsBtn";
            this.BackEvaluationsBtn.Size = new System.Drawing.Size(93, 77);
            this.BackEvaluationsBtn.TabIndex = 2;
            this.BackEvaluationsBtn.Text = "Back";
            this.BackEvaluationsBtn.UseVisualStyleBackColor = true;
            this.BackEvaluationsBtn.Click += new System.EventHandler(this.BackEvaluationsBtn_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 354);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EvaluationsGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteEvaluationsBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddEvaluationsBtn;
        private System.Windows.Forms.Label EvaluationsLavel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView EvaluationsGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button UpdateEvaluationsBtn;
        private System.Windows.Forms.Button BackEvaluationsBtn;
    }
}