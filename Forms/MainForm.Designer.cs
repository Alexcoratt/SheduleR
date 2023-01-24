
namespace ScheduleR
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserTabControl = new System.Windows.Forms.TabControl();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventCreateButton = new System.Windows.Forms.Button();
            this.eventUpdateButton = new System.Windows.Forms.Button();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.eventPublishButton = new System.Windows.Forms.Button();
            this.eventUnpublishButton = new System.Windows.Forms.Button();
            this.eventGridView = new ScheduleR.Classes.MyDataGridView();
            this.beginDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublicEventCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserTabControl.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.tabPageEvents);
            this.UserTabControl.Controls.Add(this.tabPage2);
            this.UserTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTabControl.Location = new System.Drawing.Point(0, 24);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(680, 429);
            this.UserTabControl.TabIndex = 0;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.AutoScroll = true;
            this.tabPageEvents.Controls.Add(this.eventUnpublishButton);
            this.tabPageEvents.Controls.Add(this.eventPublishButton);
            this.tabPageEvents.Controls.Add(this.deleteEventButton);
            this.tabPageEvents.Controls.Add(this.eventUpdateButton);
            this.tabPageEvents.Controls.Add(this.eventCreateButton);
            this.tabPageEvents.Controls.Add(this.eventGridView);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvents.Size = new System.Drawing.Size(672, 403);
            this.tabPageEvents.TabIndex = 0;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // eventCreateButton
            // 
            this.eventCreateButton.Location = new System.Drawing.Point(547, 74);
            this.eventCreateButton.Name = "eventCreateButton";
            this.eventCreateButton.Size = new System.Drawing.Size(117, 28);
            this.eventCreateButton.TabIndex = 2;
            this.eventCreateButton.Text = "Create event";
            this.eventCreateButton.UseVisualStyleBackColor = true;
            // 
            // eventUpdateButton
            // 
            this.eventUpdateButton.Location = new System.Drawing.Point(547, 108);
            this.eventUpdateButton.Name = "eventUpdateButton";
            this.eventUpdateButton.Size = new System.Drawing.Size(117, 28);
            this.eventUpdateButton.TabIndex = 3;
            this.eventUpdateButton.Text = "Update event";
            this.eventUpdateButton.UseVisualStyleBackColor = true;
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Location = new System.Drawing.Point(547, 142);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(117, 28);
            this.deleteEventButton.TabIndex = 4;
            this.deleteEventButton.Text = "Delete event";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            // 
            // eventPublishButton
            // 
            this.eventPublishButton.Location = new System.Drawing.Point(547, 40);
            this.eventPublishButton.Name = "eventPublishButton";
            this.eventPublishButton.Size = new System.Drawing.Size(117, 28);
            this.eventPublishButton.TabIndex = 5;
            this.eventPublishButton.Text = "Publish event";
            this.eventPublishButton.UseVisualStyleBackColor = true;
            // 
            // eventUnpublishButton
            // 
            this.eventUnpublishButton.Location = new System.Drawing.Point(547, 6);
            this.eventUnpublishButton.Name = "eventUnpublishButton";
            this.eventUnpublishButton.Size = new System.Drawing.Size(117, 28);
            this.eventUnpublishButton.TabIndex = 6;
            this.eventUnpublishButton.Text = "Unublish event";
            this.eventUnpublishButton.UseVisualStyleBackColor = true;
            // 
            // eventGridView
            // 
            this.eventGridView.AllowUserToAddRows = false;
            this.eventGridView.AllowUserToDeleteRows = false;
            this.eventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beginDTCol,
            this.endDTCol,
            this.headingCol,
            this.textCol,
            this.isPublicEventCol});
            this.eventGridView.Location = new System.Drawing.Point(0, 0);
            this.eventGridView.Name = "eventGridView";
            this.eventGridView.ReadOnly = true;
            this.eventGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventGridView.Size = new System.Drawing.Size(541, 170);
            this.eventGridView.TabIndex = 1;
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
            // isPublicEventCol
            // 
            this.isPublicEventCol.HeaderText = "Public event";
            this.isPublicEventCol.Name = "isPublicEventCol";
            this.isPublicEventCol.ReadOnly = true;
            this.isPublicEventCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isPublicEventCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 453);
            this.Controls.Add(this.UserTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ScheduleR";
            this.UserTabControl.ResumeLayout(false);
            this.tabPageEvents.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl UserTabControl;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private Classes.MyDataGridView eventGridView;
        private System.Windows.Forms.Button eventUnpublishButton;
        private System.Windows.Forms.Button eventPublishButton;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Button eventUpdateButton;
        private System.Windows.Forms.Button eventCreateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDTCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDTCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn headingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn textCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPublicEventCol;
    }
}

