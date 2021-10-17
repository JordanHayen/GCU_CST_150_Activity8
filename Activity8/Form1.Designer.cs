namespace Activity8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarbohydratesTextBox = new System.Windows.Forms.TextBox();
            this.FatTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalCaloriesTextBox = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carbohydrates (grams):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(111, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fat (grams):";
            // 
            // CarbohydratesTextBox
            // 
            this.CarbohydratesTextBox.Location = new System.Drawing.Point(212, 44);
            this.CarbohydratesTextBox.Name = "CarbohydratesTextBox";
            this.CarbohydratesTextBox.Size = new System.Drawing.Size(100, 20);
            this.CarbohydratesTextBox.TabIndex = 2;
            this.CarbohydratesTextBox.Text = "0";
            // 
            // FatTextBox
            // 
            this.FatTextBox.Location = new System.Drawing.Point(212, 100);
            this.FatTextBox.Name = "FatTextBox";
            this.FatTextBox.Size = new System.Drawing.Size(100, 20);
            this.FatTextBox.TabIndex = 3;
            this.FatTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(97, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Calories:";
            // 
            // TotalCaloriesTextBox
            // 
            this.TotalCaloriesTextBox.Location = new System.Drawing.Point(212, 163);
            this.TotalCaloriesTextBox.Name = "TotalCaloriesTextBox";
            this.TotalCaloriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalCaloriesTextBox.TabIndex = 5;
            this.TotalCaloriesTextBox.Text = "0";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(318, 161);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(452, 243);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.TotalCaloriesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FatTextBox);
            this.Controls.Add(this.CarbohydratesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calories from Fat and Carbohydrates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CarbohydratesTextBox;
        private System.Windows.Forms.TextBox FatTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalCaloriesTextBox;
        private System.Windows.Forms.Button Calculate;
    }
}

