namespace C____CokIslevliUygulama
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.mathList = new System.Windows.Forms.ListBox();
            this.math3 = new System.Windows.Forms.TextBox();
            this.math2 = new System.Windows.Forms.TextBox();
            this.math1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uretilenList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.uretilenTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.yayineviBox = new System.Windows.Forms.ComboBox();
            this.kategoriBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.yazarAd = new System.Windows.Forms.TextBox();
            this.kitapKod = new System.Windows.Forms.TextBox();
            this.kitapAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.sifregosterList = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.yontemBox = new System.Windows.Forms.ComboBox();
            this.sifreliTxtBox = new System.Windows.Forms.TextBox();
            this.anahtarTxtBox = new System.Windows.Forms.TextBox();
            this.metinTxtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.mathList);
            this.tabPage1.Controls.Add(this.math3);
            this.tabPage1.Controls.Add(this.math2);
            this.tabPage1.Controls.Add(this.math1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. Soru";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mathList
            // 
            this.mathList.FormattingEnabled = true;
            this.mathList.Location = new System.Drawing.Point(291, 73);
            this.mathList.Name = "mathList";
            this.mathList.Size = new System.Drawing.Size(207, 121);
            this.mathList.TabIndex = 6;
            // 
            // math3
            // 
            this.math3.Location = new System.Drawing.Point(112, 160);
            this.math3.Multiline = true;
            this.math3.Name = "math3";
            this.math3.Size = new System.Drawing.Size(123, 25);
            this.math3.TabIndex = 5;
            // 
            // math2
            // 
            this.math2.Location = new System.Drawing.Point(111, 117);
            this.math2.Multiline = true;
            this.math2.Name = "math2";
            this.math2.Size = new System.Drawing.Size(123, 25);
            this.math2.TabIndex = 4;
            // 
            // math1
            // 
            this.math1.Location = new System.Drawing.Point(111, 73);
            this.math1.Multiline = true;
            this.math1.Name = "math1";
            this.math1.Size = new System.Drawing.Size(123, 25);
            this.math1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uretilenList);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.uretilenTxt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. Soru";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uretilenList
            // 
            this.uretilenList.FormattingEnabled = true;
            this.uretilenList.Location = new System.Drawing.Point(283, 80);
            this.uretilenList.Name = "uretilenList";
            this.uretilenList.Size = new System.Drawing.Size(189, 121);
            this.uretilenList.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uretilenTxt
            // 
            this.uretilenTxt.Location = new System.Drawing.Point(140, 80);
            this.uretilenTxt.Multiline = true;
            this.uretilenTxt.Name = "uretilenTxt";
            this.uretilenTxt.Size = new System.Drawing.Size(117, 36);
            this.uretilenTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Üretilen Sayı";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.yayineviBox);
            this.tabPage3.Controls.Add(this.kategoriBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.yazarAd);
            this.tabPage3.Controls.Add(this.kitapKod);
            this.tabPage3.Controls.Add(this.kitapAd);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3. Soru";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 198);
            this.dataGridView1.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(525, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 31);
            this.button5.TabIndex = 30;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 31);
            this.button4.TabIndex = 29;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 31);
            this.button3.TabIndex = 28;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(448, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // yayineviBox
            // 
            this.yayineviBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yayineviBox.FormattingEnabled = true;
            this.yayineviBox.Location = new System.Drawing.Point(448, 99);
            this.yayineviBox.Name = "yayineviBox";
            this.yayineviBox.Size = new System.Drawing.Size(121, 24);
            this.yayineviBox.TabIndex = 26;
            // 
            // kategoriBox
            // 
            this.kategoriBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriBox.FormattingEnabled = true;
            this.kategoriBox.Location = new System.Drawing.Point(448, 64);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(121, 24);
            this.kategoriBox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(360, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Basım Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(360, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Yayınevi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(360, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Kategori";
            // 
            // yazarAd
            // 
            this.yazarAd.Location = new System.Drawing.Point(199, 133);
            this.yazarAd.Multiline = true;
            this.yazarAd.Name = "yazarAd";
            this.yazarAd.Size = new System.Drawing.Size(122, 24);
            this.yazarAd.TabIndex = 21;
            // 
            // kitapKod
            // 
            this.kitapKod.Location = new System.Drawing.Point(199, 97);
            this.kitapKod.Multiline = true;
            this.kitapKod.Name = "kitapKod";
            this.kitapKod.Size = new System.Drawing.Size(122, 24);
            this.kitapKod.TabIndex = 20;
            // 
            // kitapAd
            // 
            this.kitapAd.Location = new System.Drawing.Point(199, 59);
            this.kitapAd.Multiline = true;
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.Size = new System.Drawing.Size(122, 24);
            this.kitapAd.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(121, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Yazar Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(121, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kitap Kodu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(121, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kitap Adı";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.sifregosterList);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.yontemBox);
            this.tabPage4.Controls.Add(this.sifreliTxtBox);
            this.tabPage4.Controls.Add(this.anahtarTxtBox);
            this.tabPage4.Controls.Add(this.metinTxtBox);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4. Soru";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // sifregosterList
            // 
            this.sifregosterList.FormattingEnabled = true;
            this.sifregosterList.Location = new System.Drawing.Point(525, 101);
            this.sifregosterList.Name = "sifregosterList";
            this.sifregosterList.Size = new System.Drawing.Size(166, 160);
            this.sifregosterList.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(389, 232);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 32);
            this.button7.TabIndex = 18;
            this.button7.Text = "Deşifreleme";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(298, 232);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 32);
            this.button6.TabIndex = 17;
            this.button6.Text = "Şifreleme";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // yontemBox
            // 
            this.yontemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yontemBox.FormattingEnabled = true;
            this.yontemBox.Location = new System.Drawing.Point(372, 102);
            this.yontemBox.Name = "yontemBox";
            this.yontemBox.Size = new System.Drawing.Size(120, 21);
            this.yontemBox.TabIndex = 16;
            // 
            // sifreliTxtBox
            // 
            this.sifreliTxtBox.Location = new System.Drawing.Point(210, 189);
            this.sifreliTxtBox.Multiline = true;
            this.sifreliTxtBox.Name = "sifreliTxtBox";
            this.sifreliTxtBox.Size = new System.Drawing.Size(135, 27);
            this.sifreliTxtBox.TabIndex = 15;
            // 
            // anahtarTxtBox
            // 
            this.anahtarTxtBox.Location = new System.Drawing.Point(210, 145);
            this.anahtarTxtBox.Multiline = true;
            this.anahtarTxtBox.Name = "anahtarTxtBox";
            this.anahtarTxtBox.Size = new System.Drawing.Size(135, 27);
            this.anahtarTxtBox.TabIndex = 14;
            // 
            // metinTxtBox
            // 
            this.metinTxtBox.Location = new System.Drawing.Point(210, 101);
            this.metinTxtBox.Multiline = true;
            this.metinTxtBox.Name = "metinTxtBox";
            this.metinTxtBox.Size = new System.Drawing.Size(135, 27);
            this.metinTxtBox.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(91, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Şifrelenmiş Metin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(91, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Anahtar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(91, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Şifrelenecek Metin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox mathList;
        private System.Windows.Forms.TextBox math3;
        private System.Windows.Forms.TextBox math2;
        private System.Windows.Forms.TextBox math1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox uretilenList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox uretilenTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox yayineviBox;
        private System.Windows.Forms.ComboBox kategoriBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox yazarAd;
        private System.Windows.Forms.TextBox kitapKod;
        private System.Windows.Forms.TextBox kitapAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox sifregosterList;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox yontemBox;
        private System.Windows.Forms.TextBox sifreliTxtBox;
        private System.Windows.Forms.TextBox anahtarTxtBox;
        private System.Windows.Forms.TextBox metinTxtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

