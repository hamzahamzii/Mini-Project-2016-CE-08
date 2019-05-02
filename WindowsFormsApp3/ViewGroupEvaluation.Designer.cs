namespace WindowsFormsApp3
{
    partial class ViewGroupEvaluation
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.ViewGroupEvalDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupEvaluationsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGroupEvalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ViewGroupEvalDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GroupEvaluationsLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(668, 374);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.6435F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.35649F));
            this.tableLayoutPanel2.Controls.Add(this.BackBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 331);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(662, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtn.Location = new System.Drawing.Point(517, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(142, 34);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ViewGroupEvalDataGridView
            // 
            this.ViewGroupEvalDataGridView.AllowUserToAddRows = false;
            this.ViewGroupEvalDataGridView.AllowUserToDeleteRows = false;
            this.ViewGroupEvalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewGroupEvalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewGroupEvalDataGridView.Location = new System.Drawing.Point(3, 44);
            this.ViewGroupEvalDataGridView.Name = "ViewGroupEvalDataGridView";
            this.ViewGroupEvalDataGridView.ReadOnly = true;
            this.ViewGroupEvalDataGridView.Size = new System.Drawing.Size(662, 281);
            this.ViewGroupEvalDataGridView.TabIndex = 1;
            this.ViewGroupEvalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewGroupEvalDataGridView_CellContentClick);
            // 
            // GroupEvaluationsLabel
            // 
            this.GroupEvaluationsLabel.AutoSize = true;
            this.GroupEvaluationsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupEvaluationsLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupEvaluationsLabel.Location = new System.Drawing.Point(3, 0);
            this.GroupEvaluationsLabel.Name = "GroupEvaluationsLabel";
            this.GroupEvaluationsLabel.Size = new System.Drawing.Size(662, 41);
            this.GroupEvaluationsLabel.TabIndex = 2;
            this.GroupEvaluationsLabel.Text = "Group Evaluations";
            this.GroupEvaluationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewGroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewGroupEvaluation";
            this.Text = "ViewGroupEvaluation";
            this.Load += new System.EventHandler(this.ViewGroupEvaluation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewGroupEvalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView ViewGroupEvalDataGridView;
        private System.Windows.Forms.Label GroupEvaluationsLabel;
    }
}