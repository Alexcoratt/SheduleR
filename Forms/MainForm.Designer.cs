
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentCreateButton = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.eventIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.myDataGridView1 = new ScheduleR.Classes.MyDataGridView();
            this.commentOwnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublicComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLastUpdateDTLabel = new System.Windows.Forms.Label();
            this.eventCreationDTLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventGridView = new ScheduleR.Classes.MyDataGridView();
            this.beginDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublicEventCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextEventGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpublishEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOwnerLabel = new System.Windows.Forms.Label();
            this.eventHeadingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eventTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.groupGridView = new ScheduleR.Classes.MyDataGridView();
            this.groupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupAccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupMembMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMyGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.accessLevelLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usersDataGridView = new ScheduleR.Classes.MyDataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextUserGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.UserTabControl.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).BeginInit();
            this.contextEventGridMenu.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).BeginInit();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.contextUserGridMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.tabPageEvents);
            this.UserTabControl.Controls.Add(this.tabPageGroups);
            this.UserTabControl.Controls.Add(this.tabPageUsers);
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
            this.eventGridView.MultiSelect = false;
            this.eventGridView.Name = "eventGridView";
            this.eventGridView.ReadOnly = true;
            this.eventGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventGridView.Size = new System.Drawing.Size(399, 170);
            this.eventGridView.TabIndex = 1;
            this.eventGridView.SelectionChanged += new System.EventHandler(this.eventGridView_SelectionChanged);
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
            // contextEventGridMenu
            // 
            this.contextEventGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.updateEventToolStripMenuItem,
            this.deleteEventToolStripMenuItem,
            this.publishEventToolStripMenuItem,
            this.unpublishEventToolStripMenuItem,
            this.refreshAllToolStripMenuItem});
            this.contextEventGridMenu.Name = "contextMenuStrip1";
            this.contextEventGridMenu.Size = new System.Drawing.Size(161, 136);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.testToolStripMenuItem.Text = "Create event";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // updateEventToolStripMenuItem
            // 
            this.updateEventToolStripMenuItem.Name = "updateEventToolStripMenuItem";
            this.updateEventToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateEventToolStripMenuItem.Text = "Update event";
            this.updateEventToolStripMenuItem.Click += new System.EventHandler(this.updateEventToolStripMenuItem_Click);
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteEventToolStripMenuItem.Text = "Delete event";
            this.deleteEventToolStripMenuItem.Click += new System.EventHandler(this.deleteEventToolStripMenuItem_Click);
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
            // refreshAllToolStripMenuItem
            // 
            this.refreshAllToolStripMenuItem.Name = "refreshAllToolStripMenuItem";
            this.refreshAllToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.refreshAllToolStripMenuItem.Text = "Refresh";
            this.refreshAllToolStripMenuItem.Click += new System.EventHandler(this.refreshAllToolStripMenuItem_Click);
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
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.groupGridView);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(672, 361);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // groupGridView
            // 
            this.groupGridView.AllowUserToAddRows = false;
            this.groupGridView.AllowUserToDeleteRows = false;
            this.groupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupId,
            this.groupName,
            this.groupAccessLevel,
            this.groupMembMax,
            this.isMyGroup});
            this.groupGridView.Location = new System.Drawing.Point(8, 6);
            this.groupGridView.Name = "groupGridView";
            this.groupGridView.ReadOnly = true;
            this.groupGridView.Size = new System.Drawing.Size(439, 162);
            this.groupGridView.TabIndex = 0;
            // 
            // groupId
            // 
            this.groupId.HeaderText = "group ID";
            this.groupId.Name = "groupId";
            this.groupId.ReadOnly = true;
            this.groupId.Width = 60;
            // 
            // groupName
            // 
            this.groupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupName.HeaderText = "Group name";
            this.groupName.Name = "groupName";
            this.groupName.ReadOnly = true;
            // 
            // groupAccessLevel
            // 
            this.groupAccessLevel.HeaderText = "Access level";
            this.groupAccessLevel.Name = "groupAccessLevel";
            this.groupAccessLevel.ReadOnly = true;
            this.groupAccessLevel.Width = 50;
            // 
            // groupMembMax
            // 
            this.groupMembMax.HeaderText = "Maximum of members";
            this.groupMembMax.Name = "groupMembMax";
            this.groupMembMax.ReadOnly = true;
            this.groupMembMax.Width = 70;
            // 
            // isMyGroup
            // 
            this.isMyGroup.HeaderText = "My group";
            this.isMyGroup.Name = "isMyGroup";
            this.isMyGroup.ReadOnly = true;
            this.isMyGroup.Width = 50;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.label11);
            this.tabPageUsers.Controls.Add(this.richTextBox1);
            this.tabPageUsers.Controls.Add(this.accessLevelLabel);
            this.tabPageUsers.Controls.Add(this.label9);
            this.tabPageUsers.Controls.Add(this.middleNameLabel);
            this.tabPageUsers.Controls.Add(this.label10);
            this.tabPageUsers.Controls.Add(this.lastNameLabel);
            this.tabPageUsers.Controls.Add(this.firstNameLabel);
            this.tabPageUsers.Controls.Add(this.label8);
            this.tabPageUsers.Controls.Add(this.label7);
            this.tabPageUsers.Controls.Add(this.loginLabel);
            this.tabPageUsers.Controls.Add(this.label6);
            this.tabPageUsers.Controls.Add(this.userIdLabel);
            this.tabPageUsers.Controls.Add(this.label4);
            this.tabPageUsers.Controls.Add(this.usersDataGridView);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Size = new System.Drawing.Size(672, 361);
            this.tabPageUsers.TabIndex = 2;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "BIO";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(345, 219);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 96);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // accessLevelLabel
            // 
            this.accessLevelLabel.AutoSize = true;
            this.accessLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accessLevelLabel.Location = new System.Drawing.Point(8, 296);
            this.accessLevelLabel.Name = "accessLevelLabel";
            this.accessLevelLabel.Size = new System.Drawing.Size(53, 16);
            this.accessLevelLabel.TabIndex = 12;
            this.accessLevelLabel.Text = "Access";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Access Level";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameLabel.Location = new System.Drawing.Point(146, 296);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(86, 16);
            this.middleNameLabel.TabIndex = 10;
            this.middleNameLabel.Text = "Middle name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Middle name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(146, 255);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(70, 16);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(146, 216);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(70, 16);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Last name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "First name";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(8, 255);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 16);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Login";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userIdLabel.Location = new System.Drawing.Point(8, 216);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(21, 16);
            this.userIdLabel.TabIndex = 2;
            this.userIdLabel.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "User ID";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.login,
            this.lastName,
            this.firstName,
            this.accessLevel});
            this.usersDataGridView.ContextMenuStrip = this.contextUserGridMenu;
            this.usersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(666, 187);
            this.usersDataGridView.TabIndex = 0;
            // 
            // userId
            // 
            this.userId.HeaderText = "User ID";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // login
            // 
            this.login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // accessLevel
            // 
            this.accessLevel.HeaderText = "Access Level";
            this.accessLevel.Name = "accessLevel";
            this.accessLevel.ReadOnly = true;
            // 
            // contextUserGridMenu
            // 
            this.contextUserGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextUserGridMenu.Name = "contextUserGridMenu";
            this.contextUserGridMenu.Size = new System.Drawing.Size(142, 70);
            // 
            // registerUserToolStripMenuItem
            // 
            this.registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
            this.registerUserToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.registerUserToolStripMenuItem.Text = "Register user";
            this.registerUserToolStripMenuItem.Click += new System.EventHandler(this.registerUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete user";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
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
            // consoleTextBox
            // 
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.consoleTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleTextBox.Location = new System.Drawing.Point(686, 24);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(195, 387);
            this.consoleTextBox.TabIndex = 4;
            this.consoleTextBox.Text = "";
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.UserTabControl.ResumeLayout(false);
            this.tabPageEvents.ResumeLayout(false);
            this.tabPageEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).EndInit();
            this.contextEventGridMenu.ResumeLayout(false);
            this.tabPageGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).EndInit();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.contextUserGridMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl UserTabControl;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.TabPage tabPageGroups;
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
        private Classes.MyDataGridView groupGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupAccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupMembMax;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMyGroup;
        public System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.ToolStripMenuItem refreshAllToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageUsers;
        private Classes.MyDataGridView usersDataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label accessLevelLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessLevel;
        private System.Windows.Forms.ContextMenuStrip contextUserGridMenu;
        private System.Windows.Forms.ToolStripMenuItem registerUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

