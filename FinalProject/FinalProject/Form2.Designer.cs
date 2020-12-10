namespace FinalProject
{
    partial class categoryForm
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
            this.categories = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.assessment = new System.Windows.Forms.TextBox();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.assessmentLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categories
            // 
            this.categories.Location = new System.Drawing.Point(81, 48);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(100, 20);
            this.categories.TabIndex = 0;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(81, 119);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 1;
            // 
            // assessment
            // 
            this.assessment.Location = new System.Drawing.Point(81, 83);
            this.assessment.Name = "assessment";
            this.assessment.Size = new System.Drawing.Size(100, 20);
            this.assessment.TabIndex = 2;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(12, 51);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(49, 13);
            this.categoriesLabel.TabIndex = 3;
            this.categoriesLabel.Text = "Category";
            // 
            // assessmentLabel
            // 
            this.assessmentLabel.AutoSize = true;
            this.assessmentLabel.Location = new System.Drawing.Point(12, 86);
            this.assessmentLabel.Name = "assessmentLabel";
            this.assessmentLabel.Size = new System.Drawing.Size(63, 13);
            this.assessmentLabel.TabIndex = 4;
            this.assessmentLabel.Text = "Assessment";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(12, 122);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(91, 155);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 246);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.assessmentLabel);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.assessment);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.categories);
            this.Name = "categoryForm";
            this.Text = "Category Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox categories;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox assessment;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Label assessmentLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button submitButton;
    }
}