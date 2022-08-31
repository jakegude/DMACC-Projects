namespace Car
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
            this.accelerateButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accelerateButton
            // 
            this.accelerateButton.Location = new System.Drawing.Point(3, 4);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(75, 23);
            this.accelerateButton.TabIndex = 0;
            this.accelerateButton.Text = "Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.Location = new System.Drawing.Point(3, 34);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(75, 23);
            this.brakeButton.TabIndex = 1;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(85, 4);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 53);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 64);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.accelerateButton);
            this.Name = "Form1";
            this.Text = "Car";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

