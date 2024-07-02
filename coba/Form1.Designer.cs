namespace coba
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
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_nis = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_tgllahir = new System.Windows.Forms.DateTimePicker();
            this.lbl_informasi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(211, 67);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(100, 22);
            this.tb_nama.TabIndex = 0;
            // 
            // tb_nis
            // 
            this.tb_nis.Location = new System.Drawing.Point(211, 109);
            this.tb_nis.Name = "tb_nis";
            this.tb_nis.Size = new System.Drawing.Size(100, 22);
            this.tb_nis.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(225, 182);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(86, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tgl Lahir";
            // 
            // dtp_tgllahir
            // 
            this.dtp_tgllahir.Location = new System.Drawing.Point(211, 140);
            this.dtp_tgllahir.Name = "dtp_tgllahir";
            this.dtp_tgllahir.Size = new System.Drawing.Size(200, 22);
            this.dtp_tgllahir.TabIndex = 6;
            // 
            // lbl_informasi
            // 
            this.lbl_informasi.AutoSize = true;
            this.lbl_informasi.Location = new System.Drawing.Point(208, 231);
            this.lbl_informasi.Name = "lbl_informasi";
            this.lbl_informasi.Size = new System.Drawing.Size(44, 16);
            this.lbl_informasi.TabIndex = 7;
            this.lbl_informasi.Text = "label4";
            this.lbl_informasi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 342);
            this.Controls.Add(this.lbl_informasi);
            this.Controls.Add(this.dtp_tgllahir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_nis);
            this.Controls.Add(this.tb_nama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_nis;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_tgllahir;
        private System.Windows.Forms.Label lbl_informasi;
    }
}

