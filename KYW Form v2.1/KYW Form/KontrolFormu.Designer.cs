namespace KYW_Form
{
    partial class KontrolFormu
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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtYazi = new System.Windows.Forms.RichTextBox();
            this.nmSize = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nmY = new System.Windows.Forms.NumericUpDown();
            this.nmX = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProperties = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nesneEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nesnelerHakkındaBilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaSayfayaDönToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formYüklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enSonKayıttanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şimdikiHaliyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmX)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnlForm.Location = new System.Drawing.Point(12, 75);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1078, 612);
            this.pnlForm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orjinal Windows Forma Göre 7/9 Oranında Küçültülmüş Hali Aşağıdaki Gibidir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1082, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tüm Bilgiler ve Nesneler İçin Sağ Tıklayın";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.txtYazi);
            this.panel2.Controls.Add(this.nmSize);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.nmY);
            this.panel2.Controls.Add(this.nmX);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblSelectedItem);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnProperties);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1096, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 612);
            this.panel2.TabIndex = 2;
            // 
            // txtYazi
            // 
            this.txtYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazi.Location = new System.Drawing.Point(45, 172);
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(192, 135);
            this.txtYazi.TabIndex = 20;
            this.txtYazi.Text = "";
            this.txtYazi.TextChanged += new System.EventHandler(this.txtYazi_TextChanged);
            // 
            // nmSize
            // 
            this.nmSize.Location = new System.Drawing.Point(117, 134);
            this.nmSize.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSize.Name = "nmSize";
            this.nmSize.ReadOnly = true;
            this.nmSize.Size = new System.Drawing.Size(120, 20);
            this.nmSize.TabIndex = 19;
            this.nmSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSize.ValueChanged += new System.EventHandler(this.nmSize_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(-2, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Yazı Büyüklüğü :";
            // 
            // nmY
            // 
            this.nmY.Location = new System.Drawing.Point(117, 108);
            this.nmY.Maximum = new decimal(new int[] {
            725,
            0,
            0,
            0});
            this.nmY.Name = "nmY";
            this.nmY.ReadOnly = true;
            this.nmY.Size = new System.Drawing.Size(120, 20);
            this.nmY.TabIndex = 17;
            this.nmY.ValueChanged += new System.EventHandler(this.nmY_ValueChanged);
            // 
            // nmX
            // 
            this.nmX.Location = new System.Drawing.Point(117, 82);
            this.nmX.Maximum = new decimal(new int[] {
            1320,
            0,
            0,
            0});
            this.nmX.Name = "nmX";
            this.nmX.ReadOnly = true;
            this.nmX.Size = new System.Drawing.Size(120, 20);
            this.nmX.TabIndex = 16;
            this.nmX.ValueChanged += new System.EventHandler(this.nmX_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(18, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Konumu (y) :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Konumu (x) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(-5, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Yazı :";
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.BackColor = System.Drawing.Color.White;
            this.lblSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectedItem.Location = new System.Drawing.Point(119, 49);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(123, 18);
            this.lblSelectedItem.TabIndex = 7;
            this.lblSelectedItem.Text = "Bir Şey Seçilmedi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seçilen İtem :";
            // 
            // btnProperties
            // 
            this.btnProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProperties.Location = new System.Drawing.Point(40, 561);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(186, 35);
            this.btnProperties.TabIndex = 5;
            this.btnProperties.Text = "Özellikleri Göster";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aşağıdan Bir Nesne Seçiniz";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 212);
            this.listBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seçilen Nesnenin Özellikleri";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nesneEkleToolStripMenuItem,
            this.nesnelerHakkındaBilgilerToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.anaSayfayaDönToolStripMenuItem,
            this.formYüklemeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 114);
            // 
            // nesneEkleToolStripMenuItem
            // 
            this.nesneEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelToolStripMenuItem});
            this.nesneEkleToolStripMenuItem.Name = "nesneEkleToolStripMenuItem";
            this.nesneEkleToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.nesneEkleToolStripMenuItem.Text = "Nesne Ekle";
            // 
            // labelToolStripMenuItem
            // 
            this.labelToolStripMenuItem.Name = "labelToolStripMenuItem";
            this.labelToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.labelToolStripMenuItem.Text = "Label";
            this.labelToolStripMenuItem.Click += new System.EventHandler(this.labelToolStripMenuItem_Click);
            // 
            // nesnelerHakkındaBilgilerToolStripMenuItem
            // 
            this.nesnelerHakkındaBilgilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelToolStripMenuItem1});
            this.nesnelerHakkındaBilgilerToolStripMenuItem.Name = "nesnelerHakkındaBilgilerToolStripMenuItem";
            this.nesnelerHakkındaBilgilerToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.nesnelerHakkındaBilgilerToolStripMenuItem.Text = "Nesneler Hakkında Bilgiler";
            // 
            // labelToolStripMenuItem1
            // 
            this.labelToolStripMenuItem1.Name = "labelToolStripMenuItem1";
            this.labelToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.labelToolStripMenuItem1.Text = "Label";
            this.labelToolStripMenuItem1.Click += new System.EventHandler(this.labelToolStripMenuItem1_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // anaSayfayaDönToolStripMenuItem
            // 
            this.anaSayfayaDönToolStripMenuItem.Name = "anaSayfayaDönToolStripMenuItem";
            this.anaSayfayaDönToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.anaSayfayaDönToolStripMenuItem.Text = "Ana Sayfaya Dön";
            this.anaSayfayaDönToolStripMenuItem.Click += new System.EventHandler(this.anaSayfayaDönToolStripMenuItem_Click);
            // 
            // formYüklemeToolStripMenuItem
            // 
            this.formYüklemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enSonKayıttanToolStripMenuItem,
            this.şimdikiHaliyleToolStripMenuItem});
            this.formYüklemeToolStripMenuItem.Name = "formYüklemeToolStripMenuItem";
            this.formYüklemeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.formYüklemeToolStripMenuItem.Text = "Form Yükleme";
            // 
            // enSonKayıttanToolStripMenuItem
            // 
            this.enSonKayıttanToolStripMenuItem.Name = "enSonKayıttanToolStripMenuItem";
            this.enSonKayıttanToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.enSonKayıttanToolStripMenuItem.Text = "En Son Kayıttan";
            this.enSonKayıttanToolStripMenuItem.Click += new System.EventHandler(this.enSonKayıttanToolStripMenuItem_Click);
            // 
            // şimdikiHaliyleToolStripMenuItem
            // 
            this.şimdikiHaliyleToolStripMenuItem.Name = "şimdikiHaliyleToolStripMenuItem";
            this.şimdikiHaliyleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.şimdikiHaliyleToolStripMenuItem.Text = "Şimdiki Haliyle";
            this.şimdikiHaliyleToolStripMenuItem.Click += new System.EventHandler(this.şimdikiHaliyleToolStripMenuItem_Click);
            // 
            // KontrolFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlForm);
            this.Name = "KontrolFormu";
            this.Text = "dr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KontrolFormu_FormClosing);
            this.Load += new System.EventHandler(this.KontrolFormu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmX)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nesneEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nesnelerHakkındaBilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaSayfayaDönToolStripMenuItem;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmY;
        private System.Windows.Forms.NumericUpDown nmX;
        private System.Windows.Forms.NumericUpDown nmSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem formYüklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enSonKayıttanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şimdikiHaliyleToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtYazi;
    }
}