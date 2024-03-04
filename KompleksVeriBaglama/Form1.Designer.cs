namespace KompleksVeriBaglama
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
            this.listBoxVeriler = new System.Windows.Forms.ListBox();
            this.buttonVeriBagla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxVeriler
            // 
            this.listBoxVeriler.FormattingEnabled = true;
            this.listBoxVeriler.Location = new System.Drawing.Point(137, 12);
            this.listBoxVeriler.Name = "listBoxVeriler";
            this.listBoxVeriler.Size = new System.Drawing.Size(146, 186);
            this.listBoxVeriler.TabIndex = 0;
            // 
            // buttonVeriBagla
            // 
            this.buttonVeriBagla.Location = new System.Drawing.Point(34, 87);
            this.buttonVeriBagla.Name = "buttonVeriBagla";
            this.buttonVeriBagla.Size = new System.Drawing.Size(75, 23);
            this.buttonVeriBagla.TabIndex = 1;
            this.buttonVeriBagla.Text = "Veri Bağla";
            this.buttonVeriBagla.UseVisualStyleBackColor = true;
            this.buttonVeriBagla.Click += new System.EventHandler(this.buttonVeriBagla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 216);
            this.Controls.Add(this.buttonVeriBagla);
            this.Controls.Add(this.listBoxVeriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVeriler;
        private System.Windows.Forms.Button buttonVeriBagla;
    }
}

