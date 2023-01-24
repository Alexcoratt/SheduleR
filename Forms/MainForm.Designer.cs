
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
            this.components = new System.ComponentModel.Container();
            this.UserTabControl = new System.Windows.Forms.TabControl();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.eventIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.myDataGridView1 = new ScheduleR.Classes.MyDataGridView();
            this.eventLastUpdateDTLabel = new System.Windows.Forms.Label();
            this.eventCreationDTLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventOwnerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eventTextBox = new System.Windows.Forms.RichTextBox();
            this.eventHeadingLabel = new System.Windows.Forms.Label();
            this.eventGridView = new ScheduleR.Classes.MyDataGridView();
            this.contextEventGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpublishEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublicEventCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentCreateButton = new System.Windows.Forms.Button();
            this.commentOwnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublicComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.UserTabControl.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).BeginInit();
            this.contextEventGridMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.tabPageEvents);
            this.UserTabControl.Controls.Add(this.tabPage2);
            this.UserTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserTabControl.Location = new System.Drawing.Point(0, 24);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(680, 387);
            this.UserTabControl.TabIndex = 0;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.AutoScroll = true;
            this.tabPageEvents.Controls.Add(this.panel1);
            this.tabPageEvents.Controls.Add(this.eventIdLabel);
            this.tabPageEvents.Controls.Add(this.label5);
            this.tabPageEvents.Controls.Add(this.myDataGridView1);
            this.tabPageEvents.Controls.Add(this.eventLastUpdateDTLabel);
            this.tabPageEvents.Controls.Add(this.eventCreationDTLabel);
            this.tabPageEvents.Controls.Add(this.label3);
            this.tabPageEvents.Controls.Add(this.label2);
            this.tabPageEvents.Controls.Add(this.eventGridView);
            this.tabPageEvents.Controls.Add(this.eventOwnerLabel);
            this.tabPageEvents.Controls.Add(this.eventHeadingLabel);
            this.tabPageEvents.Controls.Add(this.label1);
            this.tabPageEvents.Controls.Add(this.eventTextBox);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvents.Size = new System.Drawing.Size(672, 361);
            this.tabPageEvents.TabIndex = 0;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // eventIdLabel
            // 
            this.eventIdLabel.AutoSize = true;
            this.eventIdLabel.Location = new System.Drawing.Point(276, 190);
            this.eventIdLabel.Name = "eventIdLabel";
            this.eventIdLabel.Size = new System.Drawing.Size(35, 13);
            this.eventIdLabel.TabIndex = 11;
            this.eventIdLabel.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Event ID";
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AllowUserToAddRows = false;
            this.myDataGridView1.AllowUserToDeleteRows = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentOwnerId,
            this.commentText,
            this.isPublicComment});
            this.myDataGridView1.Location = new System.Drawing.Point(405, 0);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.ReadOnly = true;
            this.myDataGridView1.Size = new System.Drawing.Size(264, 302);
            this.myDataGridView1.TabIndex = 8;
            // 
            // eventLastUpdateDTLabel
            // 
            this.eventLastUpdateDTLabel.AutoSize = true;
            this.eventLastUpdateDTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventLastUpdateDTLabel.Location = new System.Drawing.Point(221, 330);
            this.eventLastUpdateDTLabel.Name = "eventLastUpdateDTLabel";
            this.eventLastUpdateDTLabel.Size = new System.Drawing.Size(45, 16);
            this.eventLastUpdateDTLabel.TabIndex = 7;
            this.eventLastUpdateDTLabel.Text = "label4";
            // 
            // eventCreationDTLabel
            // 
            this.eventCreationDTLabel.AutoSize = true;
            this.eventCreationDTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventCreationDTLabel.Location = new System.Drawing.Point(221, 286);
            this.eventCreationDTLabel.Name = "eventCreationDTLabel";
            this.eventCreationDTLabel.Size = new System.Drawing.Size(45, 16);
            this.eventCreationDTLabel.TabIndex = 6;
            this.eventCreationDTLabel.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Update date and time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Creation date and time";
            // 
            // eventOwnerLabel
            // 
            this.eventOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventOwnerLabel.Location = new System.Drawing.Point(220, 231);
            this.eventOwnerLabel.Name = "eventOwnerLabel";
            this.eventOwnerLabel.Size = new System.Drawing.Size(170, 42);
            this.eventOwnerLabel.TabIndex = 3;
            this.eventOwnerLabel.Text = "Event owner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Owner";
            // 
            // eventTextBox
            // 
            this.eventTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventTextBox.Location = new System.Drawing.Point(16, 218);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.ReadOnly = true;
            this.eventTextBox.Size = new System.Drawing.Size(199, 128);
            this.eventTextBox.TabIndex = 1;
            this.eventTextBox.Text = "";
            // 
            // eventHeadingLabel
            // 
            this.eventHeadingLabel.AutoSize = true;
            this.eventHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventHeadingLabel.Location = new System.Drawing.Point(12, 182);
            this.eventHeadingLabel.Name = "eventHeadingLabel";
            this.eventHeadingLabel.Size = new System.Drawing.Size(82, 24);
            this.eventHeadingLabel.TabIndex = 0;
            this.eventHeadingLabel.Text = "Heading";
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
            this.isPublicEventCol});
            this.eventGridView.ContextMenuStrip = this.contextEventGridMenu;
            this.eventGridView.Location = new System.Drawing.Point(0, 0);
            this.eventGridView.Name = "eventGridView";
            this.eventGridView.ReadOnly = true;
            this.eventGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventGridView.Size = new System.Drawing.Size(399, 170);
            this.eventGridView.TabIndex = 1;
            this.eventGridView.SelectionChanged += new System.EventHandler(this.eventGridView_SelectionChanged);
            // 
            // contextEventGridMenu
            // 
            this.contextEventGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.updateEventToolStripMenuItem,
            this.deleteEventToolStripMenuItem,
            this.publishEventToolStripMenuItem,
            this.unpublishEventToolStripMenuItem});
            this.contextEventGridMenu.Name = "contextMenuStrip1";
            this.contextEventGridMenu.Size = new System.Drawing.Size(161, 114);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.testToolStripMenuItem.Text = "Create event";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 361);
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
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
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
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.myProfileToolStripMenuItem.Text = "My profile";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.logoutToolStripMenuItem.Text = "Log-out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // updateEventToolStripMenuItem
            // 
            this.updateEventToolStripMenuItem.Name = "updateEventToolStripMenuItem";
            this.updateEventToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateEventToolStripMenuItem.Text = "Update event";
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteEventToolStripMenuItem.Text = "Delete event";
            // 
            // publishEventToolStripMenuItem
            // 
            this.publishEventToolStripMenuItem.Name = "publishEventToolStripMenuItem";
            this.publishEventToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.publishEventToolStripMenuItem.Text = "Publish event";
            // 
            // unpublishEventToolStripMenuItem
            // 
            this.unpublishEventToolStripMenuItem.Name = "unpublishEventToolStripMenuItem";
            this.unpublishEventToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.unpublishEventToolStripMenuItem.Text = "Unpublish event";
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
            this.headingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headingCol.HeaderText = "Heading";
            this.headingCol.Name = "headingCol";
            this.headingCol.ReadOnly = true;
            // 
            // isPublicEventCol
            // 
            this.isPublicEventCol.HeaderText = "Public event";
            this.isPublicEventCol.Name = "isPublicEventCol";
            this.isPublicEventCol.ReadOnly = true;
            this.isPublicEventCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isPublicEventCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isPublicEventCol.Width = 40;
            // 
            // commentTextBox
            // 
            this.commentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.commentTextBox.Location = new System.Drawing.Point(0, 0);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(183, 53);
            this.commentTextBox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentCreateButton);
            this.panel1.Controls.Add(this.commentTextBox);
            this.panel1.Location = new System.Drawing.Point(405, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 53);
            this.panel1.TabIndex = 13;
            // 
            // commentCreateButton
            // 
            this.commentCreateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.commentCreateButton.Location = new System.Drawing.Point(189, 0);
            this.commentCreateButton.Name = "commentCreateButton";
            this.commentCreateButton.Size = new System.Drawing.Size(75, 53);
            this.commentCreateButton.TabIndex = 13;
            this.commentCreateButton.Text = "Create comment";
            this.commentCreateButton.UseVisualStyleBackColor = true;
            // 
            // commentOwnerId
            // 
            this.commentOwnerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.commentOwnerId.HeaderText = "Owner ID";
            this.commentOwnerId.Name = "commentOwnerId";
            this.commentOwnerId.ReadOnly = true;
            this.commentOwnerId.Width = 77;
            // 
            // commentText
            // 
            this.commentText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentText.HeaderText = "Comment";
            this.commentText.Name = "commentText";
            this.commentText.ReadOnly = true;
            // 
            // isPublicComment
            // 
            this.isPublicComment.HeaderText = "Public";
            this.isPublicComment.Name = "isPublicComment";
            this.isPublicComment.ReadOnly = true;
            this.isPublicComment.Width = 40;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.consoleTextBox.Location = new System.Drawing.Point(686, 24);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(195, 387);
            this.consoleTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 411);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.UserTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ScheduleR";
            this.UserTabControl.ResumeLayout(false);
            this.tabPageEvents.ResumeLayout(false);
            this.tabPageEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).EndInit();
            this.contextEventGridMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private Classes.MyDataGridView myDataGridView1;
        private System.Windows.Forms.Label eventLastUpdateDTLabel;
        private System.Windows.Forms.Label eventCreationDTLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label eventOwnerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox eventTextBox;
        private System.Windows.Forms.Label eventHeadingLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eventIdLabel;
        private System.Windows.Forms.ContextMenuStrip contextEventGridMenu;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpublishEventToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button commentCreateButton;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentOwnerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentText;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPublicComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDTCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDTCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn headingCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPublicEventCol;
        private System.Windows.Forms.TextBox consoleTextBox;
    }
}

