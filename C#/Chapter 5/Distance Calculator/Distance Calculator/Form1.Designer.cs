namespace Distance_Calculator
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
            this.speedTextbox = new System.Windows.Forms.TextBox();
            this.hoursTextbox = new System.Windows.Forms.TextBox();
            this.distanceListbox = new System.Windows.Forms.ListBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedTextbox
            // 
            this.speedTextbox.Location = new System.Drawing.Point(119, 11);
            this.speedTextbox.Name = "speedTextbox";
            this.speedTextbox.Size = new System.Drawing.Size(100, 20);
            this.speedTextbox.TabIndex = 0;
            // 
            // hoursTextbox
            // 
            this.hoursTextbox.Location = new System.Drawing.Point(118, 38);
            this.hoursTextbox.Name = "hoursTextbox";
            this.hoursTextbox.Size = new System.Drawing.Size(100, 20);
            this.hoursTextbox.TabIndex = 1;
            // 
            // distanceListbox
            // 
            this.distanceListbox.FormattingEnabled = true;
            this.distanceListbox.Location = new System.Drawing.Point(13, 77);
            this.distanceListbox.Name = "distanceListbox";
            this.distanceListbox.Size = new System.Drawing.Size(205, 95);
            this.distanceListbox.TabIndex = 2;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(15, 186);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(60, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(86, 186);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vehicle Speed (MPH):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hours Traveled:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(157, 186);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 219);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.distanceListbox);
            this.Controls.Add(this.hoursTextbox);
            this.Controls.Add(this.speedTextbox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox speedTextbox;
        private System.Windows.Forms.TextBox hoursTextbox;
        private System.Windows.Forms.ListBox distanceListbox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
    }
}

