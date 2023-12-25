namespace DongHo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhut = new System.Windows.Forms.TextBox();
            this.txtGiay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChay = new System.Windows.Forms.Button();
            this.btnTamDung = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "(Phút)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Giây)";
            // 
            // txtPhut
            // 
            this.txtPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhut.Location = new System.Drawing.Point(219, 130);
            this.txtPhut.Multiline = true;
            this.txtPhut.Name = "txtPhut";
            this.txtPhut.Size = new System.Drawing.Size(114, 44);
            this.txtPhut.TabIndex = 2;
            this.txtPhut.TextChanged += new System.EventHandler(this.txtPhut_TextChanged);
            this.txtPhut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhut_KeyPress);
            // 
            // txtGiay
            // 
            this.txtGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiay.Location = new System.Drawing.Point(437, 130);
            this.txtGiay.Multiline = true;
            this.txtGiay.Name = "txtGiay";
            this.txtGiay.Size = new System.Drawing.Size(114, 44);
            this.txtGiay.TabIndex = 3;
            this.txtGiay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiay_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // btnChay
            // 
            this.btnChay.Location = new System.Drawing.Point(193, 227);
            this.btnChay.Name = "btnChay";
            this.btnChay.Size = new System.Drawing.Size(97, 33);
            this.btnChay.TabIndex = 5;
            this.btnChay.Text = "Chạy";
            this.btnChay.UseVisualStyleBackColor = true;
            this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.Location = new System.Drawing.Point(333, 227);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(97, 33);
            this.btnTamDung.TabIndex = 6;
            this.btnTamDung.Text = "Tạm Dừng";
            this.btnTamDung.UseVisualStyleBackColor = true;
            this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(474, 227);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(97, 33);
            this.btnKetThuc.TabIndex = 7;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 354);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.btnChay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGiay);
            this.Controls.Add(this.txtPhut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chương trình đồng hồ đếm ngược";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhut;
        private System.Windows.Forms.TextBox txtGiay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChay;
        private System.Windows.Forms.Button btnTamDung;
        private System.Windows.Forms.Button btnKetThuc;
    }
}

