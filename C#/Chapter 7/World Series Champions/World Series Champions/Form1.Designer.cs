namespace World_Series_Champions
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
            this.teamsListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // teamsListbox
            // 
            this.teamsListbox.FormattingEnabled = true;
            this.teamsListbox.Location = new System.Drawing.Point(13, 12);
            this.teamsListbox.Name = "teamsListbox";
            this.teamsListbox.Size = new System.Drawing.Size(259, 95);
            this.teamsListbox.TabIndex = 0;
            this.teamsListbox.SelectedIndexChanged += new System.EventHandler(this.teamsListbox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.teamsListbox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "World Series Champions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teamsListbox;
    }
}

