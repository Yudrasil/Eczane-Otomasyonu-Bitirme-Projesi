﻿namespace eczane_otomasyonu_deneme
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_ilac = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_Ilaclar = new System.Windows.Forms.DataGridView();
            this.tab_e_recete_sorgu = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yanurunler = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.urunlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet = new eczane_otomasyonu_deneme.EczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet();
            this.aaa = new eczane_otomasyonu_deneme.aaa();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new eczane_otomasyonu_deneme.aaaTableAdapters.UrunlerTableAdapter();
            this.urunlerTableAdapter1 = new eczane_otomasyonu_deneme.EczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSetTableAdapters.UrunlerTableAdapter();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tab_ilac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ilaclar)).BeginInit();
            this.tab_e_recete_sorgu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.yanurunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_ilac);
            this.tabControl1.Controls.Add(this.tab_e_recete_sorgu);
            this.tabControl1.Controls.Add(this.yanurunler);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1691, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_ilac
            // 
            this.tab_ilac.Controls.Add(this.label6);
            this.tab_ilac.Controls.Add(this.listBox2);
            this.tab_ilac.Controls.Add(this.button3);
            this.tab_ilac.Controls.Add(this.button1);
            this.tab_ilac.Controls.Add(this.label3);
            this.tab_ilac.Controls.Add(this.label2);
            this.tab_ilac.Controls.Add(this.label1);
            this.tab_ilac.Controls.Add(this.textBox3);
            this.tab_ilac.Controls.Add(this.textBox2);
            this.tab_ilac.Controls.Add(this.textBox1);
            this.tab_ilac.Controls.Add(this.dgv_Ilaclar);
            this.tab_ilac.Location = new System.Drawing.Point(4, 29);
            this.tab_ilac.Name = "tab_ilac";
            this.tab_ilac.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ilac.Size = new System.Drawing.Size(1683, 510);
            this.tab_ilac.TabIndex = 0;
            this.tab_ilac.Text = "İlaçlar";
            this.tab_ilac.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(1021, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 57);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seçilen İlaçlar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(1106, 93);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(438, 404);
            this.listBox2.TabIndex = 5;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 57);
            this.button3.TabIndex = 4;
            this.button3.Text = "Satışa Geç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Barkod Oku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ATC Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barkod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlaç Adı";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(378, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_Ilaclar
            // 
            this.dgv_Ilaclar.AllowDrop = true;
            this.dgv_Ilaclar.AllowUserToAddRows = false;
            this.dgv_Ilaclar.AllowUserToDeleteRows = false;
            this.dgv_Ilaclar.AllowUserToOrderColumns = true;
            this.dgv_Ilaclar.AllowUserToResizeColumns = false;
            this.dgv_Ilaclar.AllowUserToResizeRows = false;
            this.dgv_Ilaclar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_Ilaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ilaclar.Location = new System.Drawing.Point(-1, 93);
            this.dgv_Ilaclar.MinimumSize = new System.Drawing.Size(100, 0);
            this.dgv_Ilaclar.MultiSelect = false;
            this.dgv_Ilaclar.Name = "dgv_Ilaclar";
            this.dgv_Ilaclar.ReadOnly = true;
            this.dgv_Ilaclar.Size = new System.Drawing.Size(1016, 411);
            this.dgv_Ilaclar.TabIndex = 1;
            this.dgv_Ilaclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ilaclar_CellContentClick_1);
            // 
            // tab_e_recete_sorgu
            // 
            this.tab_e_recete_sorgu.Controls.Add(this.button2);
            this.tab_e_recete_sorgu.Controls.Add(this.textBox6);
            this.tab_e_recete_sorgu.Controls.Add(this.listBox1);
            this.tab_e_recete_sorgu.Controls.Add(this.dataGridView1);
            this.tab_e_recete_sorgu.Controls.Add(this.textBox5);
            this.tab_e_recete_sorgu.Controls.Add(this.label5);
            this.tab_e_recete_sorgu.Controls.Add(this.textBox4);
            this.tab_e_recete_sorgu.Controls.Add(this.label4);
            this.tab_e_recete_sorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tab_e_recete_sorgu.Location = new System.Drawing.Point(4, 29);
            this.tab_e_recete_sorgu.Name = "tab_e_recete_sorgu";
            this.tab_e_recete_sorgu.Padding = new System.Windows.Forms.Padding(3);
            this.tab_e_recete_sorgu.Size = new System.Drawing.Size(1683, 510);
            this.tab_e_recete_sorgu.TabIndex = 1;
            this.tab_e_recete_sorgu.Text = "E-Reçete Sorgula";
            this.tab_e_recete_sorgu.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(945, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "İlaçları Sat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(25, 70);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(205, 344);
            this.textBox6.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(447, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(435, 344);
            this.listBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(205, 344);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(393, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 26);
            this.textBox5.TabIndex = 1;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "E Reçete Kod";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 26);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "T.C. KN.";
            // 
            // yanurunler
            // 
            this.yanurunler.Controls.Add(this.label7);
            this.yanurunler.Controls.Add(this.listBox3);
            this.yanurunler.Controls.Add(this.button4);
            this.yanurunler.Controls.Add(this.button5);
            this.yanurunler.Controls.Add(this.label8);
            this.yanurunler.Controls.Add(this.label9);
            this.yanurunler.Controls.Add(this.label10);
            this.yanurunler.Controls.Add(this.textBox7);
            this.yanurunler.Controls.Add(this.textBox8);
            this.yanurunler.Controls.Add(this.textBox9);
            this.yanurunler.Controls.Add(this.dataGridView2);
            this.yanurunler.Location = new System.Drawing.Point(4, 29);
            this.yanurunler.Name = "yanurunler";
            this.yanurunler.Size = new System.Drawing.Size(1683, 510);
            this.yanurunler.TabIndex = 2;
            this.yanurunler.Text = "Yan Ürün Satışı";
            this.yanurunler.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Location = new System.Drawing.Point(1048, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 57);
            this.label7.TabIndex = 17;
            this.label7.Text = "Seçilen İlaçlar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(1133, 86);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(438, 404);
            this.listBox3.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(719, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 57);
            this.button4.TabIndex = 14;
            this.button4.Text = "Satışa Geç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(621, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 57);
            this.button5.TabIndex = 15;
            this.button5.Text = "Barkod Oku";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "ATC Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Barkod";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "İlaç Adı";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(120, 54);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(210, 26);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(405, 23);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(210, 26);
            this.textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(120, 23);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(210, 26);
            this.textBox9.TabIndex = 10;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 86);
            this.dataGridView2.MinimumSize = new System.Drawing.Size(100, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1016, 411);
            this.dataGridView2.TabIndex = 7;
            // 
            // urunlerBindingSource1
            // 
            this.urunlerBindingSource1.DataMember = "Urunler";
            this.urunlerBindingSource1.DataSource = this.eczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet;
            // 
            // eczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet
            // 
            this.eczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet.DataSetName = "EczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet";
            this.eczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aaa
            // 
            this.aaa.DataSetName = "aaa";
            this.aaa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.aaa;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // urunlerTableAdapter1
            // 
            this.urunlerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 557);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_ilac.ResumeLayout(false);
            this.tab_ilac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ilaclar)).EndInit();
            this.tab_e_recete_sorgu.ResumeLayout(false);
            this.tab_e_recete_sorgu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.yanurunler.ResumeLayout(false);
            this.yanurunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_ilac;
        private System.Windows.Forms.TabPage tab_e_recete_sorgu;
        private System.Windows.Forms.DataGridView dgv_Ilaclar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox2;
        private aaa aaa;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private aaaTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private EczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet eczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource1;
        private EczaneOtomasyonuVeArduinoAraciligiylaStokTakipDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabPage yanurunler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}