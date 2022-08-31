namespace Heads_or_Tails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tailsButton = new System.Windows.Forms.Button();
            this.headsPicturebox = new System.Windows.Forms.PictureBox();
            this.tailsPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // headsButton
            // 
            this.headsButton.Location = new System.Drawing.Point(45, 187);
            this.headsButton.Name = "headsButton";
            this.headsButton.Size = new System.Drawing.Size(75, 38);
            this.headsButton.TabIndex = 0;
            this.headsButton.Text = "Show Heads";
            this.headsButton.UseVisualStyleBackColor = true;
            this.headsButton.Click += new System.EventHandler(this.headsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(162, 187);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tailsButton
            // 
            this.tailsButton.Location = new System.Drawing.Point(279, 187);
            this.tailsButton.Name = "tailsButton";
            this.tailsButton.Size = new System.Drawing.Size(75, 38);
            this.tailsButton.TabIndex = 2;
            this.tailsButton.Text = "Show Tails";
            this.tailsButton.UseVisualStyleBackColor = true;
            this.tailsButton.Click += new System.EventHandler(this.tailsButton_Click);
            // 
            // headsPicturebox
            // 
            this.headsPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("headsPicturebox.Image")));
            this.headsPicturebox.Location = new System.Drawing.Point(12, 12);
            this.headsPicturebox.Name = "headsPicturebox";
            this.headsPicturebox.Size = new System.Drawing.Size(184, 169);
            this.headsPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPicturebox.TabIndex = 3;
            this.headsPicturebox.TabStop = false;
            // 
            // tailsPicturebox
            // 
            this.tailsPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("tailsPicturebox.Image")));
            this.tailsPicturebox.Location = new System.Drawing.Point(203, 12);
            this.tailsPicturebox.Name = "tailsPicturebox";
            this.tailsPicturebox.Size = new System.Drawing.Size(184, 169);
            this.tailsPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPicturebox.TabIndex = 4;
            this.tailsPicturebox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 234);
            this.Controls.Add(this.tailsPicturebox);
            this.Controls.Add(this.headsPicturebox);
            this.Controls.Add(this.tailsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.headsButton);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.headsPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button headsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button tailsButton;
        private System.Windows.Forms.PictureBox headsPicturebox;
        private System.Windows.Forms.PictureBox tailsPicturebox;
    }
}

