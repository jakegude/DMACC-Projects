namespace Population
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
            this.startingTextbox = new System.Windows.Forms.TextBox();
            this.increaseTextbox = new System.Windows.Forms.TextBox();
            this.daysTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputListbox = new System.Windows.Forms.ListBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingTextbox
            // 
            this.startingTextbox.Location = new System.Drawing.Point(180, 13);
            this.startingTextbox.Name = "startingTextbox";
            this.startingTextbox.Size = new System.Drawing.Size(100, 20);
            this.startingTextbox.TabIndex = 0;
            // 
            // increaseTextbox
            // 
            this.increaseTextbox.Location = new System.Drawing.Point(180, 39);
            this.increaseTextbox.Name = "increaseTextbox";
            this.increaseTextbox.Size = new System.Drawing.Size(100, 20);
            this.increaseTextbox.TabIndex = 1;
            // 
            // daysTextbox
            // 
            this.daysTextbox.Location = new System.Drawing.Point(180, 65);
            this.daysTextbox.Name = "daysTextbox";
            this.daysTextbox.Size = new System.Drawing.Size(100, 20);
            this.daysTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Starting Number of Organisms:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average Daily Increase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Days to Multiply:";
            // 
            // outputListbox
            // 
            this.outputListbox.FormattingEnabled = true;
            this.outputListbox.Location = new System.Drawing.Point(12, 127);
            this.outputListbox.Name = "outputListbox";
            this.outputListbox.Size = new System.Drawing.Size(268, 121);
            this.outputListbox.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 98);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(108, 98);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(204, 98);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 260);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.outputListbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daysTextbox);
            this.Controls.Add(this.increaseTextbox);
            this.Controls.Add(this.startingTextbox);
            this.Name = "Form1";
            this.Text = "Population Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startingTextbox;
        private System.Windows.Forms.TextBox increaseTextbox;
        private System.Windows.Forms.TextBox daysTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox outputListbox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

