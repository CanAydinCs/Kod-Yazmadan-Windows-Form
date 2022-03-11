using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form lastForm;

        private void BtnSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                lblSelectedColor.BackColor = cd.Color;
            }
        }

        private void BtnCreateForm_Click(object sender, EventArgs e)
        {
            lastForm = new Form();
            lastForm.BackColor = lblSelectedColor.BackColor;
            lastForm.WindowState = FormWindowState.Maximized;
            lastForm.Show();
        }
    }
}
