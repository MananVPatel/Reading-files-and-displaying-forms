namespace act4
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
            this.bCost = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMeal = new System.Windows.Forms.ComboBox();
            this.cbDorm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bCost
            // 
            this.bCost.Location = new System.Drawing.Point(76, 118);
            this.bCost.Name = "bCost";
            this.bCost.Size = new System.Drawing.Size(123, 68);
            this.bCost.TabIndex = 0;
            this.bCost.Text = "Show Cost";
            this.bCost.UseVisualStyleBackColor = true;
            this.bCost.Click += new System.EventHandler(this.bCost_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(330, 118);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(145, 68);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meal Plans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dorms";
            // 
            // cbMeal
            // 
            this.cbMeal.FormattingEnabled = true;
            this.cbMeal.Location = new System.Drawing.Point(12, 72);
            this.cbMeal.Name = "cbMeal";
            this.cbMeal.Size = new System.Drawing.Size(284, 21);
            this.cbMeal.TabIndex = 4;
            // 
            // cbDorm
            // 
            this.cbDorm.FormattingEnabled = true;
            this.cbDorm.Location = new System.Drawing.Point(302, 72);
            this.cbDorm.Name = "cbDorm";
            this.cbDorm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbDorm.Size = new System.Drawing.Size(284, 21);
            this.cbDorm.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 262);
            this.Controls.Add(this.cbDorm);
            this.Controls.Add(this.cbMeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bCost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCost;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMeal;
        private System.Windows.Forms.ComboBox cbDorm;
    }
}

