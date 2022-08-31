namespace Fat_Percentage_Calculator
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
            this.totalcalTextbox = new System.Windows.Forms.TextBox();
            this.fatgramsTextbox = new System.Windows.Forms.TextBox();
            this.lowfatCheckbox = new System.Windows.Forms.CheckBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalcalTextbox
            // 
            this.totalcalTextbox.Location = new System.Drawing.Point(172, 13);
            this.totalcalTextbox.Name = "totalcalTextbox";
            this.totalcalTextbox.Size = new System.Drawing.Size(100, 20);
            this.totalcalTextbox.TabIndex = 0;
            // 
            // fatgramsTextbox
            // 
            this.fatgramsTextbox.Location = new System.Drawing.Point(171, 57);
            this.fatgramsTextbox.Name = "fatgramsTextbox";
            this.fatgramsTextbox.Size = new System.Drawing.Size(100, 20);
            this.fatgramsTextbox.TabIndex = 1;
            // 
            // lowfatCheckbox
            // 
            this.lowfatCheckbox.AutoSize = true;
            this.lowfatCheckbox.Location = new System.Drawing.Point(13, 91);
            this.lowfatCheckbox.Name = "lowfatCheckbox";
            this.lowfatCheckbox.Size = new System.Drawing.Size(238, 17);
            this.lowfatCheckbox.TabIndex = 2;
            this.lowfatCheckbox.Text = "Check if you want to know the food is low fat";
            this.lowfatCheckbox.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(13, 115);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(95, 115);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(177, 115);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Total Number of Calories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "The Number of Fat Grams: ";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(16, 145);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(255, 89);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 248);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.lowfatCheckbox);
            this.Controls.Add(this.fatgramsTextbox);
            this.Controls.Add(this.totalcalTextbox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fat Percentage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalcalTextbox;
        private System.Windows.Forms.TextBox fatgramsTextbox;
        private System.Windows.Forms.CheckBox lowfatCheckbox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputLabel;
    }
}

