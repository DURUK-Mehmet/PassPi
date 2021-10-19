
namespace PassPi
{
    partial class HomePage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPass = new System.Windows.Forms.Button();
            this.BtnDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPass
            // 
            this.BtnPass.Location = new System.Drawing.Point(25, 50);
            this.BtnPass.Name = "BtnPass";
            this.BtnPass.Size = new System.Drawing.Size(200, 100);
            this.BtnPass.TabIndex = 1;
            this.BtnPass.Text = "Passwording";
            this.BtnPass.UseVisualStyleBackColor = true;
            this.BtnPass.Click += new System.EventHandler(this.BtnPass_Click);
            // 
            // BtnDec
            // 
            this.BtnDec.Location = new System.Drawing.Point(260, 50);
            this.BtnDec.Name = "BtnDec";
            this.BtnDec.Size = new System.Drawing.Size(200, 100);
            this.BtnDec.TabIndex = 2;
            this.BtnDec.Text = "Decoder";
            this.BtnDec.UseVisualStyleBackColor = true;
            this.BtnDec.Click += new System.EventHandler(this.BtnDec_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.BtnDec);
            this.Controls.Add(this.BtnPass);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassPi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPass;
        private System.Windows.Forms.Button BtnDec;
    }
}

