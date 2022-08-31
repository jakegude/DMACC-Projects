namespace Joke_And_Punch_Line
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
            this.setupButton = new System.Windows.Forms.Button();
            this.punchlineButton = new System.Windows.Forms.Button();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(34, 41);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(75, 23);
            this.setupButton.TabIndex = 0;
            this.setupButton.Text = "Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // punchlineButton
            // 
            this.punchlineButton.Location = new System.Drawing.Point(178, 41);
            this.punchlineButton.Name = "punchlineButton";
            this.punchlineButton.Size = new System.Drawing.Size(75, 23);
            this.punchlineButton.TabIndex = 1;
            this.punchlineButton.Text = "Punch Line";
            this.punchlineButton.UseVisualStyleBackColor = true;
            this.punchlineButton.Click += new System.EventHandler(this.punchlineButton_Click);
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deliveryLabel.Location = new System.Drawing.Point(12, 9);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(266, 23);
            this.deliveryLabel.TabIndex = 2;
            this.deliveryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 75);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.punchlineButton);
            this.Controls.Add(this.setupButton);
            this.Name = "Form1";
            this.Text = "Joke and Punch Line";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button punchlineButton;
        private System.Windows.Forms.Label deliveryLabel;
    }
}

