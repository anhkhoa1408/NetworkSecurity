
namespace NETWORK_SECURITY_APP
{
    partial class Output
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Output));
            this.decryptOutputBox = new System.Windows.Forms.TextBox();
            this.yesBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decryptOutputBox
            // 
            this.decryptOutputBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.decryptOutputBox.Location = new System.Drawing.Point(12, 12);
            this.decryptOutputBox.Multiline = true;
            this.decryptOutputBox.Name = "decryptOutputBox";
            this.decryptOutputBox.ReadOnly = true;
            this.decryptOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptOutputBox.Size = new System.Drawing.Size(513, 215);
            this.decryptOutputBox.TabIndex = 0;
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.yesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.yesBtn.Location = new System.Drawing.Point(129, 250);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(111, 41);
            this.yesBtn.TabIndex = 6;
            this.yesBtn.Text = "Correct";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nextBtn.Location = new System.Drawing.Point(309, 250);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(111, 41);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(537, 319);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.decryptOutputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Output";
            this.Text = "Result";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Output_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox decryptOutputBox;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button nextBtn;
    }
}