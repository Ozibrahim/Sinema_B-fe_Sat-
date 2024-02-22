namespace Sinema_Büfe_Satiş
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TxtMısır = new TextBox();
            TxtSu = new TextBox();
            TxtÇay = new TextBox();
            TxtBilet = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            labelKasaTutar = new Label();
            label12 = new Label();
            button1 = new Button();
            labelToplam = new Label();
            label9 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 0;
            label1.Text = "Mısır";
            // 
            // TxtMısır
            // 
            TxtMısır.Location = new Point(98, 29);
            TxtMısır.Name = "TxtMısır";
            TxtMısır.Size = new Size(100, 26);
            TxtMısır.TabIndex = 1;
            // 
            // TxtSu
            // 
            TxtSu.Location = new Point(98, 61);
            TxtSu.Name = "TxtSu";
            TxtSu.Size = new Size(100, 26);
            TxtSu.TabIndex = 2;
            // 
            // TxtÇay
            // 
            TxtÇay.Location = new Point(98, 93);
            TxtÇay.Name = "TxtÇay";
            TxtÇay.Size = new Size(100, 26);
            TxtÇay.TabIndex = 3;
            // 
            // TxtBilet
            // 
            TxtBilet.Location = new Point(98, 125);
            TxtBilet.Name = "TxtBilet";
            TxtBilet.Size = new Size(100, 26);
            TxtBilet.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 68);
            label2.Name = "label2";
            label2.Size = new Size(31, 19);
            label2.TabIndex = 6;
            label2.Text = "Su";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 100);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 7;
            label3.Text = "Çay";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 8;
            label4.Text = "Bilet";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtBilet);
            groupBox1.Controls.Add(TxtÇay);
            groupBox1.Controls.Add(TxtSu);
            groupBox1.Controls.Add(TxtMısır);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktar";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Olive;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(322, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 188);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 128);
            label5.Name = "label5";
            label5.Size = new Size(141, 19);
            label5.TabIndex = 8;
            label5.Text = "Bilet: 100TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 100);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 7;
            label6.Text = "Çay: 15TL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 68);
            label7.Name = "label7";
            label7.Size = new Size(86, 19);
            label7.TabIndex = 6;
            label7.Text = "Su: 5TL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 36);
            label8.Name = "label8";
            label8.Size = new Size(130, 19);
            label8.TabIndex = 0;
            label8.Text = "Mısır: 50TL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 255, 255);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(labelKasaTutar);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(labelToplam);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(640, 137);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(294, 188);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // labelKasaTutar
            // 
            labelKasaTutar.AutoSize = true;
            labelKasaTutar.Location = new Point(168, 166);
            labelKasaTutar.Name = "labelKasaTutar";
            labelKasaTutar.Size = new Size(64, 19);
            labelKasaTutar.TabIndex = 12;
            labelKasaTutar.Text = "150TL";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(87, 166);
            label12.Name = "label12";
            label12.Size = new Size(75, 19);
            label12.TabIndex = 11;
            label12.Text = "Kasa: ";
            // 
            // button1
            // 
            button1.Location = new Point(87, 54);
            button1.Name = "button1";
            button1.Size = new Size(123, 45);
            button1.TabIndex = 10;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelToplam
            // 
            labelToplam.AutoSize = true;
            labelToplam.Location = new Point(168, 32);
            labelToplam.Name = "labelToplam";
            labelToplam.Size = new Size(64, 19);
            labelToplam.TabIndex = 10;
            labelToplam.Text = "150TL";
            labelToplam.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(65, 32);
            label9.Name = "label9";
            label9.Size = new Size(97, 19);
            label9.TabIndex = 9;
            label9.Text = "Toplam: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Algerian", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(15, 48);
            label11.Name = "label11";
            label11.Size = new Size(483, 35);
            label11.TabIndex = 10;
            label11.Text = "Sinematoryum_SATIŞ_PANELI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(679, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(87, 100);
            button2.Name = "button2";
            button2.Size = new Size(123, 45);
            button2.TabIndex = 13;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(947, 343);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Sinematoyum";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtMısır;
        private TextBox TxtSu;
        private TextBox TxtÇay;
        private TextBox TxtBilet;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private Button button1;
        private Label labelToplam;
        private Label label9;
        private Label label11;
        private PictureBox pictureBox1;
        private Label labelKasaTutar;
        private Label label12;
        private Button button2;
    }
}