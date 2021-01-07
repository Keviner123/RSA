namespace RSASender
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
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxReceiverPublicKey = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCipherbytes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Receiver Public Key";
            // 
            // textBoxReceiverPublicKey
            // 
            this.textBoxReceiverPublicKey.Location = new System.Drawing.Point(118, 12);
            this.textBoxReceiverPublicKey.Name = "textBoxReceiverPublicKey";
            this.textBoxReceiverPublicKey.Size = new System.Drawing.Size(304, 20);
            this.textBoxReceiverPublicKey.TabIndex = 17;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(118, 64);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(304, 23);
            this.buttonEncrypt.TabIndex = 21;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Plaintext";
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Location = new System.Drawing.Point(118, 38);
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.Size = new System.Drawing.Size(304, 20);
            this.textBoxPlaintext.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cipherbytes:";
            // 
            // textBoxCipherbytes
            // 
            this.textBoxCipherbytes.Location = new System.Drawing.Point(118, 93);
            this.textBoxCipherbytes.Name = "textBoxCipherbytes";
            this.textBoxCipherbytes.Size = new System.Drawing.Size(304, 20);
            this.textBoxCipherbytes.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCipherbytes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlaintext);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxReceiverPublicKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "RSASender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxReceiverPublicKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCipherbytes;
    }
}

