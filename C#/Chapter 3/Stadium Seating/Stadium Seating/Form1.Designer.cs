namespace Stadium_Seating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AseatsTextbox = new System.Windows.Forms.TextBox();
            this.BseatsTextbox = new System.Windows.Forms.TextBox();
            this.CseatsTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ArevenueLabel = new System.Windows.Forms.Label();
            this.BrevenueLabel = new System.Windows.Forms.Label();
            this.CrevenueLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CseatsTextbox);
            this.groupBox1.Controls.Add(this.BseatsTextbox);
            this.groupBox1.Controls.Add(this.AseatsTextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.CrevenueLabel);
            this.groupBox2.Controls.Add(this.BrevenueLabel);
            this.groupBox2.Controls.Add(this.ArevenueLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(220, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(65, 199);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(169, 199);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(272, 199);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for each class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C";
            // 
            // AseatsTextbox
            // 
            this.AseatsTextbox.Location = new System.Drawing.Point(52, 60);
            this.AseatsTextbox.Name = "AseatsTextbox";
            this.AseatsTextbox.Size = new System.Drawing.Size(100, 20);
            this.AseatsTextbox.TabIndex = 4;
            // 
            // BseatsTextbox
            // 
            this.BseatsTextbox.Location = new System.Drawing.Point(52, 86);
            this.BseatsTextbox.Name = "BseatsTextbox";
            this.BseatsTextbox.Size = new System.Drawing.Size(100, 20);
            this.BseatsTextbox.TabIndex = 5;
            // 
            // CseatsTextbox
            // 
            this.CseatsTextbox.Location = new System.Drawing.Point(52, 113);
            this.CseatsTextbox.Name = "CseatsTextbox";
            this.CseatsTextbox.Size = new System.Drawing.Size(100, 20);
            this.CseatsTextbox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Class B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Class C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total";
            // 
            // ArevenueLabel
            // 
            this.ArevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArevenueLabel.Location = new System.Drawing.Point(47, 30);
            this.ArevenueLabel.Name = "ArevenueLabel";
            this.ArevenueLabel.Size = new System.Drawing.Size(100, 23);
            this.ArevenueLabel.TabIndex = 4;
            this.ArevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrevenueLabel
            // 
            this.BrevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrevenueLabel.Location = new System.Drawing.Point(47, 57);
            this.BrevenueLabel.Name = "BrevenueLabel";
            this.BrevenueLabel.Size = new System.Drawing.Size(100, 23);
            this.BrevenueLabel.TabIndex = 5;
            this.BrevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CrevenueLabel
            // 
            this.CrevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrevenueLabel.Location = new System.Drawing.Point(47, 83);
            this.CrevenueLabel.Name = "CrevenueLabel";
            this.CrevenueLabel.Size = new System.Drawing.Size(100, 23);
            this.CrevenueLabel.TabIndex = 6;
            this.CrevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(47, 110);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CseatsTextbox;
        private System.Windows.Forms.TextBox BseatsTextbox;
        private System.Windows.Forms.TextBox AseatsTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label CrevenueLabel;
        private System.Windows.Forms.Label BrevenueLabel;
        private System.Windows.Forms.Label ArevenueLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

