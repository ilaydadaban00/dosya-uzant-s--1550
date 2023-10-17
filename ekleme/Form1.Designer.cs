namespace ekleme
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
            this.btnKontrol = new System.Windows.Forms.Button();
            this.gbUzantıTuru = new System.Windows.Forms.GroupBox();
            this.gbDosyaTuru = new System.Windows.Forms.GroupBox();
            this.rb1videodosyasi = new System.Windows.Forms.RadioButton();
            this.rb2ResimDosyası = new System.Windows.Forms.RadioButton();
            this.lbuzanttı = new System.Windows.Forms.ListBox();
            this.gbUzantıTuru.SuspendLayout();
            this.gbDosyaTuru.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKontrol
            // 
            this.btnKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKontrol.Location = new System.Drawing.Point(51, 152);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "kontrol";
            this.btnKontrol.UseVisualStyleBackColor = false;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // gbUzantıTuru
            // 
            this.gbUzantıTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbUzantıTuru.Controls.Add(this.lbuzanttı);
            this.gbUzantıTuru.Location = new System.Drawing.Point(12, 12);
            this.gbUzantıTuru.Name = "gbUzantıTuru";
            this.gbUzantıTuru.Size = new System.Drawing.Size(200, 100);
            this.gbUzantıTuru.TabIndex = 2;
            this.gbUzantıTuru.TabStop = false;
            this.gbUzantıTuru.Text = "uzantı türü";
            // 
            // gbDosyaTuru
            // 
            this.gbDosyaTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbDosyaTuru.Controls.Add(this.rb2ResimDosyası);
            this.gbDosyaTuru.Controls.Add(this.rb1videodosyasi);
            this.gbDosyaTuru.Location = new System.Drawing.Point(248, 12);
            this.gbDosyaTuru.Name = "gbDosyaTuru";
            this.gbDosyaTuru.Size = new System.Drawing.Size(200, 100);
            this.gbDosyaTuru.TabIndex = 3;
            this.gbDosyaTuru.TabStop = false;
            this.gbDosyaTuru.Text = "dosya türü";
            // 
            // rb1videodosyasi
            // 
            this.rb1videodosyasi.AutoSize = true;
            this.rb1videodosyasi.Location = new System.Drawing.Point(18, 32);
            this.rb1videodosyasi.Name = "rb1videodosyasi";
            this.rb1videodosyasi.Size = new System.Drawing.Size(89, 17);
            this.rb1videodosyasi.TabIndex = 0;
            this.rb1videodosyasi.TabStop = true;
            this.rb1videodosyasi.Text = "video dosyası";
            this.rb1videodosyasi.UseVisualStyleBackColor = true;
            // 
            // rb2ResimDosyası
            // 
            this.rb2ResimDosyası.AutoSize = true;
            this.rb2ResimDosyası.Location = new System.Drawing.Point(18, 55);
            this.rb2ResimDosyası.Name = "rb2ResimDosyası";
            this.rb2ResimDosyası.Size = new System.Drawing.Size(87, 17);
            this.rb2ResimDosyası.TabIndex = 1;
            this.rb2ResimDosyası.TabStop = true;
            this.rb2ResimDosyası.Text = "resim dosyası";
            this.rb2ResimDosyası.UseVisualStyleBackColor = true;
            // 
            // lbuzanttı
            // 
            this.lbuzanttı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbuzanttı.FormattingEnabled = true;
            this.lbuzanttı.Items.AddRange(new object[] {
            "mp4",
            "jpg",
            "mov",
            "png"});
            this.lbuzanttı.Location = new System.Drawing.Point(6, 19);
            this.lbuzanttı.Name = "lbuzanttı";
            this.lbuzanttı.Size = new System.Drawing.Size(120, 69);
            this.lbuzanttı.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(465, 316);
            this.Controls.Add(this.gbDosyaTuru);
            this.Controls.Add(this.gbUzantıTuru);
            this.Controls.Add(this.btnKontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbUzantıTuru.ResumeLayout(false);
            this.gbDosyaTuru.ResumeLayout(false);
            this.gbDosyaTuru.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.GroupBox gbUzantıTuru;
        private System.Windows.Forms.ListBox lbuzanttı;
        private System.Windows.Forms.GroupBox gbDosyaTuru;
        private System.Windows.Forms.RadioButton rb2ResimDosyası;
        private System.Windows.Forms.RadioButton rb1videodosyasi;
    }
}

