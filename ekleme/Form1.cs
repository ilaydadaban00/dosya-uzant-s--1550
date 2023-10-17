using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string secim;
            bool cevap1,cevap2;
            secim=lbuzanttı.SelectedItem.ToString();
            cevap1=rb1videodosyasi.Checked;
            cevap2 = rb2ResimDosyası.Checked;
            if (cevap1==true && (secim=="mp4" || secim=="mov"))
            {
                MessageBox.Show("cevabınız dogrudur");
            }

            if(cevap1==false && (secim == "mp4" || secim=="mov"))
            {
                MessageBox.Show("cevabınız yanlış");
            }
             if (cevap2==true&&(secim=="jpg" || secim=="png"))
            {
                MessageBox.Show("cevabınız dogru");
            }
             if(cevap2==false && (secim=="jpg"|| secim=="png"))
            {
                MessageBox.Show("cevabınız yanlıştır");
            }
        }   

    }
}
