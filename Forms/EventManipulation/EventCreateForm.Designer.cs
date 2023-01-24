
namespace ScheduleR.Forms.EventManipulation
{
    partial class EventCreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventHeadingTextBox = new System.Windows.Forms.TextBox();
            this.eventTextTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event heading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event text";
            // 
            // eventHeadingTextBox
            // 
            this.eventHeadingTextBox.Location = new System.Drawing.Point(15, 26);
            this.eventHeadingTextBox.Multiline = true;
            this.eventHeadingTextBox.Name = "eventHeadingTextBox";
            this.eventHeadingTextBox.Size = new System.Drawing.Size(202, 30);
            this.eventHeadingTextBox.TabIndex = 2;
            // 
            // eventTextTextBox
            // 
            this.eventTextTextBox.Location = new System.Drawing.Point(15, 88);
            this.eventTextTextBox.Multiline = true;
            this.eventTextTextBox.Name = "eventTextTextBox";
            this.eventTextTextBox.Size = new System.Drawing.Size(202, 64);
            this.eventTextTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Begin date and time";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.beginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginDateTimePicker.Location = new System.Drawing.Point(15, 185);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.beginDateTimePicker.TabIndex = 5;
            this.beginDateTimePicker.Value = new System.DateTime(2023, 1, 25, 1, 21, 20, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "End date and time";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(15, 237);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.endDateTimePicker.TabIndex = 7;
            this.endDateTimePicker.Value = new System.DateTime(2023, 1, 25, 1, 21, 20, 0);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(66, 276);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(111, 40);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // EventCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 328);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beginDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventTextTextBox);
            this.Controls.Add(this.eventHeadingTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EventCreateForm";
            this.Text = "Create Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eventHeadingTextBox;
        private System.Windows.Forms.TextBox eventTextTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button submitButton;
    }
}