namespace Data_Encryption_Compression_Simulator
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageEncryption = new System.Windows.Forms.TabPage();
            this.buttonStartE = new System.Windows.Forms.Button();
            this.buttonBroweSimpleText = new System.Windows.Forms.Button();
            this.buttonSaveEncryptedCompressedText = new System.Windows.Forms.Button();
            this.buttonSavePublicKey = new System.Windows.Forms.Button();
            this.buttonProceedeForCompression = new System.Windows.Forms.Button();
            this.richTextBoxEncrypte = new System.Windows.Forms.RichTextBox();
            this.buttonGenratePublicKey = new System.Windows.Forms.Button();
            this.buttonSavePrivateKey = new System.Windows.Forms.Button();
            this.buttonEncrypte = new System.Windows.Forms.Button();
            this.buttonBrowsePublicKey = new System.Windows.Forms.Button();
            this.textBoxPrivateKeyE = new System.Windows.Forms.TextBox();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.labelPrivateKey = new System.Windows.Forms.Label();
            this.labelPublicKey = new System.Windows.Forms.Label();
            this.tabPageDecryption = new System.Windows.Forms.TabPage();
            this.buttonStartD = new System.Windows.Forms.Button();
            this.buttonDecompress = new System.Windows.Forms.Button();
            this.buttonDecrypte = new System.Windows.Forms.Button();
            this.buttonSaveDecryptedText = new System.Windows.Forms.Button();
            this.buttonBrowseEncryptedText = new System.Windows.Forms.Button();
            this.richTextBoxDecryption = new System.Windows.Forms.RichTextBox();
            this.buttonBorowsePrivateKeyD = new System.Windows.Forms.Button();
            this.buttonSavePrivateKeyDecryption = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageEncryption.SuspendLayout();
            this.tabPageDecryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEncryption);
            this.tabControlMain.Controls.Add(this.tabPageDecryption);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(860, 438);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageEncryption
            // 
            this.tabPageEncryption.Controls.Add(this.buttonStartE);
            this.tabPageEncryption.Controls.Add(this.buttonBroweSimpleText);
            this.tabPageEncryption.Controls.Add(this.buttonSaveEncryptedCompressedText);
            this.tabPageEncryption.Controls.Add(this.buttonSavePublicKey);
            this.tabPageEncryption.Controls.Add(this.buttonProceedeForCompression);
            this.tabPageEncryption.Controls.Add(this.richTextBoxEncrypte);
            this.tabPageEncryption.Controls.Add(this.buttonGenratePublicKey);
            this.tabPageEncryption.Controls.Add(this.buttonSavePrivateKey);
            this.tabPageEncryption.Controls.Add(this.buttonEncrypte);
            this.tabPageEncryption.Controls.Add(this.buttonBrowsePublicKey);
            this.tabPageEncryption.Controls.Add(this.textBoxPrivateKeyE);
            this.tabPageEncryption.Controls.Add(this.textBoxPublicKey);
            this.tabPageEncryption.Controls.Add(this.labelPrivateKey);
            this.tabPageEncryption.Controls.Add(this.labelPublicKey);
            this.tabPageEncryption.Location = new System.Drawing.Point(4, 22);
            this.tabPageEncryption.Name = "tabPageEncryption";
            this.tabPageEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncryption.Size = new System.Drawing.Size(852, 412);
            this.tabPageEncryption.TabIndex = 0;
            this.tabPageEncryption.Text = "Encryption And Compression";
            this.tabPageEncryption.UseVisualStyleBackColor = true;
            // 
            // buttonStartE
            // 
            this.buttonStartE.Location = new System.Drawing.Point(6, 382);
            this.buttonStartE.Name = "buttonStartE";
            this.buttonStartE.Size = new System.Drawing.Size(75, 23);
            this.buttonStartE.TabIndex = 13;
            this.buttonStartE.Text = "Start";
            this.buttonStartE.UseVisualStyleBackColor = true;
            this.buttonStartE.Click += new System.EventHandler(this.buttonStartE_Click);
            // 
            // buttonBroweSimpleText
            // 
            this.buttonBroweSimpleText.Location = new System.Drawing.Point(94, 383);
            this.buttonBroweSimpleText.Name = "buttonBroweSimpleText";
            this.buttonBroweSimpleText.Size = new System.Drawing.Size(75, 23);
            this.buttonBroweSimpleText.TabIndex = 12;
            this.buttonBroweSimpleText.Text = "Browse Text";
            this.buttonBroweSimpleText.UseVisualStyleBackColor = true;
            this.buttonBroweSimpleText.Visible = false;
            // 
            // buttonSaveEncryptedCompressedText
            // 
            this.buttonSaveEncryptedCompressedText.Location = new System.Drawing.Point(175, 383);
            this.buttonSaveEncryptedCompressedText.Name = "buttonSaveEncryptedCompressedText";
            this.buttonSaveEncryptedCompressedText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEncryptedCompressedText.TabIndex = 11;
            this.buttonSaveEncryptedCompressedText.Text = "Save";
            this.buttonSaveEncryptedCompressedText.UseVisualStyleBackColor = true;
            this.buttonSaveEncryptedCompressedText.Visible = false;
            this.buttonSaveEncryptedCompressedText.Click += new System.EventHandler(this.buttonSaveEncryptedCompressedText_Click);
            // 
            // buttonSavePublicKey
            // 
            this.buttonSavePublicKey.Location = new System.Drawing.Point(200, 33);
            this.buttonSavePublicKey.Name = "buttonSavePublicKey";
            this.buttonSavePublicKey.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePublicKey.TabIndex = 10;
            this.buttonSavePublicKey.Text = "Save Key";
            this.buttonSavePublicKey.UseVisualStyleBackColor = true;
            this.buttonSavePublicKey.Visible = false;
            // 
            // buttonProceedeForCompression
            // 
            this.buttonProceedeForCompression.Location = new System.Drawing.Point(770, 382);
            this.buttonProceedeForCompression.Name = "buttonProceedeForCompression";
            this.buttonProceedeForCompression.Size = new System.Drawing.Size(75, 23);
            this.buttonProceedeForCompression.TabIndex = 9;
            this.buttonProceedeForCompression.Text = "Compress";
            this.buttonProceedeForCompression.UseVisualStyleBackColor = true;
            this.buttonProceedeForCompression.Click += new System.EventHandler(this.buttonProceedeForCompression_Click);
            // 
            // richTextBoxEncrypte
            // 
            this.richTextBoxEncrypte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEncrypte.Location = new System.Drawing.Point(6, 61);
            this.richTextBoxEncrypte.Name = "richTextBoxEncrypte";
            this.richTextBoxEncrypte.Size = new System.Drawing.Size(839, 315);
            this.richTextBoxEncrypte.TabIndex = 8;
            this.richTextBoxEncrypte.Text = "Data Encryption Compression Simulator\n\nMuhammad Tausif\nMC080401902,MCS\n\nProject I" +
                "D F10204027";
            // 
            // buttonGenratePublicKey
            // 
            this.buttonGenratePublicKey.Location = new System.Drawing.Point(294, 32);
            this.buttonGenratePublicKey.Name = "buttonGenratePublicKey";
            this.buttonGenratePublicKey.Size = new System.Drawing.Size(75, 23);
            this.buttonGenratePublicKey.TabIndex = 7;
            this.buttonGenratePublicKey.Text = "Genrate";
            this.buttonGenratePublicKey.UseVisualStyleBackColor = true;
            this.buttonGenratePublicKey.Click += new System.EventHandler(this.buttonGenratePublicKey_Click);
            // 
            // buttonSavePrivateKey
            // 
            this.buttonSavePrivateKey.Location = new System.Drawing.Point(770, 32);
            this.buttonSavePrivateKey.Name = "buttonSavePrivateKey";
            this.buttonSavePrivateKey.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePrivateKey.TabIndex = 6;
            this.buttonSavePrivateKey.Text = "Save Key";
            this.buttonSavePrivateKey.UseVisualStyleBackColor = true;
            this.buttonSavePrivateKey.Visible = false;
            // 
            // buttonEncrypte
            // 
            this.buttonEncrypte.Location = new System.Drawing.Point(689, 382);
            this.buttonEncrypte.Name = "buttonEncrypte";
            this.buttonEncrypte.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypte.TabIndex = 5;
            this.buttonEncrypte.Text = "Encrypte";
            this.buttonEncrypte.UseVisualStyleBackColor = true;
            this.buttonEncrypte.Click += new System.EventHandler(this.buttonEncrypte_Click);
            // 
            // buttonBrowsePublicKey
            // 
            this.buttonBrowsePublicKey.Location = new System.Drawing.Point(119, 33);
            this.buttonBrowsePublicKey.Name = "buttonBrowsePublicKey";
            this.buttonBrowsePublicKey.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsePublicKey.TabIndex = 4;
            this.buttonBrowsePublicKey.Text = "Browse";
            this.buttonBrowsePublicKey.UseVisualStyleBackColor = true;
            this.buttonBrowsePublicKey.Visible = false;
            // 
            // textBoxPrivateKeyE
            // 
            this.textBoxPrivateKeyE.ForeColor = System.Drawing.Color.DarkRed;
            this.textBoxPrivateKeyE.Location = new System.Drawing.Point(595, 6);
            this.textBoxPrivateKeyE.Name = "textBoxPrivateKeyE";
            this.textBoxPrivateKeyE.Size = new System.Drawing.Size(250, 20);
            this.textBoxPrivateKeyE.TabIndex = 3;
            this.textBoxPrivateKeyE.Text = "3599,61937";
            this.textBoxPrivateKeyE.TextChanged += new System.EventHandler(this.textBoxPrivateKeyE_TextChanged);
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.ForeColor = System.Drawing.Color.Red;
            this.textBoxPublicKey.Location = new System.Drawing.Point(119, 6);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(250, 20);
            this.textBoxPublicKey.TabIndex = 2;
            this.textBoxPublicKey.Text = "239,61937";
            // 
            // labelPrivateKey
            // 
            this.labelPrivateKey.AutoSize = true;
            this.labelPrivateKey.Location = new System.Drawing.Point(529, 9);
            this.labelPrivateKey.Name = "labelPrivateKey";
            this.labelPrivateKey.Size = new System.Drawing.Size(61, 13);
            this.labelPrivateKey.TabIndex = 1;
            this.labelPrivateKey.Text = "Private Key";
            // 
            // labelPublicKey
            // 
            this.labelPublicKey.AutoSize = true;
            this.labelPublicKey.Location = new System.Drawing.Point(6, 9);
            this.labelPublicKey.Name = "labelPublicKey";
            this.labelPublicKey.Size = new System.Drawing.Size(57, 13);
            this.labelPublicKey.TabIndex = 0;
            this.labelPublicKey.Text = "Public Key";
            // 
            // tabPageDecryption
            // 
            this.tabPageDecryption.Controls.Add(this.buttonStartD);
            this.tabPageDecryption.Controls.Add(this.buttonDecompress);
            this.tabPageDecryption.Controls.Add(this.buttonDecrypte);
            this.tabPageDecryption.Controls.Add(this.buttonSaveDecryptedText);
            this.tabPageDecryption.Controls.Add(this.buttonBrowseEncryptedText);
            this.tabPageDecryption.Controls.Add(this.richTextBoxDecryption);
            this.tabPageDecryption.Controls.Add(this.buttonBorowsePrivateKeyD);
            this.tabPageDecryption.Controls.Add(this.buttonSavePrivateKeyDecryption);
            this.tabPageDecryption.Controls.Add(this.label1);
            this.tabPageDecryption.Controls.Add(this.textBoxPrivateKey);
            this.tabPageDecryption.Location = new System.Drawing.Point(4, 22);
            this.tabPageDecryption.Name = "tabPageDecryption";
            this.tabPageDecryption.Size = new System.Drawing.Size(852, 412);
            this.tabPageDecryption.TabIndex = 3;
            this.tabPageDecryption.Text = "Decompression And Decryption";
            this.tabPageDecryption.UseVisualStyleBackColor = true;
            // 
            // buttonStartD
            // 
            this.buttonStartD.ForeColor = System.Drawing.Color.Crimson;
            this.buttonStartD.Location = new System.Drawing.Point(6, 382);
            this.buttonStartD.Name = "buttonStartD";
            this.buttonStartD.Size = new System.Drawing.Size(75, 23);
            this.buttonStartD.TabIndex = 9;
            this.buttonStartD.Text = "Start";
            this.buttonStartD.UseVisualStyleBackColor = true;
            this.buttonStartD.Click += new System.EventHandler(this.buttonStartD_Click);
            // 
            // buttonDecompress
            // 
            this.buttonDecompress.Location = new System.Drawing.Point(689, 382);
            this.buttonDecompress.Name = "buttonDecompress";
            this.buttonDecompress.Size = new System.Drawing.Size(75, 23);
            this.buttonDecompress.TabIndex = 8;
            this.buttonDecompress.Text = "Decompress";
            this.buttonDecompress.UseVisualStyleBackColor = true;
            this.buttonDecompress.Click += new System.EventHandler(this.buttonDecompress_Click);
            // 
            // buttonDecrypte
            // 
            this.buttonDecrypte.Location = new System.Drawing.Point(770, 382);
            this.buttonDecrypte.Name = "buttonDecrypte";
            this.buttonDecrypte.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypte.TabIndex = 7;
            this.buttonDecrypte.Text = "Decrypte";
            this.buttonDecrypte.UseVisualStyleBackColor = true;
            this.buttonDecrypte.Click += new System.EventHandler(this.buttonDecrypte_Click);
            // 
            // buttonSaveDecryptedText
            // 
            this.buttonSaveDecryptedText.Location = new System.Drawing.Point(168, 382);
            this.buttonSaveDecryptedText.Name = "buttonSaveDecryptedText";
            this.buttonSaveDecryptedText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveDecryptedText.TabIndex = 6;
            this.buttonSaveDecryptedText.Text = "Save";
            this.buttonSaveDecryptedText.UseVisualStyleBackColor = true;
            this.buttonSaveDecryptedText.Visible = false;
            // 
            // buttonBrowseEncryptedText
            // 
            this.buttonBrowseEncryptedText.Location = new System.Drawing.Point(87, 382);
            this.buttonBrowseEncryptedText.Name = "buttonBrowseEncryptedText";
            this.buttonBrowseEncryptedText.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseEncryptedText.TabIndex = 5;
            this.buttonBrowseEncryptedText.Text = "Browse Text";
            this.buttonBrowseEncryptedText.UseVisualStyleBackColor = true;
            this.buttonBrowseEncryptedText.Visible = false;
            // 
            // richTextBoxDecryption
            // 
            this.richTextBoxDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDecryption.Location = new System.Drawing.Point(6, 61);
            this.richTextBoxDecryption.Name = "richTextBoxDecryption";
            this.richTextBoxDecryption.Size = new System.Drawing.Size(839, 315);
            this.richTextBoxDecryption.TabIndex = 4;
            this.richTextBoxDecryption.Text = "";
            // 
            // buttonBorowsePrivateKeyD
            // 
            this.buttonBorowsePrivateKeyD.Location = new System.Drawing.Point(689, 32);
            this.buttonBorowsePrivateKeyD.Name = "buttonBorowsePrivateKeyD";
            this.buttonBorowsePrivateKeyD.Size = new System.Drawing.Size(75, 23);
            this.buttonBorowsePrivateKeyD.TabIndex = 3;
            this.buttonBorowsePrivateKeyD.Text = "Browse key";
            this.buttonBorowsePrivateKeyD.UseVisualStyleBackColor = true;
            this.buttonBorowsePrivateKeyD.Visible = false;
            // 
            // buttonSavePrivateKeyDecryption
            // 
            this.buttonSavePrivateKeyDecryption.Location = new System.Drawing.Point(770, 32);
            this.buttonSavePrivateKeyDecryption.Name = "buttonSavePrivateKeyDecryption";
            this.buttonSavePrivateKeyDecryption.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePrivateKeyDecryption.TabIndex = 2;
            this.buttonSavePrivateKeyDecryption.Text = "Save key";
            this.buttonSavePrivateKeyDecryption.UseVisualStyleBackColor = true;
            this.buttonSavePrivateKeyDecryption.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Private Key";
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(595, 6);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(250, 20);
            this.textBoxPrivateKey.TabIndex = 0;
            this.textBoxPrivateKey.Text = "3599,61937";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.tabControlMain);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Encryption Compression Simulator";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEncryption.ResumeLayout(false);
            this.tabPageEncryption.PerformLayout();
            this.tabPageDecryption.ResumeLayout(false);
            this.tabPageDecryption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEncryption;
        private System.Windows.Forms.TabPage tabPageDecryption;
        private System.Windows.Forms.TextBox textBoxPrivateKeyE;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Label labelPrivateKey;
        private System.Windows.Forms.Label labelPublicKey;
        private System.Windows.Forms.Button buttonBroweSimpleText;
        private System.Windows.Forms.Button buttonSaveEncryptedCompressedText;
        private System.Windows.Forms.Button buttonSavePublicKey;
        private System.Windows.Forms.Button buttonProceedeForCompression;
        private System.Windows.Forms.RichTextBox richTextBoxEncrypte;
        private System.Windows.Forms.Button buttonGenratePublicKey;
        private System.Windows.Forms.Button buttonSavePrivateKey;
        private System.Windows.Forms.Button buttonEncrypte;
        private System.Windows.Forms.Button buttonBrowsePublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Button buttonDecompress;
        private System.Windows.Forms.Button buttonDecrypte;
        private System.Windows.Forms.Button buttonSaveDecryptedText;
        private System.Windows.Forms.Button buttonBrowseEncryptedText;
        private System.Windows.Forms.RichTextBox richTextBoxDecryption;
        private System.Windows.Forms.Button buttonBorowsePrivateKeyD;
        private System.Windows.Forms.Button buttonSavePrivateKeyDecryption;
        private System.Windows.Forms.Button buttonStartD;
        private System.Windows.Forms.Button buttonStartE;
    }
}
