﻿namespace DataAccessApplication
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
            this.menuStrip1.Size = new System.Drawing.Size(1572, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.lblStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.lblStatusBar.Location = new System.Drawing.Point(0, 931);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(1572, 22);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1244, 324);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnViewDatabase
            // 
            this.btnViewDatabase.Location = new System.Drawing.Point(106, 721);
            this.btnViewDatabase.Name = "btnViewDatabase";
            this.btnViewDatabase.Size = new System.Drawing.Size(1244, 100);
            this.btnViewDatabase.TabIndex = 6;
            this.btnViewDatabase.Text = "View Database";
            this.btnViewDatabase.UseVisualStyleBackColor = true;
            this.btnViewDatabase.Click += new System.EventHandler(this.btnViewDatabase_Click);
            // 
            // btnCountRecords
            // 
            this.btnCountRecords.Location = new System.Drawing.Point(1032, 207);
            this.btnCountRecords.Name = "btnCountRecords";
            this.btnCountRecords.Size = new System.Drawing.Size(318, 84);
            this.btnCountRecords.TabIndex = 7;
            this.btnCountRecords.Text = "Count Records";
            this.btnCountRecords.UseVisualStyleBackColor = true;
            this.btnCountRecords.Click += new System.EventHandler(this.btnCountRecords_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(1034, 109);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(315, 48);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "Number of Records";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1572, 953);
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
    }
}

