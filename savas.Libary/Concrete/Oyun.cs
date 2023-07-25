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

using savas.Libary.Enum;
using savas.Libary.Interface;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace savas.Libary.Concrete
{
    
    public class Oyun : AnaForm ,  IOyun 
    {

      
        #region Olaylar
        public readonly Timer _hareketTimer = new Timer { Interval = 100 };
        public readonly Timer _dusmanTimer = new Timer { Interval = 2200 };       
        private readonly Panel _ucakPanel;
        private readonly Panel _savasPanel;
        private Ucaksavar _ucaksavar;
        private readonly List<Ates> _Atesler = new List<Ates>();
        private readonly List<Dusman> _Dusmanlar = new List<Dusman>();
        private Label _scorelabel;
        private Label _lev;
        private Label _bitmeklabel;
        private Button _button1;
        private Button _button2;
        public int temp = 0;
       
        #endregion

        #region Alalnlar
        public Oyun(Panel ucakpanel, Panel savasPanel, Label Scorelabel, Label lev, Label bitmeklabel, Button button1, Button button2)
        {
            _ucakPanel = ucakpanel;
            _savasPanel = savasPanel;
            _scorelabel = Scorelabel;
            _lev = lev;
            _bitmeklabel = bitmeklabel;
            _button1 = button1;
            _button2 = button2;
            _hareketTimer.Tick += HareketTimer_Tick;
            _dusmanTimer.Tick += DusmanTimer_Tick;
        }


        #endregion

        #region ozellikler
        public bool DevamEdiyormu { get; private set; }
        public object PictureBox1 { get; private set; }
        public double Height { get; private set; }
        public int HareketMasafesi { get; private set; }
        #endregion

        #region metotlar




        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            AteslerHareketEttir();
            DusmanHareketTimer();
            DusmanOldurmek();
        }

        public void DusmanOldurmek()
        {
            for (var i = _Dusmanlar.Count-1; i >= 0; i--)
            {
                
                var dusman = _Dusmanlar[i];
                var carpanAtes = dusman.CArptiMi(_Atesler);
                if (carpanAtes is null) continue;
                _Dusmanlar.Remove(dusman);
                _Atesler.Remove(carpanAtes);
                _savasPanel.Controls.Remove(dusman);
                _savasPanel.Controls.Remove(carpanAtes);
                int.TryParse(_scorelabel.Text, out temp);
                _scorelabel.Text = (temp + 1).ToString();
                if ((temp +1) % 10 == 0  )
                {
                    _dusmanTimer.Interval -=  500;
                    if (_dusmanTimer.Interval <=600) { _dusmanTimer.Interval = 600; }
                    int temp2 = 1;
                    int.TryParse(_lev.Text, out temp2);
                    _lev.Text = (temp2 + 1).ToString();

                }

            }
            
        }

        public void Score()
        {
            
        }

        private void DusmanTimer_Tick(object sender, EventArgs e)
        {
            DusmanOlustur();
          
        }
        

        private void DusmanHareketTimer()
        {
            foreach (var dusman in _Dusmanlar)
            {
              var carpmak =  dusman.HareketEttir(Yon.Asagi);
                if (!carpmak) continue;
                Bitir();
                break;
            }

        }

        private void AteslerHareketEttir()
        {
            for (int i = _Atesler.Count-1; i >= 0; i--)
            {
                var ates = _Atesler[i];
                var carpmak = ates.HareketEttir(Yon.Yukari);
                if (carpmak)
                {
                    _Atesler.Remove(ates);
                    _savasPanel.Controls.Remove(ates);
                }
            }
        }


        public void AtesEt()
        {
            if (!DevamEdiyormu) return;
            var ates = new Ates(_savasPanel.Size,_ucaksavar.Center);
            _Atesler.Add(ates); 
            _savasPanel.Controls.Add(ates);
            ates.HareketEttir(Yon.Yukari);
        }
        

        public void Baslat()
        {
            if (DevamEdiyormu) return;
            DevamEdiyormu = true;
            _hareketTimer.Start();
            _dusmanTimer.Start();
            UcaksavarOlustur();
            DusmanOlustur();
            
        }

        private void DusmanOlustur()
        {
         

            var dusman = new Dusman(_savasPanel.Size);
            _Dusmanlar.Add(dusman);
           _savasPanel.Controls.Add(dusman);
            
        }

        private void UcaksavarOlustur()
        {
            
            _ucaksavar = new Ucaksavar(_ucakPanel.Width, _ucakPanel.Size)
            {  };
            _ucakPanel.Controls.Add(_ucaksavar);
           




        }
        public void Bitir()
        {
            if (!DevamEdiyormu) return; 
            DevamEdiyormu = false;
            _hareketTimer.Stop();
            _dusmanTimer.Stop();
           
            _ucaksavar.Image = Image.FromFile(@"icons\fire.png");
            _bitmeklabel.Visible = true;
            _button1.Visible = true;
            _button2.Visible = true;
            
        }
        public void pause()
        {
            _hareketTimer.Stop();
            _dusmanTimer.Stop();
           
        }
        public void devam()
        {
            _hareketTimer.Start();
            _dusmanTimer.Start();
        }
        

        public void UcakHareketEttir(Yon yon)
        {
            if (!DevamEdiyormu) return;
            _ucaksavar.HareketEttir(yon);
           


        }

        #endregion

    }
}
