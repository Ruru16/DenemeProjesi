namespace Proje2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(271, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(877, 445);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(272, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 42);
            this.button7.TabIndex = 1;
            this.button7.Text = "EKLE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(438, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 42);
            this.button8.TabIndex = 1;
            this.button8.Text = "GÜNCELLE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(594, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 42);
            this.button9.TabIndex = 1;
            this.button9.Text = "SİL";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(36, 441);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 42);
            this.button6.TabIndex = 2;
            this.button6.Text = "HESAP KART ALT GRUP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(36, 382);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 42);
            this.button5.TabIndex = 3;
            this.button5.Text = "HESAP KART GRUP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "HESAP KART TÜR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "HESAP KART TİP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "KULLANICI LİSTESİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "HESAP KART LİSTESİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 573);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "ANASAYFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

