namespace Color_Mixer
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
            this.firstredRadiobutton = new System.Windows.Forms.RadioButton();
            this.firstblueRadiobutton = new System.Windows.Forms.RadioButton();
            this.firstyellowRadioButton = new System.Windows.Forms.RadioButton();
            this.secondredRadiobutton = new System.Windows.Forms.RadioButton();
            this.secondblueRadiobutton = new System.Windows.Forms.RadioButton();
            this.secondyellowRadiobutton = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstyellowRadioButton);
            this.groupBox1.Controls.Add(this.firstblueRadiobutton);
            this.groupBox1.Controls.Add(this.firstredRadiobutton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the First Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secondyellowRadiobutton);
            this.groupBox2.Controls.Add(this.secondblueRadiobutton);
            this.groupBox2.Controls.Add(this.secondredRadiobutton);
            this.groupBox2.Location = new System.Drawing.Point(175, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the Second Color";
            // 
            // firstredRadiobutton
            // 
            this.firstredRadiobutton.AutoSize = true;
            this.firstredRadiobutton.Location = new System.Drawing.Point(7, 20);
            this.firstredRadiobutton.Name = "firstredRadiobutton";
            this.firstredRadiobutton.Size = new System.Drawing.Size(45, 17);
            this.firstredRadiobutton.TabIndex = 0;
            this.firstredRadiobutton.TabStop = true;
            this.firstredRadiobutton.Text = "Red";
            this.firstredRadiobutton.UseVisualStyleBackColor = true;
            // 
            // firstblueRadiobutton
            // 
            this.firstblueRadiobutton.AutoSize = true;
            this.firstblueRadiobutton.Location = new System.Drawing.Point(7, 44);
            this.firstblueRadiobutton.Name = "firstblueRadiobutton";
            this.firstblueRadiobutton.Size = new System.Drawing.Size(46, 17);
            this.firstblueRadiobutton.TabIndex = 1;
            this.firstblueRadiobutton.TabStop = true;
            this.firstblueRadiobutton.Text = "Blue";
            this.firstblueRadiobutton.UseVisualStyleBackColor = true;
            // 
            // firstyellowRadioButton
            // 
            this.firstyellowRadioButton.AutoSize = true;
            this.firstyellowRadioButton.Location = new System.Drawing.Point(7, 68);
            this.firstyellowRadioButton.Name = "firstyellowRadioButton";
            this.firstyellowRadioButton.Size = new System.Drawing.Size(56, 17);
            this.firstyellowRadioButton.TabIndex = 2;
            this.firstyellowRadioButton.TabStop = true;
            this.firstyellowRadioButton.Text = "Yellow";
            this.firstyellowRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondredRadiobutton
            // 
            this.secondredRadiobutton.AutoSize = true;
            this.secondredRadiobutton.Location = new System.Drawing.Point(7, 20);
            this.secondredRadiobutton.Name = "secondredRadiobutton";
            this.secondredRadiobutton.Size = new System.Drawing.Size(45, 17);
            this.secondredRadiobutton.TabIndex = 0;
            this.secondredRadiobutton.TabStop = true;
            this.secondredRadiobutton.Text = "Red";
            this.secondredRadiobutton.UseVisualStyleBackColor = true;
            // 
            // secondblueRadiobutton
            // 
            this.secondblueRadiobutton.AutoSize = true;
            this.secondblueRadiobutton.Location = new System.Drawing.Point(7, 44);
            this.secondblueRadiobutton.Name = "secondblueRadiobutton";
            this.secondblueRadiobutton.Size = new System.Drawing.Size(46, 17);
            this.secondblueRadiobutton.TabIndex = 1;
            this.secondblueRadiobutton.TabStop = true;
            this.secondblueRadiobutton.Text = "Blue";
            this.secondblueRadiobutton.UseVisualStyleBackColor = true;
            // 
            // secondyellowRadiobutton
            // 
            this.secondyellowRadiobutton.AutoSize = true;
            this.secondyellowRadiobutton.Location = new System.Drawing.Point(7, 68);
            this.secondyellowRadiobutton.Name = "secondyellowRadiobutton";
            this.secondyellowRadiobutton.Size = new System.Drawing.Size(56, 17);
            this.secondyellowRadiobutton.TabIndex = 2;
            this.secondyellowRadiobutton.TabStop = true;
            this.secondyellowRadiobutton.Text = "Yellow";
            this.secondyellowRadiobutton.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(93, 120);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(75, 23);
            this.mixButton.TabIndex = 2;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(174, 119);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 166);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton firstyellowRadioButton;
        private System.Windows.Forms.RadioButton firstblueRadiobutton;
        private System.Windows.Forms.RadioButton firstredRadiobutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton secondyellowRadiobutton;
        private System.Windows.Forms.RadioButton secondblueRadiobutton;
        private System.Windows.Forms.RadioButton secondredRadiobutton;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

