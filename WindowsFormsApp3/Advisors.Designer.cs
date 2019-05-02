namespace WindowsFormsApp3
{
    partial class Advisors
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddAdvisorBtn = new System.Windows.Forms.Button();
            this.AdvisorsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AdvisorsGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateAdvisorBtn = new System.Windows.Forms.Button();
            this.DeleteAdvisorBtn = new System.Windows.Forms.Button();
            this.BackAdvisorsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvisorsGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.90654F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.09346F));
            this.tableLayoutPanel2.Controls.Add(this.AddAdvisorBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AdvisorsLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(739, 57);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // AddAdvisorBtn
            // 
            this.AddAdvisorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAdvisorBtn.AutoSize = true;
            this.AddAdvisorBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddAdvisorBtn.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.AddAdvisorBtn.Location = new System.Drawing.Point(607, 11);
            this.AddAdvisorBtn.Name = "AddAdvisorBtn";
            this.AddAdvisorBtn.Size = new System.Drawing.Size(41, 35);
            this.AddAdvisorBtn.TabIndex = 0;
            this.AddAdvisorBtn.Text = "+";
            this.AddAdvisorBtn.UseVisualStyleBackColor = false;
            this.AddAdvisorBtn.Click += new System.EventHandler(this.AddAdvisorBtn_Click);
            // 
            // AdvisorsLabel
            // 
            this.AdvisorsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdvisorsLabel.AutoSize = true;
            this.AdvisorsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdvisorsLabel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvisorsLabel.Location = new System.Drawing.Point(167, 8);
            this.AdvisorsLabel.Name = "AdvisorsLabel";
            this.AdvisorsLabel.Size = new System.Drawing.Size(181, 41);
            this.AdvisorsLabel.TabIndex = 1;
            this.AdvisorsLabel.Text = "ADVISORS";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 368);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48148F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel3.Controls.Add(this.AdvisorsGridView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 66);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(739, 299);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // AdvisorsGridView
            // 
            this.AdvisorsGridView.AllowUserToAddRows = false;
            this.AdvisorsGridView.AllowUserToDeleteRows = false;
            this.AdvisorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdvisorsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvisorsGridView.Location = new System.Drawing.Point(3, 3);
            this.AdvisorsGridView.Name = "AdvisorsGridView";
            this.AdvisorsGridView.ReadOnly = true;
            this.AdvisorsGridView.Size = new System.Drawing.Size(596, 293);
            this.AdvisorsGridView.TabIndex = 0;
            this.AdvisorsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdvisorsGridView_CellContentClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.UpdateAdvisorBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DeleteAdvisorBtn, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BackAdvisorsBtn, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(605, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(99, 231);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // UpdateAdvisorBtn
            // 
            this.UpdateAdvisorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateAdvisorBtn.Location = new System.Drawing.Point(3, 3);
            this.UpdateAdvisorBtn.Name = "UpdateAdvisorBtn";
            this.UpdateAdvisorBtn.Size = new System.Drawing.Size(93, 64);
            this.UpdateAdvisorBtn.TabIndex = 0;
            this.UpdateAdvisorBtn.Text = "Update";
            this.UpdateAdvisorBtn.UseVisualStyleBackColor = true;
            this.UpdateAdvisorBtn.Click += new System.EventHandler(this.UpdateAdvisorBtn_Click);
            // 
            // DeleteAdvisorBtn
            // 
            this.DeleteAdvisorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteAdvisorBtn.Location = new System.Drawing.Point(3, 73);
            this.DeleteAdvisorBtn.Name = "DeleteAdvisorBtn";
            this.DeleteAdvisorBtn.Size = new System.Drawing.Size(93, 72);
            this.DeleteAdvisorBtn.TabIndex = 1;
            this.DeleteAdvisorBtn.Text = "Delete";
            this.DeleteAdvisorBtn.UseVisualStyleBackColor = true;
            this.DeleteAdvisorBtn.Click += new System.EventHandler(this.DeleteAdvisorBtn_Click);
            // 
            // BackAdvisorsBtn
            // 
            this.BackAdvisorsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackAdvisorsBtn.Location = new System.Drawing.Point(3, 151);
            this.BackAdvisorsBtn.Name = "BackAdvisorsBtn";
            this.BackAdvisorsBtn.Size = new System.Drawing.Size(93, 77);
            this.BackAdvisorsBtn.TabIndex = 2;
            this.BackAdvisorsBtn.Text = "Back";
            this.BackAdvisorsBtn.UseVisualStyleBackColor = true;
            this.BackAdvisorsBtn.Click += new System.EventHandler(this.BackAdvisorsBtn_Click);
            // 
            // Advisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 368);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Advisors";
            this.Text = "Advisors";
            this.Load += new System.EventHandler(this.Advisors_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvisorsGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddAdvisorBtn;
        private System.Windows.Forms.Label AdvisorsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView AdvisorsGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button UpdateAdvisorBtn;
        private System.Windows.Forms.Button DeleteAdvisorBtn;
        private System.Windows.Forms.Button BackAdvisorsBtn;
    }
}