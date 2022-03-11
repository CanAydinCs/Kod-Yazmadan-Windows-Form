using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KYW_Form
{
    public partial class KontrolFormu : Form
    {
        public KontrolFormu()
        {
            InitializeComponent();
        }

        string dosya_yolu;
        int lbl_sayisi;

        int ReturnC7B9(decimal deger)
        {
            return Convert.ToInt32(deger * 7 / 9);
        }

        void ChangeProp(string properties)
        {
            foreach (Control control in pnlForm.Controls)
            {
                if (control.GetType() == label1.GetType() && lblSelectedItem.Text.EndsWith(control.Name))
                {
                    switch (properties)
                    {
                        case "genişlik":
                            control.Width = ReturnC7B9(nmWidth.Value); break;
                        case "yükseklik":
                            control.Height = ReturnC7B9(nmHeight.Value); break;
                        case "x":
                            control.Location = new Point(ReturnC7B9(nmX.Value), control.Location.Y); break;
                        case "y":
                            control.Location = new Point(control.Location.X, ReturnC7B9(nmY.Value)); break;
                        case "size":
                            control.Font = new Font(control.Font.FontFamily, Convert.ToInt32(ReturnC7B9(nmSize.Value))); 
                            break;
                        case "yazı":
                            control.Text = txtYazi.Text; break;
                        default:
                            break;
                    }
                    break;
                }
            }
        }

        void ListBoxUpdate()
        {
            listBox1.Items.Clear();
            int lbl_say = 0;

            foreach (Control control in pnlForm.Controls)
            {
                if(control.GetType() == label1.GetType())
                {
                    listBox1.Items.Add("label" + lbl_say);
                    lbl_say++;
                }
            }
        }

        void Bilgiler(string nesne)
        {
            Form frm = new Form();
            frm.Text = nesne;
            frm.Width = 500;
            frm.Height = 500;

            Label lbl = new Label();
            lbl.Location = new Point(12, 12);
            lbl.Width = 400;
            lbl.Height = 400;

            switch (nesne)
            {
                case "label":
                    lbl.Text = "Yazıyı Ekrana Yansıtmak İçin Kullandığımız Araçtır."; break;
                default:
                    break;
            }
            frm.Controls.Add(lbl);

            frm.Show();
        }

        private void KontrolFormu_Load(object sender, EventArgs e)
        {
            lbl_sayisi = 0;

            StreamReader dosyanin_yolu = new StreamReader(Application.StartupPath + "\\Sistem Dosyaları\\yol");
            dosya_yolu = dosyanin_yolu.ReadLine() + "\\dosyalar";
            dosyanin_yolu.Close();

            StreamReader var_mi = new StreamReader(Application.StartupPath + "\\Sistem Dosyaları\\var");
            bool var = var_mi.ReadLine() == "1";
            var_mi.Close();

            if (var)
            {
                foreach (string labellar in Directory.GetFiles(dosya_yolu))
                {
                    string label_ismi = labellar.Split(Convert.ToChar("\\"))[labellar.Split(Convert.ToChar("\\")).Length - 1];

                    if (label_ismi.StartsWith("label"))
                    {
                        StreamReader bilgiler = new StreamReader(labellar);
                        Label lbl = new Label();
                        lbl.Name = lbl_sayisi.ToString();
                        lbl.Text = bilgiler.ReadLine();
                        lbl.Width = Convert.ToInt32(Convert.ToInt32(bilgiler.ReadLine()) * 7 / 9);
                        lbl.Height = Convert.ToInt32(Convert.ToInt32(bilgiler.ReadLine()) * 7 / 9);
                        int lbl_x = Convert.ToInt32(Convert.ToInt32(bilgiler.ReadLine()) * 7 / 9);
                        int lbl_y = Convert.ToInt32(Convert.ToInt32(bilgiler.ReadLine()) * 7 / 9);
                        lbl.Location = new Point(lbl_x, lbl_y);
                        lbl.Font = new Font(lbl.Font.FontFamily, (Convert.ToInt32(bilgiler.ReadLine()) * 7 / 9));
                        pnlForm.Controls.Add(lbl);
                        lbl_sayisi++;
                        bilgiler.Close();
                    }
                }
            }
            ListBoxUpdate();
        }

        private void labelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Name = lbl_sayisi.ToString();
            lbl.Text = "Label";
            lbl.Font = new Font(lbl.Font.FontFamily, 10f);
            lbl.Location = new Point(12, 12);
            pnlForm.Controls.Add(lbl);
            
            lbl_sayisi++;
            ListBoxUpdate();
        }

        private void labelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bilgiler("label");
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int lblsay = 0;

            foreach (Control control in pnlForm.Controls)
            {
                if(control.GetType() == label1.GetType())
                {
                    Label lbl = (Label)control;
                    StreamWriter yaz = new StreamWriter(dosya_yolu + "\\label" + lblsay);
                    yaz.WriteLine(lbl.Text);
                    yaz.WriteLine((lbl.Width * 9 / 7));
                    yaz.WriteLine((lbl.Height * 9 / 7));
                    yaz.WriteLine((lbl.Location.X * 9 / 7));
                    yaz.WriteLine((lbl.Location.Y * 9 / 7));
                    yaz.WriteLine(Convert.ToInt32(lbl.Font.Size * 9 / 7));
                    yaz.Close();
                    lblsay++;
                }
            }
            MessageBox.Show("Kayıt Başarılı!");
        }

        private void KontrolFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void anaSayfayaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
            this.Hide();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            {
                nmWidth.ReadOnly = false;
                nmHeight.ReadOnly = false;
                nmSize.ReadOnly = false;
                nmX.ReadOnly = false;
                nmY.ReadOnly = false;
                txtYazi.ReadOnly = false;

                foreach (Control control in pnlForm.Controls)
                {
                    if(control.GetType() == label1.GetType())
                    {
                        Label lbl = (Label)control;
                        if (listBox1.SelectedItem.ToString().EndsWith(lbl.Name))
                        {
                            lblSelectedItem.Text = "Label" + lbl.Name;
                            txtYazi.Text = lbl.Text;
                            nmWidth.Value = (lbl.Width * 9 / 7);
                            nmHeight.Value = (lbl.Height * 9 / 7);
                            nmX.Value = (lbl.Location.X * 9 / 7);
                            nmY.Value = (lbl.Location.Y * 9 / 7);
                            nmSize.Value = Convert.ToDecimal(lbl.Font.Size * 9 / 7);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir eleman seçiniz.");
                nmWidth.ReadOnly = true;
                nmHeight.ReadOnly = true;
                nmX.ReadOnly = true;
                nmY.ReadOnly = true;
                nmSize.ReadOnly = true;
                txtYazi.ReadOnly = true;

                nmWidth.Value = 0;
                nmHeight.Value = 0;
                nmX.Value = 0;
                nmY.Value = 0;
                nmSize.Value = 0;
                txtYazi.Text = "";
            }
        }

        private void nmWidth_ValueChanged(object sender, EventArgs e)
        {
            ChangeProp("genişlik");
        }

        private void nmHeight_ValueChanged(object sender, EventArgs e)
        {
            ChangeProp("yükseklik");
        }

        private void nmX_ValueChanged(object sender, EventArgs e)
        {
            ChangeProp("x");
        }

        private void nmY_ValueChanged(object sender, EventArgs e)
        {
            ChangeProp("y");
        }

        private void nmSize_ValueChanged(object sender, EventArgs e)
        {
            ChangeProp("size");
        }

        private void txtYazi_TextChanged(object sender, EventArgs e)
        {
            ChangeProp("yazı");
        }
    }
}
