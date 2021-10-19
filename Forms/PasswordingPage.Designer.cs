
namespace PassPi.Forms
{
    partial class PasswordingPage
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
            this.TxtIn = new System.Windows.Forms.TextBox();
            this.BtnPass = new System.Windows.Forms.Button();
            this.TxtGive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtIn
            // 
            this.TxtIn.Location = new System.Drawing.Point(0, 0);
            this.TxtIn.Multiline = true;
            this.TxtIn.Name = "TxtIn";
            this.TxtIn.Size = new System.Drawing.Size(733, 421);
            this.TxtIn.TabIndex = 0;
            // 
            // BtnPass
            // 
            this.BtnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPass.Location = new System.Drawing.Point(270, 425);
            this.BtnPass.Name = "BtnPass";
            this.BtnPass.Size = new System.Drawing.Size(100, 25);
            this.BtnPass.TabIndex = 1;
            this.BtnPass.Text = "Şifrele";
            this.BtnPass.UseVisualStyleBackColor = true;
            this.BtnPass.Click += new System.EventHandler(this.BtnPass_Click);
            // 
            // TxtGive
            // 
            this.TxtGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGive.Location = new System.Drawing.Point(400, 425);
            this.TxtGive.Name = "TxtGive";
            this.TxtGive.Size = new System.Drawing.Size(100, 25);
            this.TxtGive.TabIndex = 5;
            this.TxtGive.Text = "Dosyaya Yaz";
            this.TxtGive.UseVisualStyleBackColor = true;
            this.TxtGive.Click += new System.EventHandler(this.TxtGive_Click);
            // 
            // PasswordingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.TxtGive);
            this.Controls.Add(this.BtnPass);
            this.Controls.Add(this.TxtIn);
            this.MinimizeBox = false;
            this.Name = "PasswordingPage";
            this.Text = "Passwording Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIn;
        private System.Windows.Forms.Button BtnPass;
        private System.Windows.Forms.Button TxtGive;
    }
}