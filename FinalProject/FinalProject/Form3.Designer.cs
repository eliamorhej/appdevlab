namespace FinalProject
{
    partial class studentForm
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.sectionNumberLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.sectionNumber = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.studentID = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(114, 174);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 122);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 12;
            this.lastNameLabel.Text = "Last Name";
            // 
            // sectionNumberLabel
            // 
            this.sectionNumberLabel.AutoSize = true;
            this.sectionNumberLabel.Location = new System.Drawing.Point(13, 86);
            this.sectionNumberLabel.Name = "sectionNumberLabel";
            this.sectionNumberLabel.Size = new System.Drawing.Size(83, 13);
            this.sectionNumberLabel.TabIndex = 11;
            this.sectionNumberLabel.Text = "Section Number";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(13, 51);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(58, 13);
            this.studentIdLabel.TabIndex = 10;
            this.studentIdLabel.Text = "Student ID";
            // 
            // sectionNumber
            // 
            this.sectionNumber.Location = new System.Drawing.Point(105, 83);
            this.sectionNumber.Name = "sectionNumber";
            this.sectionNumber.Size = new System.Drawing.Size(100, 20);
            this.sectionNumber.TabIndex = 9;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(105, 119);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 8;
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(105, 48);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(100, 20);
            this.studentID.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(13, 151);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 14;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(105, 148);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 15;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 246);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.sectionNumberLabel);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.sectionNumber);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.studentID);
            this.Name = "studentForm";
            this.Text = "Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label sectionNumberLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.TextBox sectionNumber;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstName;
    }
}