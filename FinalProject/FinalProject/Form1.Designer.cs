namespace FinalProject
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
            this.selectLabel = new System.Windows.Forms.Label();
            this.openCourseButton = new System.Windows.Forms.Button();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.addCourseTextBox = new System.Windows.Forms.TextBox();
            this.addToCourseButton = new System.Windows.Forms.Button();
            this.coursePanel = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.viewStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.gradeTextBox = new System.Windows.Forms.RichTextBox();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.studentGradeBox = new System.Windows.Forms.TextBox();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.categoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.removeCourseButton = new System.Windows.Forms.Button();
            this.removeLabel = new System.Windows.Forms.Label();
            this.removeTextBox = new System.Windows.Forms.TextBox();
            this.backToCategories = new System.Windows.Forms.Button();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.coursePanel.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.studentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(91, 12);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(582, 55);
            this.selectLabel.TabIndex = 0;
            this.selectLabel.Text = "Please Select The Course";
            // 
            // openCourseButton
            // 
            this.openCourseButton.Location = new System.Drawing.Point(308, 107);
            this.openCourseButton.Name = "openCourseButton";
            this.openCourseButton.Size = new System.Drawing.Size(148, 75);
            this.openCourseButton.TabIndex = 1;
            this.openCourseButton.Text = "Open Course";
            this.openCourseButton.UseVisualStyleBackColor = true;
            this.openCourseButton.Click += new System.EventHandler(this.openCourseButton_Click_1);
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(322, 80);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(121, 21);
            this.courseComboBox.TabIndex = 2;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabel.Location = new System.Drawing.Point(132, 204);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(500, 55);
            this.addLabel.TabIndex = 3;
            this.addLabel.Text = "Alternatively, Add One";
            // 
            // addCourseTextBox
            // 
            this.addCourseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addCourseTextBox.Location = new System.Drawing.Point(331, 271);
            this.addCourseTextBox.Name = "addCourseTextBox";
            this.addCourseTextBox.Size = new System.Drawing.Size(103, 26);
            this.addCourseTextBox.TabIndex = 5;
            // 
            // addToCourseButton
            // 
            this.addToCourseButton.Location = new System.Drawing.Point(308, 307);
            this.addToCourseButton.Name = "addToCourseButton";
            this.addToCourseButton.Size = new System.Drawing.Size(148, 76);
            this.addToCourseButton.TabIndex = 6;
            this.addToCourseButton.Text = "Add To Courses";
            this.addToCourseButton.UseVisualStyleBackColor = true;
            this.addToCourseButton.Click += new System.EventHandler(this.addToCourseButton_Click);
            // 
            // coursePanel
            // 
            this.coursePanel.Controls.Add(this.removeTextBox);
            this.coursePanel.Controls.Add(this.removeLabel);
            this.coursePanel.Controls.Add(this.removeCourseButton);
            this.coursePanel.Controls.Add(this.addLabel);
            this.coursePanel.Controls.Add(this.selectLabel);
            this.coursePanel.Controls.Add(this.addCourseTextBox);
            this.coursePanel.Controls.Add(this.courseComboBox);
            this.coursePanel.Controls.Add(this.textBox);
            this.coursePanel.Controls.Add(this.openCourseButton);
            this.coursePanel.Controls.Add(this.addToCourseButton);
            this.coursePanel.Location = new System.Drawing.Point(12, 12);
            this.coursePanel.Name = "coursePanel";
            this.coursePanel.Size = new System.Drawing.Size(765, 426);
            this.coursePanel.TabIndex = 8;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(592, 287);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(123, 83);
            this.textBox.TabIndex = 7;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Controls.Add(this.backToMainMenu);
            this.CategoryPanel.Controls.Add(this.calculateButton);
            this.CategoryPanel.Controls.Add(this.studentComboBox);
            this.CategoryPanel.Controls.Add(this.viewStudentButton);
            this.CategoryPanel.Controls.Add(this.addStudentButton);
            this.CategoryPanel.Controls.Add(this.addCategoryButton);
            this.CategoryPanel.Location = new System.Drawing.Point(12, 12);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(765, 426);
            this.CategoryPanel.TabIndex = 8;
            this.CategoryPanel.Visible = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(322, 295);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(148, 75);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate Final Report";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(272, 238);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(256, 21);
            this.studentComboBox.TabIndex = 9;
            this.studentComboBox.Enter += new System.EventHandler(this.studentComboBox_Enter);
            // 
            // viewStudentButton
            // 
            this.viewStudentButton.Location = new System.Drawing.Point(322, 157);
            this.viewStudentButton.Name = "viewStudentButton";
            this.viewStudentButton.Size = new System.Drawing.Size(148, 75);
            this.viewStudentButton.TabIndex = 8;
            this.viewStudentButton.Text = "View Student";
            this.viewStudentButton.UseVisualStyleBackColor = true;
            this.viewStudentButton.Click += new System.EventHandler(this.viewStudentButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(23, 14);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(148, 75);
            this.addStudentButton.TabIndex = 7;
            this.addStudentButton.Text = "Add/Modify Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(592, 14);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(148, 75);
            this.addCategoryButton.TabIndex = 2;
            this.addCategoryButton.Text = "Add/Modify Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(553, 12);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.ReadOnly = true;
            this.gradeTextBox.Size = new System.Drawing.Size(198, 396);
            this.gradeTextBox.TabIndex = 0;
            this.gradeTextBox.Text = "";
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(206, 10);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(119, 64);
            this.addRecordButton.TabIndex = 2;
            this.addRecordButton.Text = "Add/Modify Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.backToCategories);
            this.studentPanel.Controls.Add(this.gradeLabel);
            this.studentPanel.Controls.Add(this.numberLabel);
            this.studentPanel.Controls.Add(this.categoryNameLabel);
            this.studentPanel.Controls.Add(this.studentGradeBox);
            this.studentPanel.Controls.Add(this.numberComboBox);
            this.studentPanel.Controls.Add(this.categoryNameComboBox);
            this.studentPanel.Controls.Add(this.addRecordButton);
            this.studentPanel.Controls.Add(this.gradeTextBox);
            this.studentPanel.Location = new System.Drawing.Point(12, 12);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(765, 426);
            this.studentPanel.TabIndex = 9;
            this.studentPanel.Visible = false;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(243, 204);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(36, 13);
            this.gradeLabel.TabIndex = 8;
            this.gradeLabel.Text = "Grade";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(243, 145);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 7;
            this.numberLabel.Text = "Number";
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(225, 83);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(80, 13);
            this.categoryNameLabel.TabIndex = 6;
            this.categoryNameLabel.Text = "Category Name";
            // 
            // studentGradeBox
            // 
            this.studentGradeBox.Location = new System.Drawing.Point(216, 229);
            this.studentGradeBox.Name = "studentGradeBox";
            this.studentGradeBox.Size = new System.Drawing.Size(100, 20);
            this.studentGradeBox.TabIndex = 5;
            // 
            // numberComboBox
            // 
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Location = new System.Drawing.Point(206, 161);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(121, 21);
            this.numberComboBox.TabIndex = 4;
            // 
            // categoryNameComboBox
            // 
            this.categoryNameComboBox.FormattingEnabled = true;
            this.categoryNameComboBox.Location = new System.Drawing.Point(206, 107);
            this.categoryNameComboBox.Name = "categoryNameComboBox";
            this.categoryNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryNameComboBox.TabIndex = 3;
            this.categoryNameComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryNameComboBox_SelectedIndexChanged);
            // 
            // removeCourseButton
            // 
            this.removeCourseButton.Location = new System.Drawing.Point(23, 332);
            this.removeCourseButton.Name = "removeCourseButton";
            this.removeCourseButton.Size = new System.Drawing.Size(148, 76);
            this.removeCourseButton.TabIndex = 8;
            this.removeCourseButton.Text = "Remove Course";
            this.removeCourseButton.UseVisualStyleBackColor = true;
            this.removeCourseButton.Click += new System.EventHandler(this.removeCourseButton_Click);
            // 
            // removeLabel
            // 
            this.removeLabel.AutoSize = true;
            this.removeLabel.Location = new System.Drawing.Point(56, 295);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(84, 13);
            this.removeLabel.TabIndex = 9;
            this.removeLabel.Text = "Or Remove One";
            // 
            // removeTextBox
            // 
            this.removeTextBox.Location = new System.Drawing.Point(49, 311);
            this.removeTextBox.Name = "removeTextBox";
            this.removeTextBox.Size = new System.Drawing.Size(100, 20);
            this.removeTextBox.TabIndex = 10;
            // 
            // backToCategories
            // 
            this.backToCategories.Location = new System.Drawing.Point(23, 35);
            this.backToCategories.Name = "backToCategories";
            this.backToCategories.Size = new System.Drawing.Size(75, 23);
            this.backToCategories.TabIndex = 9;
            this.backToCategories.Text = "Back";
            this.backToCategories.UseVisualStyleBackColor = true;
            this.backToCategories.Click += new System.EventHandler(this.backToCategories_Click);
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(350, 14);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(75, 23);
            this.backToMainMenu.TabIndex = 10;
            this.backToMainMenu.Text = "Back";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.coursePanel);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.coursePanel.ResumeLayout(false);
            this.coursePanel.PerformLayout();
            this.CategoryPanel.ResumeLayout(false);
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button openCourseButton;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.TextBox addCourseTextBox;
        private System.Windows.Forms.Button addToCourseButton;
        private System.Windows.Forms.Panel coursePanel;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button viewStudentButton;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.RichTextBox gradeTextBox;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.TextBox studentGradeBox;
        private System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.ComboBox categoryNameComboBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox removeTextBox;
        private System.Windows.Forms.Label removeLabel;
        private System.Windows.Forms.Button removeCourseButton;
        private System.Windows.Forms.Button backToCategories;
        private System.Windows.Forms.Button backToMainMenu;
    }
}

