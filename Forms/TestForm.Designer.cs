namespace ScheduleR.Forms
{
    partial class TestForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.myDataGridView1 = new ScheduleR.Classes.MyDataGridView();
            this.headingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AllowUserToAddRows = false;
            this.myDataGridView1.AllowUserToDeleteRows = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headingCol,
            this.textCol,
            this.beginDTCol,
            this.endDTCol});
            this.myDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.ReadOnly = true;
            this.myDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.myDataGridView1.Size = new System.Drawing.Size(800, 450);
            this.myDataGridView1.TabIndex = 0;
            // 
            // headingCol
            // 
            this.headingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.headingCol.HeaderText = "Heading";
            this.headingCol.Name = "headingCol";
            this.headingCol.ReadOnly = true;
            this.headingCol.Width = 72;
            // 
            // textCol
            // 
            this.textCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textCol.HeaderText = "Text";
            this.textCol.Name = "textCol";
            this.textCol.ReadOnly = true;
            // 
            // beginDTCol
            // 
            this.beginDTCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.beginDTCol.HeaderText = "Begin date and time";
            this.beginDTCol.Name = "beginDTCol";
            this.beginDTCol.ReadOnly = true;
            this.beginDTCol.Width = 98;
            // 
            // endDTCol
            // 
            this.endDTCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.endDTCol.HeaderText = "End date and time";
            this.endDTCol.Name = "endDTCol";
            this.endDTCol.ReadOnly = true;
            this.endDTCol.Width = 91;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myDataGridView1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Classes.MyDataGridView myDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn headingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn textCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDTCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDTCol;
    }
}