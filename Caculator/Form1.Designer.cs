namespace Caculator
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
            this.Exit = new System.Windows.Forms.PictureBox();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.am = new System.Windows.Forms.Button();
            this.khong = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.bang = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.cong = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnmu = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.btnphantram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Image = global::Caculator.Properties.Resources.delete_icon;
            this.Exit.Location = new System.Drawing.Point(357, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(57, 58);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // KetQua
            // 
            this.KetQua.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.KetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KetQua.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.KetQua.Location = new System.Drawing.Point(0, 52);
            this.KetQua.Multiline = true;
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(414, 74);
            this.KetQua.TabIndex = 2;
            this.KetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.KetQua.TextChanged += new System.EventHandler(this.KetQua_TextChanged);
            // 
            // am
            // 
            this.am.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.am.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.am.Location = new System.Drawing.Point(13, 536);
            this.am.Name = "am";
            this.am.Size = new System.Drawing.Size(75, 49);
            this.am.TabIndex = 5;
            this.am.Text = "+/-";
            this.am.UseVisualStyleBackColor = true;
            this.am.Click += new System.EventHandler(this.am_Click);
            // 
            // khong
            // 
            this.khong.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.khong.Location = new System.Drawing.Point(114, 536);
            this.khong.Name = "khong";
            this.khong.Size = new System.Drawing.Size(75, 49);
            this.khong.TabIndex = 6;
            this.khong.Text = "0";
            this.khong.UseVisualStyleBackColor = true;
            this.khong.Click += new System.EventHandler(this.khong_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn.Location = new System.Drawing.Point(218, 536);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 49);
            this.btn.TabIndex = 7;
            this.btn.Text = ".";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // bang
            // 
            this.bang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bang.Location = new System.Drawing.Point(320, 536);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(75, 49);
            this.bang.TabIndex = 10;
            this.bang.Text = "=";
            this.bang.UseVisualStyleBackColor = true;
            this.bang.Click += new System.EventHandler(this.bang_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Location = new System.Drawing.Point(218, 328);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 49);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // cong
            // 
            this.cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cong.Location = new System.Drawing.Point(320, 430);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(75, 49);
            this.cong.TabIndex = 12;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Location = new System.Drawing.Point(218, 430);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 49);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Location = new System.Drawing.Point(114, 430);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 49);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Location = new System.Drawing.Point(13, 328);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 49);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Location = new System.Drawing.Point(114, 328);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 49);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Location = new System.Drawing.Point(13, 430);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 49);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tru
            // 
            this.tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tru.Location = new System.Drawing.Point(320, 328);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(75, 49);
            this.tru.TabIndex = 19;
            this.tru.Text = "-";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.tru_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Location = new System.Drawing.Point(218, 228);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 49);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // nhan
            // 
            this.nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nhan.Location = new System.Drawing.Point(320, 228);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(75, 49);
            this.nhan.TabIndex = 21;
            this.nhan.Text = "x";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.nhan_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Location = new System.Drawing.Point(13, 228);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 49);
            this.btn7.TabIndex = 22;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Location = new System.Drawing.Point(114, 228);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 49);
            this.btn8.TabIndex = 23;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnmu
            // 
            this.btnmu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmu.Location = new System.Drawing.Point(114, 132);
            this.btnmu.Name = "btnmu";
            this.btnmu.Size = new System.Drawing.Size(75, 49);
            this.btnmu.TabIndex = 24;
            this.btnmu.Text = "^";
            this.btnmu.UseVisualStyleBackColor = true;
            this.btnmu.Click += new System.EventHandler(this.btnmu_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xoa.Location = new System.Drawing.Point(218, 132);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 49);
            this.xoa.TabIndex = 25;
            this.xoa.Text = "C";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // chia
            // 
            this.chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chia.Location = new System.Drawing.Point(320, 132);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(75, 49);
            this.chia.TabIndex = 26;
            this.chia.Text = "/";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.chia_Click);
            // 
            // btnphantram
            // 
            this.btnphantram.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphantram.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnphantram.Location = new System.Drawing.Point(13, 132);
            this.btnphantram.Name = "btnphantram";
            this.btnphantram.Size = new System.Drawing.Size(75, 49);
            this.btnphantram.TabIndex = 27;
            this.btnphantram.Text = "%";
            this.btnphantram.UseVisualStyleBackColor = true;
            this.btnphantram.Click += new System.EventHandler(this.btnphantram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(409, 597);
            this.ControlBox = false;
            this.Controls.Add(this.btnphantram);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.btnmu);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.khong);
            this.Controls.Add(this.am);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.Exit);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Caculator";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.TextBox KetQua;
        private System.Windows.Forms.Button am;
        private System.Windows.Forms.Button khong;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button bang;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnmu;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.Button btnphantram;
    }
}

