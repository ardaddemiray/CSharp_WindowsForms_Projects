namespace C_HesapMakinesi
{
    partial class Form1
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
            this.clear_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.virgul_btn = new System.Windows.Forms.Button();
            this.esittirButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.artiButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.eksiButton = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.carpButton = new System.Windows.Forms.Button();
            this.kareButton = new System.Windows.Forms.Button();
            this.karekokButton = new System.Windows.Forms.Button();
            this.bolmeButton = new System.Windows.Forms.Button();
            this.backspace_btn = new System.Windows.Forms.Button();
            this.hesapBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clear_btn.Font = new System.Drawing.Font("Arial", 15.25F);
            this.clear_btn.Location = new System.Drawing.Point(50, 405);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 55);
            this.clear_btn.TabIndex = 0;
            this.clear_btn.Text = "C";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button2.Location = new System.Drawing.Point(131, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // virgul_btn
            // 
            this.virgul_btn.Font = new System.Drawing.Font("Arial", 15.25F);
            this.virgul_btn.Location = new System.Drawing.Point(212, 405);
            this.virgul_btn.Name = "virgul_btn";
            this.virgul_btn.Size = new System.Drawing.Size(75, 55);
            this.virgul_btn.TabIndex = 2;
            this.virgul_btn.Text = ",";
            this.virgul_btn.UseVisualStyleBackColor = true;
            this.virgul_btn.Click += new System.EventHandler(this.virgul_btn_Click);
            // 
            // esittirButton
            // 
            this.esittirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.esittirButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.esittirButton.Location = new System.Drawing.Point(293, 405);
            this.esittirButton.Name = "esittirButton";
            this.esittirButton.Size = new System.Drawing.Size(75, 55);
            this.esittirButton.TabIndex = 3;
            this.esittirButton.Text = "=";
            this.esittirButton.UseVisualStyleBackColor = false;
            this.esittirButton.Click += new System.EventHandler(this.esittirButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button5.Location = new System.Drawing.Point(50, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button6.Location = new System.Drawing.Point(131, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 55);
            this.button6.TabIndex = 5;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button7.Location = new System.Drawing.Point(212, 344);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 55);
            this.button7.TabIndex = 6;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // artiButton
            // 
            this.artiButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.artiButton.Location = new System.Drawing.Point(293, 344);
            this.artiButton.Name = "artiButton";
            this.artiButton.Size = new System.Drawing.Size(75, 55);
            this.artiButton.TabIndex = 7;
            this.artiButton.Text = "+";
            this.artiButton.UseVisualStyleBackColor = true;
            this.artiButton.Click += new System.EventHandler(this.artiButton_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button9.Location = new System.Drawing.Point(50, 283);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 55);
            this.button9.TabIndex = 8;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button10.Location = new System.Drawing.Point(131, 283);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 55);
            this.button10.TabIndex = 9;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button11.Location = new System.Drawing.Point(212, 283);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 55);
            this.button11.TabIndex = 10;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // eksiButton
            // 
            this.eksiButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.eksiButton.Location = new System.Drawing.Point(293, 283);
            this.eksiButton.Name = "eksiButton";
            this.eksiButton.Size = new System.Drawing.Size(75, 55);
            this.eksiButton.TabIndex = 11;
            this.eksiButton.Text = "-";
            this.eksiButton.UseVisualStyleBackColor = true;
            this.eksiButton.Click += new System.EventHandler(this.eksiButton_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button13.Location = new System.Drawing.Point(50, 222);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 55);
            this.button13.TabIndex = 12;
            this.button13.Text = "7";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button14.Location = new System.Drawing.Point(131, 222);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 55);
            this.button14.TabIndex = 13;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button15.Location = new System.Drawing.Point(212, 222);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 55);
            this.button15.TabIndex = 14;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // carpButton
            // 
            this.carpButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.carpButton.Location = new System.Drawing.Point(293, 222);
            this.carpButton.Name = "carpButton";
            this.carpButton.Size = new System.Drawing.Size(75, 55);
            this.carpButton.TabIndex = 15;
            this.carpButton.Text = "x";
            this.carpButton.UseVisualStyleBackColor = true;
            this.carpButton.Click += new System.EventHandler(this.carpButton_Click);
            // 
            // kareButton
            // 
            this.kareButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.kareButton.Location = new System.Drawing.Point(50, 161);
            this.kareButton.Name = "kareButton";
            this.kareButton.Size = new System.Drawing.Size(75, 55);
            this.kareButton.TabIndex = 16;
            this.kareButton.Text = "x²";
            this.kareButton.UseVisualStyleBackColor = true;
            this.kareButton.Click += new System.EventHandler(this.kareButton_Click);
            // 
            // karekokButton
            // 
            this.karekokButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.karekokButton.Location = new System.Drawing.Point(131, 161);
            this.karekokButton.Name = "karekokButton";
            this.karekokButton.Size = new System.Drawing.Size(75, 55);
            this.karekokButton.TabIndex = 17;
            this.karekokButton.Text = "√¯";
            this.karekokButton.UseVisualStyleBackColor = true;
            this.karekokButton.Click += new System.EventHandler(this.karekokButton_Click);
            // 
            // bolmeButton
            // 
            this.bolmeButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.bolmeButton.Location = new System.Drawing.Point(212, 161);
            this.bolmeButton.Name = "bolmeButton";
            this.bolmeButton.Size = new System.Drawing.Size(75, 55);
            this.bolmeButton.TabIndex = 18;
            this.bolmeButton.Text = "÷";
            this.bolmeButton.UseVisualStyleBackColor = true;
            this.bolmeButton.Click += new System.EventHandler(this.bolmeButton_Click);
            // 
            // backspace_btn
            // 
            this.backspace_btn.Font = new System.Drawing.Font("Arial", 15.25F);
            this.backspace_btn.Location = new System.Drawing.Point(293, 161);
            this.backspace_btn.Name = "backspace_btn";
            this.backspace_btn.Size = new System.Drawing.Size(75, 55);
            this.backspace_btn.TabIndex = 19;
            this.backspace_btn.Text = "←";
            this.backspace_btn.UseVisualStyleBackColor = true;
            this.backspace_btn.Click += new System.EventHandler(this.backspace_btn_Click);
            // 
            // hesapBox
            // 
            this.hesapBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapBox.Location = new System.Drawing.Point(50, 67);
            this.hesapBox.Multiline = true;
            this.hesapBox.Name = "hesapBox";
            this.hesapBox.Size = new System.Drawing.Size(318, 77);
            this.hesapBox.TabIndex = 20;
            this.hesapBox.Text = "0";
            this.hesapBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hesapBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(419, 514);
            this.Controls.Add(this.hesapBox);
            this.Controls.Add(this.backspace_btn);
            this.Controls.Add(this.bolmeButton);
            this.Controls.Add(this.karekokButton);
            this.Controls.Add(this.kareButton);
            this.Controls.Add(this.carpButton);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.eksiButton);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.artiButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.esittirButton);
            this.Controls.Add(this.virgul_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clear_btn);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button virgul_btn;
        private System.Windows.Forms.Button esittirButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button artiButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button eksiButton;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button carpButton;
        private System.Windows.Forms.Button kareButton;
        private System.Windows.Forms.Button karekokButton;
        private System.Windows.Forms.Button bolmeButton;
        private System.Windows.Forms.Button backspace_btn;
        private System.Windows.Forms.TextBox hesapBox;
    }
}

