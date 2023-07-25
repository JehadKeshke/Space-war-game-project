/****************************************************************************
                    ** SAKARYA ÜNİVERSİTESİ **
           ** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ **
             ** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ **
                ** NESNEYE DAYALI PROGRAMLAMA DERSİ **
                     ** 2020-2021 BAHAR DÖNEMİ **
                              ******
                      ** ÖDEV NUMARASI : 1 **
                ** ÖĞRENCİ ADI : CİHAD EDDİN KEŞKE **
                 ** ÖĞRENCİ NUMARASI : B201200573 **
                    ** DERSİN ALINDIĞI GRUP : A **
****************************************************************************/

using System;
using System.Windows.Forms;
using savas.Libary.Concrete;
using savas.Libary.Enum;




namespace savas.Desktop 
{
    public partial class AnaForm : Form
    {
        
        private readonly Oyun _oyun;

        public bool DEvamEdioyrmu { get; private set; }



        public AnaForm()
        {
            InitializeComponent();
            _oyun = new Oyun(ucakPanel,savasPanel,Scorelabel,lev,bitmeklabel,button1,button2);
            


        }
        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    bilgiLabel.Visible = false;
                    Scorelabel.Visible = true;
                    label2.Visible = true;
                    lev.Visible = true;
                    _oyun.devam();
                    break;
                case Keys.Right :
                    _oyun.UcakHareketEttir(Yon.Saga);
                    break;               
                case Keys.Left:
                    _oyun.UcakHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
                case Keys.Escape:
                    _oyun.pause();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
