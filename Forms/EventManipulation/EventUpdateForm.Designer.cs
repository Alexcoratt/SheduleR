
namespace ScheduleR.Forms.EventManipulation
{
    partial class EventUpdateForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.eventHeadingTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eventGridView = new ScheduleR.Classes.MyDataGridView();
            this.eventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventHeading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTextTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(195, 231);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(111, 40);
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(12, 195);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(245, 20);
            this.endDateTimePicker.TabIndex = 16;
            this.endDateTimePicker.Value = new System.DateTime(2023, 1, 25, 1, 21, 20, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "End date and time";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.beginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginDateTimePicker.Location = new System.Drawing.Point(13, 156);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(245, 20);
            this.beginDateTimePicker.TabIndex = 14;
            this.beginDateTimePicker.Value = new System.DateTime(2023, 1, 25, 1, 21, 20, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Begin date and time";
            // 
            // eventHeadingTextBox
            // 
            this.eventHeadingTextBox.Location = new System.Drawing.Point(285, 36);
            this.eventHeadingTextBox.Multiline = true;
            this.eventHeadingTextBox.Name = "eventHeadingTextBox";
            this.eventHeadingTextBox.Size = new System.Drawing.Size(202, 38);
            this.eventHeadingTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Event text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event heading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Event";
            // 
            // eventGridView
            // 
            this.eventGridView.AllowUserToAddRows = false;
            this.eventGridView.AllowUserToDeleteRows = false;
            this.eventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventId,
            this.eventHeading});
            this.eventGridView.Location = new System.Drawing.Point(11, 36);
            this.eventGridView.MultiSelect = false;
            this.eventGridView.Name = "eventGridView";
            this.eventGridView.ReadOnly = true;
            this.eventGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventGridView.Size = new System.Drawing.Size(246, 100);
            this.eventGridView.TabIndex = 19;
            this.eventGridView.SelectionChanged += new System.EventHandler(this.eventGridView_SelectionChanged);
            // 
            // eventId
            // 
            this.eventId.HeaderText = "Event ID";
            this.eventId.Name = "eventId";
            this.eventId.ReadOnly = true;
            this.eventId.Width = 50;
            // 
            // eventHeading
            // 
            this.eventHeading.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eventHeading.HeaderText = "Heading";
            this.eventHeading.Name = "eventHeading";
            this.eventHeading.ReadOnly = true;
            // 
            // eventTextTextBox
            // 
            this.eventTextTextBox.Location = new System.Drawing.Point(285, 96);
            this.eventTextTextBox.Name = "eventTextTextBox";
            this.eventTextTextBox.Size = new System.Drawing.Size(202, 119);
            this.eventTextTextBox.TabIndex = 20;
            this.eventTextTextBox.Text = "";
            // 
            // EventUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 283);
            this.Controls.Add(this.eventTextTextBox);
            this.Controls.Add(this.eventGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beginDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventHeadingTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EventUpdateForm";
            this.Text = "EventUpdateForm";
            this.Load += new System.EventHandler(this.EventUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventHeadingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Classes.MyDataGridView eventGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventHeading;
        private System.Windows.Forms.RichTextBox eventTextTextBox;
    }
}