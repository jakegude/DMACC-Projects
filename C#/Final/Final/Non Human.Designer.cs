namespace Final
{
    partial class Non_Human
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
            this.orcRadio = new System.Windows.Forms.RadioButton();
            this.hobbitRadio = new System.Windows.Forms.RadioButton();
            this.dwarfRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.wookieRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // orcRadio
            // 
            this.orcRadio.AutoSize = true;
            this.orcRadio.Location = new System.Drawing.Point(16, 43);
            this.orcRadio.Name = "orcRadio";
            this.orcRadio.Size = new System.Drawing.Size(42, 17);
            this.orcRadio.TabIndex = 0;
            this.orcRadio.Text = "Orc";
            this.orcRadio.UseVisualStyleBackColor = true;
            this.orcRadio.CheckedChanged += new System.EventHandler(this.orcRadio_CheckedChanged);
            // 
            // hobbitRadio
            // 
            this.hobbitRadio.AutoSize = true;
            this.hobbitRadio.Location = new System.Drawing.Point(16, 67);
            this.hobbitRadio.Name = "hobbitRadio";
            this.hobbitRadio.Size = new System.Drawing.Size(56, 17);
            this.hobbitRadio.TabIndex = 1;
            this.hobbitRadio.Text = "Hobbit";
            this.hobbitRadio.UseVisualStyleBackColor = true;
            this.hobbitRadio.CheckedChanged += new System.EventHandler(this.hobbitRadio_CheckedChanged);
            // 
            // dwarfRadio
            // 
            this.dwarfRadio.AutoSize = true;
            this.dwarfRadio.Location = new System.Drawing.Point(78, 43);
            this.dwarfRadio.Name = "dwarfRadio";
            this.dwarfRadio.Size = new System.Drawing.Size(53, 17);
            this.dwarfRadio.TabIndex = 2;
            this.dwarfRadio.Text = "Dwarf";
            this.dwarfRadio.UseVisualStyleBackColor = true;
            this.dwarfRadio.CheckedChanged += new System.EventHandler(this.dwarfRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "What kind of non-human would you like to be?:";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(155, 54);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // wookieRadio
            // 
            this.wookieRadio.AutoSize = true;
            this.wookieRadio.Location = new System.Drawing.Point(79, 67);
            this.wookieRadio.Name = "wookieRadio";
            this.wookieRadio.Size = new System.Drawing.Size(62, 17);
            this.wookieRadio.TabIndex = 6;
            this.wookieRadio.TabStop = true;
            this.wookieRadio.Text = "Wookie";
            this.wookieRadio.UseVisualStyleBackColor = true;
            this.wookieRadio.CheckedChanged += new System.EventHandler(this.wookieRadio_CheckedChanged);
            // 
            // Non_Human
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 96);
            this.Controls.Add(this.wookieRadio);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dwarfRadio);
            this.Controls.Add(this.hobbitRadio);
            this.Controls.Add(this.orcRadio);
            this.Name = "Non_Human";
            this.Text = "Non-Human";
            this.Load += new System.EventHandler(this.Non_Human_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton orcRadio;
        public System.Windows.Forms.RadioButton hobbitRadio;
        public System.Windows.Forms.RadioButton dwarfRadio;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.RadioButton wookieRadio;
    }
}