namespace RyukLoader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimazeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BReset_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AesBuilder_IV = new System.Windows.Forms.TextBox();
            this.AesBuilder_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BuilderBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FileURL_Box = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FReset_Btn = new System.Windows.Forms.Button();
            this.IVLabel = new System.Windows.Forms.Label();
            this.VectorFile_Box = new System.Windows.Forms.TextBox();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.AesRandomization_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AesFile_Box = new System.Windows.Forms.TextBox();
            this.SelectToEncrypt_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FileToEncrypt_Box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Aqua;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(686, 7);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 22);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimazeBtn
            // 
            this.MinimazeBtn.BackColor = System.Drawing.Color.Aqua;
            this.MinimazeBtn.FlatAppearance.BorderSize = 0;
            this.MinimazeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimazeBtn.ForeColor = System.Drawing.Color.Black;
            this.MinimazeBtn.Location = new System.Drawing.Point(646, 7);
            this.MinimazeBtn.Name = "MinimazeBtn";
            this.MinimazeBtn.Size = new System.Drawing.Size(34, 22);
            this.MinimazeBtn.TabIndex = 1;
            this.MinimazeBtn.Text = "_";
            this.MinimazeBtn.UseVisualStyleBackColor = false;
            this.MinimazeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ryuk Loader V 1.5\r\nGithub: https://github.com/k3rnel-dev\r\nTelegram: @K666Plus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RyukLoader.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BReset_Btn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AesBuilder_IV);
            this.groupBox1.Controls.Add(this.AesBuilder_Box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BuilderBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FileURL_Box);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Builder Options";
            // 
            // BReset_Btn
            // 
            this.BReset_Btn.BackColor = System.Drawing.Color.Cyan;
            this.BReset_Btn.FlatAppearance.BorderSize = 0;
            this.BReset_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReset_Btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BReset_Btn.ForeColor = System.Drawing.Color.Black;
            this.BReset_Btn.Location = new System.Drawing.Point(6, 171);
            this.BReset_Btn.Name = "BReset_Btn";
            this.BReset_Btn.Size = new System.Drawing.Size(156, 33);
            this.BReset_Btn.TabIndex = 18;
            this.BReset_Btn.Text = "RESET";
            this.BReset_Btn.UseVisualStyleBackColor = false;
            this.BReset_Btn.Click += new System.EventHandler(this.BReset_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "IV";
            // 
            // AesBuilder_IV
            // 
            this.AesBuilder_IV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AesBuilder_IV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AesBuilder_IV.ForeColor = System.Drawing.Color.Cyan;
            this.AesBuilder_IV.Location = new System.Drawing.Point(6, 137);
            this.AesBuilder_IV.Name = "AesBuilder_IV";
            this.AesBuilder_IV.Size = new System.Drawing.Size(339, 23);
            this.AesBuilder_IV.TabIndex = 11;
            this.AesBuilder_IV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AesBuilder_Box
            // 
            this.AesBuilder_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AesBuilder_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AesBuilder_Box.ForeColor = System.Drawing.Color.Cyan;
            this.AesBuilder_Box.Location = new System.Drawing.Point(6, 96);
            this.AesBuilder_Box.Name = "AesBuilder_Box";
            this.AesBuilder_Box.Size = new System.Drawing.Size(339, 23);
            this.AesBuilder_Box.TabIndex = 9;
            this.AesBuilder_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "AES-KEY";
            // 
            // BuilderBtn
            // 
            this.BuilderBtn.BackColor = System.Drawing.Color.Cyan;
            this.BuilderBtn.FlatAppearance.BorderSize = 0;
            this.BuilderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuilderBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuilderBtn.ForeColor = System.Drawing.Color.Black;
            this.BuilderBtn.Location = new System.Drawing.Point(171, 171);
            this.BuilderBtn.Name = "BuilderBtn";
            this.BuilderBtn.Size = new System.Drawing.Size(174, 33);
            this.BuilderBtn.TabIndex = 6;
            this.BuilderBtn.Text = "BUILD";
            this.BuilderBtn.UseVisualStyleBackColor = false;
            this.BuilderBtn.Click += new System.EventHandler(this.BuilderBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "URL";
            // 
            // FileURL_Box
            // 
            this.FileURL_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.FileURL_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileURL_Box.ForeColor = System.Drawing.Color.Cyan;
            this.FileURL_Box.Location = new System.Drawing.Point(6, 46);
            this.FileURL_Box.Name = "FileURL_Box";
            this.FileURL_Box.Size = new System.Drawing.Size(339, 23);
            this.FileURL_Box.TabIndex = 0;
            this.FileURL_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FReset_Btn);
            this.groupBox2.Controls.Add(this.IVLabel);
            this.groupBox2.Controls.Add(this.VectorFile_Box);
            this.groupBox2.Controls.Add(this.EncryptBtn);
            this.groupBox2.Controls.Add(this.AesRandomization_Btn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.AesFile_Box);
            this.groupBox2.Controls.Add(this.SelectToEncrypt_Btn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.FileToEncrypt_Box);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(372, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 215);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Options";
            // 
            // FReset_Btn
            // 
            this.FReset_Btn.BackColor = System.Drawing.Color.Cyan;
            this.FReset_Btn.FlatAppearance.BorderSize = 0;
            this.FReset_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FReset_Btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FReset_Btn.ForeColor = System.Drawing.Color.Black;
            this.FReset_Btn.Location = new System.Drawing.Point(9, 171);
            this.FReset_Btn.Name = "FReset_Btn";
            this.FReset_Btn.Size = new System.Drawing.Size(155, 33);
            this.FReset_Btn.TabIndex = 17;
            this.FReset_Btn.Text = "RESET";
            this.FReset_Btn.UseVisualStyleBackColor = false;
            this.FReset_Btn.Click += new System.EventHandler(this.FReset_Btn_Click);
            // 
            // IVLabel
            // 
            this.IVLabel.AutoSize = true;
            this.IVLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IVLabel.ForeColor = System.Drawing.Color.White;
            this.IVLabel.Location = new System.Drawing.Point(6, 119);
            this.IVLabel.Name = "IVLabel";
            this.IVLabel.Size = new System.Drawing.Size(21, 15);
            this.IVLabel.TabIndex = 16;
            this.IVLabel.Text = "IV";
            // 
            // VectorFile_Box
            // 
            this.VectorFile_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.VectorFile_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VectorFile_Box.ForeColor = System.Drawing.Color.Cyan;
            this.VectorFile_Box.Location = new System.Drawing.Point(6, 137);
            this.VectorFile_Box.Name = "VectorFile_Box";
            this.VectorFile_Box.Size = new System.Drawing.Size(342, 23);
            this.VectorFile_Box.TabIndex = 15;
            this.VectorFile_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.BackColor = System.Drawing.Color.Cyan;
            this.EncryptBtn.FlatAppearance.BorderSize = 0;
            this.EncryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptBtn.ForeColor = System.Drawing.Color.Black;
            this.EncryptBtn.Location = new System.Drawing.Point(170, 171);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(173, 33);
            this.EncryptBtn.TabIndex = 11;
            this.EncryptBtn.Text = "ENCRYPT";
            this.EncryptBtn.UseVisualStyleBackColor = false;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // AesRandomization_Btn
            // 
            this.AesRandomization_Btn.BackColor = System.Drawing.Color.Cyan;
            this.AesRandomization_Btn.FlatAppearance.BorderSize = 0;
            this.AesRandomization_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AesRandomization_Btn.Font = new System.Drawing.Font("Consolas", 7.75F, System.Drawing.FontStyle.Bold);
            this.AesRandomization_Btn.ForeColor = System.Drawing.Color.Black;
            this.AesRandomization_Btn.Location = new System.Drawing.Point(314, 95);
            this.AesRandomization_Btn.Name = "AesRandomization_Btn";
            this.AesRandomization_Btn.Size = new System.Drawing.Size(34, 22);
            this.AesRandomization_Btn.TabIndex = 14;
            this.AesRandomization_Btn.Text = "R";
            this.AesRandomization_Btn.UseVisualStyleBackColor = false;
            this.AesRandomization_Btn.Click += new System.EventHandler(this.AesRandomization_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "AES-KEY";
            // 
            // AesFile_Box
            // 
            this.AesFile_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AesFile_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AesFile_Box.ForeColor = System.Drawing.Color.Cyan;
            this.AesFile_Box.Location = new System.Drawing.Point(6, 95);
            this.AesFile_Box.Name = "AesFile_Box";
            this.AesFile_Box.Size = new System.Drawing.Size(302, 23);
            this.AesFile_Box.TabIndex = 12;
            this.AesFile_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectToEncrypt_Btn
            // 
            this.SelectToEncrypt_Btn.BackColor = System.Drawing.Color.Cyan;
            this.SelectToEncrypt_Btn.FlatAppearance.BorderSize = 0;
            this.SelectToEncrypt_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectToEncrypt_Btn.Font = new System.Drawing.Font("Consolas", 7.75F, System.Drawing.FontStyle.Bold);
            this.SelectToEncrypt_Btn.ForeColor = System.Drawing.Color.Black;
            this.SelectToEncrypt_Btn.Location = new System.Drawing.Point(314, 51);
            this.SelectToEncrypt_Btn.Name = "SelectToEncrypt_Btn";
            this.SelectToEncrypt_Btn.Size = new System.Drawing.Size(34, 22);
            this.SelectToEncrypt_Btn.TabIndex = 6;
            this.SelectToEncrypt_Btn.Text = "...";
            this.SelectToEncrypt_Btn.UseVisualStyleBackColor = false;
            this.SelectToEncrypt_Btn.Click += new System.EventHandler(this.SelectToEncrypt_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "File";
            // 
            // FileToEncrypt_Box
            // 
            this.FileToEncrypt_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.FileToEncrypt_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileToEncrypt_Box.ForeColor = System.Drawing.Color.Cyan;
            this.FileToEncrypt_Box.Location = new System.Drawing.Point(6, 51);
            this.FileToEncrypt_Box.Name = "FileToEncrypt_Box";
            this.FileToEncrypt_Box.Size = new System.Drawing.Size(302, 23);
            this.FileToEncrypt_Box.TabIndex = 11;
            this.FileToEncrypt_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(735, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MinimazeBtn);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryuk Loader - / MAIN \\";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimazeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileURL_Box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AesBuilder_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuilderBtn;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button AesRandomization_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AesFile_Box;
        private System.Windows.Forms.Button SelectToEncrypt_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FileToEncrypt_Box;
        private System.Windows.Forms.Label IVLabel;
        private System.Windows.Forms.TextBox VectorFile_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AesBuilder_IV;
        private System.Windows.Forms.Button BReset_Btn;
        private System.Windows.Forms.Button FReset_Btn;
    }
}

