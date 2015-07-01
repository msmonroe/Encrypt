namespace Encrypt
{
    partial class FrmEncrypt
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
            this.lblENCRYPT = new System.Windows.Forms.Label();
            this.txtBxENCRYPT = new System.Windows.Forms.TextBox();
            this.btnENCRYPT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblENCRYPT
            // 
            this.lblENCRYPT.AutoSize = true;
            this.lblENCRYPT.Location = new System.Drawing.Point(13, 13);
            this.lblENCRYPT.Name = "lblENCRYPT";
            this.lblENCRYPT.Size = new System.Drawing.Size(0, 13);
            this.lblENCRYPT.TabIndex = 0;
            // 
            // txtBxENCRYPT
            // 
            this.txtBxENCRYPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxENCRYPT.Location = new System.Drawing.Point(12, 29);
            this.txtBxENCRYPT.Name = "txtBxENCRYPT";
            this.txtBxENCRYPT.Size = new System.Drawing.Size(259, 24);
            this.txtBxENCRYPT.TabIndex = 3;
            // 
            // btnENCRYPT
            // 
            this.btnENCRYPT.Location = new System.Drawing.Point(12, 60);
            this.btnENCRYPT.Name = "btnENCRYPT";
            this.btnENCRYPT.Size = new System.Drawing.Size(259, 23);
            this.btnENCRYPT.TabIndex = 4;
            this.btnENCRYPT.Text = "ENCRYPT";
            this.btnENCRYPT.UseVisualStyleBackColor = true;
            this.btnENCRYPT.Click += new System.EventHandler(this.btnENCRYPT_Click);
            // 
            // FrmEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 92);
            this.Controls.Add(this.btnENCRYPT);
            this.Controls.Add(this.txtBxENCRYPT);
            this.Controls.Add(this.lblENCRYPT);
            this.Name = "FrmEncrypt";
            this.Text = "Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblENCRYPT;
        private System.Windows.Forms.TextBox txtBxENCRYPT;
        private System.Windows.Forms.Button btnENCRYPT;
    }
}

