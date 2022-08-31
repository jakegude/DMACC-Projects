namespace Addition_Tutor1
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
            this.answerTextbox = new System.Windows.Forms.TextBox();
            this.num1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerTextbox
            // 
            this.answerTextbox.Location = new System.Drawing.Point(152, 34);
            this.answerTextbox.Name = "answerTextbox";
            this.answerTextbox.Size = new System.Drawing.Size(100, 20);
            this.answerTextbox.TabIndex = 0;
            this.answerTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num1Label
            // 
            this.num1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num1Label.Location = new System.Drawing.Point(13, 33);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(36, 23);
            this.num1Label.TabIndex = 1;
            this.num1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // num2Label
            // 
            this.num2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num2Label.Location = new System.Drawing.Point(74, 32);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(36, 23);
            this.num2Label.TabIndex = 3;
            this.num2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Answer:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(35, 63);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(152, 63);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num1Label);
            this.Controls.Add(this.answerTextbox);
            this.Name = "Form1";
            this.Text = "Addition Tutor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerTextbox;
        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
    }
}

