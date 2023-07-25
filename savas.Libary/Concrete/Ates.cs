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

using savas.Libary.Abstract;
using System;
using System.Drawing;

namespace savas.Libary.Concrete
{
    internal class Ates : Cisim 
    {
        private static Size _hareketTimer;

        public  Ates(Size hareketAlaniBoyutlari, int namluOrtasiX):base(hareketAlaniBoyutlari)
        {
            
            Ateskounumu(namluOrtasiX);
            HareketMasafesi = (int)(Height * 1.5);
        }

        private void Ateskounumu(int namluOrtasiX)
        {
            Bottom = HareketAlaniBoyutlari.Height;
            Center = namluOrtasiX;
            
        }
    }
}
