
namespace PassPi.Forms
{
    partial class DecoderPage
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
            this.BtnDec = new System.Windows.Forms.Button();
            this.TxtIn = new System.Windows.Forms.TextBox();
            this.TxtTake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDec
            // 
            this.BtnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDec.Location = new System.Drawing.Point(410, 430);
            this.BtnDec.Name = "BtnDec";
            this.BtnDec.Size = new System.Drawing.Size(100, 25);
            this.BtnDec.TabIndex = 3;
            this.BtnDec.Text = "Şifreyi Çöz";
            this.BtnDec.UseVisualStyleBackColor = true;
            this.BtnDec.Click += new System.EventHandler(this.BtnDec_Click);
            // 
            // TxtIn
            // 
            this.TxtIn.Location = new System.Drawing.Point(0, 0);
            this.TxtIn.Multiline = true;
            this.TxtIn.Name = "TxtIn";
            this.TxtIn.Size = new System.Drawing.Size(734, 425);
            this.TxtIn.TabIndex = 2;
            // 
            // TxtTake
            // 
            this.TxtTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTake.Location = new System.Drawing.Point(260, 430);
            this.TxtTake.Name = "TxtTake";
            this.TxtTake.Size = new System.Drawing.Size(100, 25);
            this.TxtTake.TabIndex = 4;
            this.TxtTake.Text = "Dosya Seç";
            this.TxtTake.UseVisualStyleBackColor = true;
            this.TxtTake.Click += new System.EventHandler(this.TxtTake_Click);
            // 
            // DecoderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.TxtTake);
            this.Controls.Add(this.BtnDec);
            this.Controls.Add(this.TxtIn);
            this.MaximizeBox = false;
            this.Name = "DecoderPage";
            this.Text = "Decoder Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDec;
        private System.Windows.Forms.TextBox TxtIn;
        private System.Windows.Forms.Button TxtTake;
    }
}