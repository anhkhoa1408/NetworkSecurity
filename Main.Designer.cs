
namespace NETWORK_SECURITY_APP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.techniqueBox = new System.Windows.Forms.ComboBox();
            this.inputText = new System.Windows.Forms.Label();
            this.inputEncryptBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputDecryptBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.decryptTechnique = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 469);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 118);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIMPLE CRYPTOOL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(249, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 469);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.keyBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.encryptBtn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.techniqueBox);
            this.tabPage1.Controls.Add(this.inputText);
            this.tabPage1.Controls.Add(this.inputEncryptBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(120, 108);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(211, 27);
            this.keyBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input Key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // encryptBtn
            // 
            this.encryptBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.encryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.encryptBtn.Location = new System.Drawing.Point(276, 366);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(111, 41);
            this.encryptBtn.TabIndex = 5;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = false;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Technique";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // techniqueBox
            // 
            this.techniqueBox.FormattingEnabled = true;
            this.techniqueBox.Items.AddRange(new object[] {
            "Ceasar",
            "Rail Fence",
            "Combine"});
            this.techniqueBox.Location = new System.Drawing.Point(120, 46);
            this.techniqueBox.Name = "techniqueBox";
            this.techniqueBox.Size = new System.Drawing.Size(212, 28);
            this.techniqueBox.TabIndex = 3;
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputText.Location = new System.Drawing.Point(15, 169);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(99, 41);
            this.inputText.TabIndex = 2;
            this.inputText.Text = "Input Text";
            this.inputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputEncryptBox
            // 
            this.inputEncryptBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputEncryptBox.Location = new System.Drawing.Point(120, 177);
            this.inputEncryptBox.Multiline = true;
            this.inputEncryptBox.Name = "inputEncryptBox";
            this.inputEncryptBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputEncryptBox.Size = new System.Drawing.Size(501, 166);
            this.inputEncryptBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.decryptTechnique);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.decryptBtn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.inputDecryptBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // decryptBtn
            // 
            this.decryptBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.decryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.decryptBtn.Location = new System.Drawing.Point(279, 330);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(111, 41);
            this.decryptBtn.TabIndex = 6;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = false;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input Text";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputDecryptBox
            // 
            this.inputDecryptBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputDecryptBox.Location = new System.Drawing.Point(121, 97);
            this.inputDecryptBox.Multiline = true;
            this.inputDecryptBox.Name = "inputDecryptBox";
            this.inputDecryptBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputDecryptBox.Size = new System.Drawing.Size(501, 189);
            this.inputDecryptBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "Technique";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decryptTechnique
            // 
            this.decryptTechnique.FormattingEnabled = true;
            this.decryptTechnique.Items.AddRange(new object[] {
            "Ceasar",
            "Rail Fence",
            "Combine"});
            this.decryptTechnique.Location = new System.Drawing.Point(121, 38);
            this.decryptTechnique.Name = "decryptTechnique";
            this.decryptTechnique.Size = new System.Drawing.Size(212, 28);
            this.decryptTechnique.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 469);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Simple Cryptool";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox techniqueBox;
        private System.Windows.Forms.Label inputText;
        private System.Windows.Forms.TextBox inputEncryptBox;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputDecryptBox;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox decryptTechnique;
        private System.Windows.Forms.Label label5;
    }
}