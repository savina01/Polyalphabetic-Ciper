namespace Polualphabetic
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPlaintText = new System.Windows.Forms.Label();
            this.textBoxPlainText = new System.Windows.Forms.TextBox();
            this.labelCiper = new System.Windows.Forms.Label();
            this.textBoxCiper = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.labelSymbols = new System.Windows.Forms.Label();
            this.labelAllSymbols = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlaintText
            // 
            this.labelPlaintText.AutoSize = true;
            this.labelPlaintText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlaintText.Location = new System.Drawing.Point(32, 69);
            this.labelPlaintText.Name = "labelPlaintText";
            this.labelPlaintText.Size = new System.Drawing.Size(85, 23);
            this.labelPlaintText.TabIndex = 0;
            this.labelPlaintText.Text = "Plain text:";
            // 
            // textBoxPlainText
            // 
            this.textBoxPlainText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPlainText.Location = new System.Drawing.Point(32, 95);
            this.textBoxPlainText.Multiline = true;
            this.textBoxPlainText.Name = "textBoxPlainText";
            this.textBoxPlainText.Size = new System.Drawing.Size(374, 90);
            this.textBoxPlainText.TabIndex = 1;
            // 
            // labelCiper
            // 
            this.labelCiper.AutoSize = true;
            this.labelCiper.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCiper.Location = new System.Drawing.Point(32, 275);
            this.labelCiper.Name = "labelCiper";
            this.labelCiper.Size = new System.Drawing.Size(54, 23);
            this.labelCiper.TabIndex = 2;
            this.labelCiper.Text = "Ciper:";
            // 
            // textBoxCiper
            // 
            this.textBoxCiper.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCiper.Location = new System.Drawing.Point(32, 301);
            this.textBoxCiper.Multiline = true;
            this.textBoxCiper.Name = "textBoxCiper";
            this.textBoxCiper.Size = new System.Drawing.Size(374, 90);
            this.textBoxCiper.TabIndex = 3;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEncrypt.Location = new System.Drawing.Point(238, 415);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(115, 30);
            this.buttonEncrypt.TabIndex = 4;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKey.Location = new System.Drawing.Point(32, 198);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(41, 23);
            this.labelKey.TabIndex = 5;
            this.labelKey.Text = "Key:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKey.Location = new System.Drawing.Point(32, 224);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(374, 39);
            this.textBoxKey.TabIndex = 6;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDecrypt.Location = new System.Drawing.Point(85, 415);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(115, 30);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // labelSymbols
            // 
            this.labelSymbols.AutoSize = true;
            this.labelSymbols.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSymbols.Location = new System.Drawing.Point(32, 12);
            this.labelSymbols.Name = "labelSymbols";
            this.labelSymbols.Size = new System.Drawing.Size(140, 23);
            this.labelSymbols.TabIndex = 8;
            this.labelSymbols.Text = "Allowed symbols:";
            // 
            // labelAllSymbols
            // 
            this.labelAllSymbols.AutoSize = true;
            this.labelAllSymbols.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelAllSymbols.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAllSymbols.Location = new System.Drawing.Point(35, 37);
            this.labelAllSymbols.Name = "labelAllSymbols";
            this.labelAllSymbols.Size = new System.Drawing.Size(370, 23);
            this.labelAllSymbols.TabIndex = 9;
            this.labelAllSymbols.Text = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 464);
            this.Controls.Add(this.labelAllSymbols);
            this.Controls.Add(this.labelSymbols);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxCiper);
            this.Controls.Add(this.labelCiper);
            this.Controls.Add(this.textBoxPlainText);
            this.Controls.Add(this.labelPlaintText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polyalphabetic Ciper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPlaintText;
        private TextBox textBoxPlainText;
        private Label labelCiper;
        private TextBox textBoxCiper;
        private Button buttonEncrypt;
        private Label labelKey;
        private TextBox textBoxKey;
        private Button buttonDecrypt;
        private Label labelSymbols;
        private Label labelAllSymbols;
    }
}