namespace WindowsFormsApp3
{
    partial class AddEvaluationGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ObtainedMarksTextBox = new System.Windows.Forms.TextBox();
            this.ObtainedMarksLabel = new System.Windows.Forms.Label();
            this.GroupEvaluationDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupEvaluationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GroupEvaluationDataGridView, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Group Evalutaion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.43478F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.56522F));
            this.tableLayoutPanel2.Controls.Add(this.BackBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 348);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(690, 33);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtn.Location = new System.Drawing.Point(557, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(130, 27);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.6087F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.3913F));
            this.tableLayoutPanel3.Controls.Add(this.ObtainedMarksTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ObtainedMarksLabel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(690, 33);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ObtainedMarksTextBox
            // 
            this.ObtainedMarksTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObtainedMarksTextBox.Location = new System.Drawing.Point(228, 3);
            this.ObtainedMarksTextBox.Name = "ObtainedMarksTextBox";
            this.ObtainedMarksTextBox.Size = new System.Drawing.Size(459, 20);
            this.ObtainedMarksTextBox.TabIndex = 0;
            // 
            // ObtainedMarksLabel
            // 
            this.ObtainedMarksLabel.AutoSize = true;
            this.ObtainedMarksLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObtainedMarksLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtainedMarksLabel.Location = new System.Drawing.Point(3, 0);
            this.ObtainedMarksLabel.Name = "ObtainedMarksLabel";
            this.ObtainedMarksLabel.Size = new System.Drawing.Size(219, 33);
            this.ObtainedMarksLabel.TabIndex = 1;
            this.ObtainedMarksLabel.Text = "Obtained Marks";
            this.ObtainedMarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupEvaluationDataGridView
            // 
            this.GroupEvaluationDataGridView.AllowUserToAddRows = false;
            this.GroupEvaluationDataGridView.AllowUserToDeleteRows = false;
            this.GroupEvaluationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupEvaluationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupEvaluationDataGridView.Location = new System.Drawing.Point(3, 79);
            this.GroupEvaluationDataGridView.Name = "GroupEvaluationDataGridView";
            this.GroupEvaluationDataGridView.ReadOnly = true;
            this.GroupEvaluationDataGridView.Size = new System.Drawing.Size(690, 263);
            this.GroupEvaluationDataGridView.TabIndex = 3;
            this.GroupEvaluationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupEvaluationDataGridView_CellContentClick);
            // 
            // AddEvaluationGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEvaluationGroup";
            this.Text = "AddEvaluationGroup";
            this.Load += new System.EventHandler(this.AddEvaluationGroup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupEvaluationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox ObtainedMarksTextBox;
        private System.Windows.Forms.Label ObtainedMarksLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GroupEvaluationDataGridView;
        private System.Windows.Forms.Button BackBtn;
    }
}