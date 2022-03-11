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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Yazdir(string isim,bool kontrol,string yol)
        {
            StreamWriter yaz = new StreamWriter(Application.StartupPath + "\\Sistem Dosyaları\\dosya");
            yaz.WriteLine(isim);
            yaz.Close();

            StreamWriter var = new StreamWriter(Application.StartupPath + "\\Sistem Dosyaları\\var");
            if (kontrol)
                var.WriteLine(1);
            else
                var.WriteLine(0);
            var.Close();

            StreamWriter yolum = new StreamWriter(Application.StartupPath + "\\Sistem Dosyaları\\yol");
            yolum.WriteLine(yol);
            yolum.Close();

            KontrolFormu x = new KontrolFormu();
            x.Show();
            x.Text = isim;
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool kontrol = true;

            foreach (string klasor in Directory.GetDirectories(Application.StartupPath))
            {
                DirectoryInfo dir = new DirectoryInfo(klasor);

                if(dir.Name == txtName.Text)
                {
                    kontrol = false;
                    break;
                }
            }

            if (kontrol)
            {
                string yol = Application.StartupPath + "\\" + txtName.Text;
                Directory.CreateDirectory(yol);
                Directory.CreateDirectory(yol + "\\dosyalar");
                File.CreateText(yol + "\\Açılış Dosyası.txt");

                Yazdir(txtName.Text, false, yol);
            }
            else
            {
                MessageBox.Show("Programın bulunduğu dosyada zaten böyle bir proje var!");
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "\"Açılış Dosyası\" isimli dosyalar (*txt)|*.txt";

            if(od.ShowDialog() == DialogResult.OK)
            {
                if(od.FileName.EndsWith("Açılış Dosyası.txt"))
                {
                    txtPath.Text = od.FileName;
                }
                else
                {
                    MessageBox.Show("Yanlış bir dosya seçildi!");
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string kelime = "";

            int say = txtPath.Text.Split(Convert.ToChar("\\")).Length;

            for (int i = 0; i < say; i++)
            {
                if(i < say - 1)
                {
                    kelime += txtPath.Text.Split(Convert.ToChar("\\"))[i];
                }
                if(i < say - 2)
                {
                    kelime += "\\";
                }
            }

            string yol = kelime;
            string dosya_ismi = yol.Split(Convert.ToChar("\\"))[yol.Split(Convert.ToChar("\\")).Length - 1];

            Yazdir(dosya_ismi, true, yol);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
