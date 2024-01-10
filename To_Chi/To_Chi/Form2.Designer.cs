
namespace To_Chi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkAnHien = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu:";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(61, 87);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(243, 22);
            this.txtMK.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Gợi ý: Mật khẩu là ngày sinh của bạn gồm 8 số)";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(155, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 41);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkAnHien
            // 
            this.chkAnHien.AutoSize = true;
            this.chkAnHien.Location = new System.Drawing.Point(316, 87);
            this.chkAnHien.Name = "chkAnHien";
            this.chkAnHien.Size = new System.Drawing.Size(59, 21);
            this.chkAnHien.TabIndex = 3;
            this.chkAnHien.Text = "Hiện";
            this.chkAnHien.UseVisualStyleBackColor = true;
            this.chkAnHien.CheckedChanged += new System.EventHandler(this.chkAnHien_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 232);
            this.Controls.Add(this.chkAnHien);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkAnHien;
    }
}