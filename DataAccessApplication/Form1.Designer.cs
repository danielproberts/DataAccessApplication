namespace DataAccessApplication
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblStatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnViewDatabase = new System.Windows.Forms.Button();
            this.btnCountRecords = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.boxTableSelect = new System.Windows.Forms.ComboBox();
            this.lblTableSelect = new System.Windows.Forms.Label();
            this.lblNumOfRecords = new System.Windows.Forms.Label();
            this.lblStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.lblStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.lblStatusBar.Location = new System.Drawing.Point(0, 1399);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(2884, 22);
            this.lblStatusBar.TabIndex = 4;
            this.lblStatusBar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 12);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(2794, 1000);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnViewDatabase
            // 
            this.btnViewDatabase.Location = new System.Drawing.Point(92, 1094);
            this.btnViewDatabase.Name = "btnViewDatabase";
            this.btnViewDatabase.Size = new System.Drawing.Size(318, 82);
            this.btnViewDatabase.TabIndex = 6;
            this.btnViewDatabase.Text = "View Records";
            this.btnViewDatabase.UseVisualStyleBackColor = true;
            this.btnViewDatabase.Click += new System.EventHandler(this.btnViewDatabase_Click);
            // 
            // btnCountRecords
            // 
            this.btnCountRecords.Location = new System.Drawing.Point(92, 1197);
            this.btnCountRecords.Name = "btnCountRecords";
            this.btnCountRecords.Size = new System.Drawing.Size(318, 84);
            this.btnCountRecords.TabIndex = 7;
            this.btnCountRecords.Text = "Count Records";
            this.btnCountRecords.UseVisualStyleBackColor = true;
            this.btnCountRecords.Click += new System.EventHandler(this.btnCountRecords_Click);
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Location = new System.Drawing.Point(1054, 1197);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(97, 38);
            this.lblCount.TabIndex = 8;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxTableSelect
            // 
            this.boxTableSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTableSelect.FormattingEnabled = true;
            this.boxTableSelect.Items.AddRange(new object[] {
            "Customers",
            "Employees",
            "Orders"});
            this.boxTableSelect.Location = new System.Drawing.Point(1051, 1128);
            this.boxTableSelect.Name = "boxTableSelect";
            this.boxTableSelect.Size = new System.Drawing.Size(264, 33);
            this.boxTableSelect.TabIndex = 9;
            // 
            // lblTableSelect
            // 
            this.lblTableSelect.Location = new System.Drawing.Point(711, 1128);
            this.lblTableSelect.Name = "lblTableSelect";
            this.lblTableSelect.Size = new System.Drawing.Size(277, 48);
            this.lblTableSelect.TabIndex = 10;
            this.lblTableSelect.Text = "Table:";
            // 
            // lblNumOfRecords
            // 
            this.lblNumOfRecords.Location = new System.Drawing.Point(711, 1197);
            this.lblNumOfRecords.Name = "lblNumOfRecords";
            this.lblNumOfRecords.Size = new System.Drawing.Size(277, 48);
            this.lblNumOfRecords.TabIndex = 11;
            this.lblNumOfRecords.Text = "Number of Records:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2884, 1421);
            this.Controls.Add(this.lblNumOfRecords);
            this.Controls.Add(this.lblTableSelect);
            this.Controls.Add(this.boxTableSelect);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnCountRecords);
            this.Controls.Add(this.lblStatusBar);
            this.Controls.Add(this.btnViewDatabase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblStatusBar.ResumeLayout(false);
            this.lblStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip lblStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewDatabase;
        private System.Windows.Forms.Button btnCountRecords;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ComboBox boxTableSelect;
        private System.Windows.Forms.Label lblTableSelect;
        private System.Windows.Forms.Label lblNumOfRecords;
    }
}

