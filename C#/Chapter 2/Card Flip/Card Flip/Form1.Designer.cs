namespace Card_Flip
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
            this.cardbackPictruebox = new System.Windows.Forms.PictureBox();
            this.cardfrontPictruebox = new System.Windows.Forms.PictureBox();
            this.showbackButton = new System.Windows.Forms.Button();
            this.showfaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictruebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfrontPictruebox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardbackPictruebox
            // 
            this.cardbackPictruebox.Image = ((System.Drawing.Image)(resources.GetObject("cardbackPictruebox.Image")));
            this.cardbackPictruebox.Location = new System.Drawing.Point(12, 12);
            this.cardbackPictruebox.Name = "cardbackPictruebox";
            this.cardbackPictruebox.Size = new System.Drawing.Size(145, 200);
            this.cardbackPictruebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardbackPictruebox.TabIndex = 0;
            this.cardbackPictruebox.TabStop = false;
            // 
            // cardfrontPictruebox
            // 
            this.cardfrontPictruebox.Image = ((System.Drawing.Image)(resources.GetObject("cardfrontPictruebox.Image")));
            this.cardfrontPictruebox.Location = new System.Drawing.Point(177, 12);
            this.cardfrontPictruebox.Name = "cardfrontPictruebox";
            this.cardfrontPictruebox.Size = new System.Drawing.Size(145, 200);
            this.cardfrontPictruebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardfrontPictruebox.TabIndex = 1;
            this.cardfrontPictruebox.TabStop = false;
            // 
            // showbackButton
            // 
            this.showbackButton.Location = new System.Drawing.Point(44, 234);
            this.showbackButton.Name = "showbackButton";
            this.showbackButton.Size = new System.Drawing.Size(83, 43);
            this.showbackButton.TabIndex = 2;
            this.showbackButton.Text = "Show the Card Back";
            this.showbackButton.UseVisualStyleBackColor = true;
            this.showbackButton.Click += new System.EventHandler(this.showbackButton_Click);
            // 
            // showfaceButton
            // 
            this.showfaceButton.Location = new System.Drawing.Point(211, 234);
            this.showfaceButton.Name = "showfaceButton";
            this.showfaceButton.Size = new System.Drawing.Size(83, 43);
            this.showfaceButton.TabIndex = 3;
            this.showfaceButton.Text = "Show the Card Front";
            this.showfaceButton.UseVisualStyleBackColor = true;
            this.showfaceButton.Click += new System.EventHandler(this.showfaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 307);
            this.Controls.Add(this.showfaceButton);
            this.Controls.Add(this.showbackButton);
            this.Controls.Add(this.cardfrontPictruebox);
            this.Controls.Add(this.cardbackPictruebox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictruebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfrontPictruebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardbackPictruebox;
        private System.Windows.Forms.PictureBox cardfrontPictruebox;
        private System.Windows.Forms.Button showbackButton;
        private System.Windows.Forms.Button showfaceButton;
    }
}

