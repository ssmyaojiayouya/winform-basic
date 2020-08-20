namespace test
{
    partial class paging_listshow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labPageIndex = new System.Windows.Forms.Label();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.FirstPagBtn = new System.Windows.Forms.Button();
            this.UpPagBtn = new System.Windows.Forms.Button();
            this.NextPagBtn = new System.Windows.Forms.Button();
            this.LastPagBtn = new System.Windows.Forms.Button();
            this.LblCurrentPage = new System.Windows.Forms.Label();
            this.LblTotalPage = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(700, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // labPageIndex
            // 
            this.labPageIndex.AutoSize = true;
            this.labPageIndex.Location = new System.Drawing.Point(44, 409);
            this.labPageIndex.Name = "labPageIndex";
            this.labPageIndex.Size = new System.Drawing.Size(67, 15);
            this.labPageIndex.TabIndex = 1;
            this.labPageIndex.Text = "当前页：";
            // 
            // labRecordCount
            // 
            this.labRecordCount.AutoSize = true;
            this.labRecordCount.Location = new System.Drawing.Point(183, 408);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(82, 15);
            this.labRecordCount.TabIndex = 2;
            this.labRecordCount.Text = "共计条数：";
            // 
            // FirstPagBtn
            // 
            this.FirstPagBtn.Location = new System.Drawing.Point(329, 400);
            this.FirstPagBtn.Name = "FirstPagBtn";
            this.FirstPagBtn.Size = new System.Drawing.Size(75, 23);
            this.FirstPagBtn.TabIndex = 3;
            this.FirstPagBtn.Text = "首页";
            this.FirstPagBtn.UseVisualStyleBackColor = true;
            this.FirstPagBtn.Click += new System.EventHandler(this.FirstPagBtn_Click);
            // 
            // UpPagBtn
            // 
            this.UpPagBtn.Location = new System.Drawing.Point(449, 400);
            this.UpPagBtn.Name = "UpPagBtn";
            this.UpPagBtn.Size = new System.Drawing.Size(75, 23);
            this.UpPagBtn.TabIndex = 4;
            this.UpPagBtn.Text = "上一页";
            this.UpPagBtn.UseVisualStyleBackColor = true;
            this.UpPagBtn.Click += new System.EventHandler(this.UpPagBtn_Click);
            // 
            // NextPagBtn
            // 
            this.NextPagBtn.Location = new System.Drawing.Point(559, 400);
            this.NextPagBtn.Name = "NextPagBtn";
            this.NextPagBtn.Size = new System.Drawing.Size(75, 23);
            this.NextPagBtn.TabIndex = 5;
            this.NextPagBtn.Text = "下一页";
            this.NextPagBtn.UseVisualStyleBackColor = true;
            this.NextPagBtn.Click += new System.EventHandler(this.NextPagBtn_Click);
            // 
            // LastPagBtn
            // 
            this.LastPagBtn.Location = new System.Drawing.Point(663, 401);
            this.LastPagBtn.Name = "LastPagBtn";
            this.LastPagBtn.Size = new System.Drawing.Size(75, 23);
            this.LastPagBtn.TabIndex = 6;
            this.LastPagBtn.Text = "尾页";
            this.LastPagBtn.UseVisualStyleBackColor = true;
            this.LastPagBtn.Click += new System.EventHandler(this.LastPagBtn_Click);
            // 
            // LblCurrentPage
            // 
            this.LblCurrentPage.AutoSize = true;
            this.LblCurrentPage.Location = new System.Drawing.Point(102, 408);
            this.LblCurrentPage.Name = "LblCurrentPage";
            this.LblCurrentPage.Size = new System.Drawing.Size(55, 15);
            this.LblCurrentPage.TabIndex = 7;
            this.LblCurrentPage.Text = "label1";
            // 
            // LblTotalPage
            // 
            this.LblTotalPage.AutoSize = true;
            this.LblTotalPage.Location = new System.Drawing.Point(258, 407);
            this.LblTotalPage.Name = "LblTotalPage";
            this.LblTotalPage.Size = new System.Drawing.Size(55, 15);
            this.LblTotalPage.TabIndex = 8;
            this.LblTotalPage.Text = "label1";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // paging_listshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTotalPage);
            this.Controls.Add(this.LblCurrentPage);
            this.Controls.Add(this.LastPagBtn);
            this.Controls.Add(this.NextPagBtn);
            this.Controls.Add(this.UpPagBtn);
            this.Controls.Add(this.FirstPagBtn);
            this.Controls.Add(this.labRecordCount);
            this.Controls.Add(this.labPageIndex);
            this.Controls.Add(this.dataGridView1);
            this.Name = "paging_listshow";
            this.Text = "paging_listshow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.paging_listshow_FormClosed);
            this.Load += new System.EventHandler(this.paging_listshow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labPageIndex;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.Button FirstPagBtn;
        private System.Windows.Forms.Button UpPagBtn;
        private System.Windows.Forms.Button NextPagBtn;
        private System.Windows.Forms.Button LastPagBtn;
        private System.Windows.Forms.Label LblCurrentPage;
        private System.Windows.Forms.Label LblTotalPage;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}