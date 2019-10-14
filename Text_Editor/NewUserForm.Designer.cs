namespace Text_Editor
{
    partial class NewUserForm
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
            this.PwTextbox = new System.Windows.Forms.TextBox();
            this.UnTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.REPwTextbox = new System.Windows.Forms.TextBox();
            this.FNLabel = new System.Windows.Forms.Label();
            this.FNTextbox = new System.Windows.Forms.TextBox();
            this.LNTextbox = new System.Windows.Forms.TextBox();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.DOBBox = new System.Windows.Forms.DateTimePicker();
            this.UTComboBox = new System.Windows.Forms.ComboBox();
            this.UTLabel = new System.Windows.Forms.Label();
            this.CButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PwTextbox
            // 
            this.PwTextbox.Location = new System.Drawing.Point(150, 51);
            this.PwTextbox.Name = "PwTextbox";
            this.PwTextbox.Size = new System.Drawing.Size(152, 20);
            this.PwTextbox.TabIndex = 7;
            // 
            // UnTextbox
            // 
            this.UnTextbox.Location = new System.Drawing.Point(150, 25);
            this.UnTextbox.Name = "UnTextbox";
            this.UnTextbox.Size = new System.Drawing.Size(152, 20);
            this.UnTextbox.TabIndex = 6;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(59, 54);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(59, 28);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(55, 13);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Re-Enter Password";
            // 
            // REPwTextbox
            // 
            this.REPwTextbox.Location = new System.Drawing.Point(150, 77);
            this.REPwTextbox.Name = "REPwTextbox";
            this.REPwTextbox.Size = new System.Drawing.Size(152, 20);
            this.REPwTextbox.TabIndex = 9;
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(55, 110);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(57, 13);
            this.FNLabel.TabIndex = 10;
            this.FNLabel.Text = "First Name";
            // 
            // FNTextbox
            // 
            this.FNTextbox.Location = new System.Drawing.Point(150, 103);
            this.FNTextbox.Name = "FNTextbox";
            this.FNTextbox.Size = new System.Drawing.Size(152, 20);
            this.FNTextbox.TabIndex = 12;
            // 
            // LNTextbox
            // 
            this.LNTextbox.Location = new System.Drawing.Point(150, 129);
            this.LNTextbox.Name = "LNTextbox";
            this.LNTextbox.Size = new System.Drawing.Size(152, 20);
            this.LNTextbox.TabIndex = 13;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(84, 162);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(30, 13);
            this.DOBLabel.TabIndex = 14;
            this.DOBLabel.Text = "DOB";
            // 
            // DOBBox
            // 
            this.DOBBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBBox.CustomFormat = "dd-MM-yyy";
            this.DOBBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBBox.Location = new System.Drawing.Point(150, 155);
            this.DOBBox.Name = "DOBBox";
            this.DOBBox.Size = new System.Drawing.Size(200, 20);
            this.DOBBox.TabIndex = 15;
            // 
            // UTComboBox
            // 
            this.UTComboBox.FormattingEnabled = true;
            this.UTComboBox.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.UTComboBox.Location = new System.Drawing.Point(150, 181);
            this.UTComboBox.Name = "UTComboBox";
            this.UTComboBox.Size = new System.Drawing.Size(121, 21);
            this.UTComboBox.TabIndex = 16;
            // 
            // UTLabel
            // 
            this.UTLabel.AutoSize = true;
            this.UTLabel.Location = new System.Drawing.Point(84, 189);
            this.UTLabel.Name = "UTLabel";
            this.UTLabel.Size = new System.Drawing.Size(56, 13);
            this.UTLabel.TabIndex = 17;
            this.UTLabel.Text = "User-Type";
            // 
            // CButton
            // 
            this.CButton.Location = new System.Drawing.Point(87, 244);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(75, 23);
            this.CButton.TabIndex = 18;
            this.CButton.Text = "Cancel";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(196, 244);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 19;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Last Name";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.UTLabel);
            this.Controls.Add(this.UTComboBox);
            this.Controls.Add(this.DOBBox);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.LNTextbox);
            this.Controls.Add(this.FNTextbox);
            this.Controls.Add(this.FNLabel);
            this.Controls.Add(this.REPwTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PwTextbox);
            this.Controls.Add(this.UnTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PwTextbox;
        private System.Windows.Forms.TextBox UnTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox REPwTextbox;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.TextBox FNTextbox;
        private System.Windows.Forms.TextBox LNTextbox;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.DateTimePicker DOBBox;
        private System.Windows.Forms.ComboBox UTComboBox;
        private System.Windows.Forms.Label UTLabel;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label2;
    }
}