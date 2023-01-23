
namespace ScheduleR
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ObserverLink = new System.Windows.Forms.LinkLabel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SnapLabel = new System.Windows.Forms.Label();
            this.StatusDescriptionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(38, 38);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(33, 13);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(38, 71);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(97, 35);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(142, 20);
            this.LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(97, 68);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(142, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(97, 147);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ObserverLink
            // 
            this.ObserverLink.AutoSize = true;
            this.ObserverLink.Location = new System.Drawing.Point(80, 173);
            this.ObserverLink.Name = "ObserverLink";
            this.ObserverLink.Size = new System.Drawing.Size(109, 13);
            this.ObserverLink.TabIndex = 5;
            this.ObserverLink.TabStop = true;
            this.ObserverLink.Text = "Log-in as an observer";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(34, 112);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(201, 18);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "SL";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusDescriptionToolTip.SetToolTip(this.StatusLabel, "text");
            // 
            // SnapLabel
            // 
            this.SnapLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SnapLabel.Location = new System.Drawing.Point(0, 0);
            this.SnapLabel.Name = "SnapLabel";
            this.SnapLabel.Size = new System.Drawing.Size(267, 17);
            this.SnapLabel.TabIndex = 7;
            this.SnapLabel.Text = "___";
            this.SnapLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // StatusDescriptionToolTip
            // 
            this.StatusDescriptionToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.StatusDescriptionToolTip.ToolTipTitle = "Status Description";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 203);
            this.Controls.Add(this.SnapLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ObserverLink);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.LinkLabel ObserverLink;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label SnapLabel;
        private System.Windows.Forms.ToolTip StatusDescriptionToolTip;
    }
}