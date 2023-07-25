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
using System.Collections.Generic;
using System.Drawing;

namespace savas.Libary.Concrete
{

    internal class Dusman : Cisim 
    {
        
        private static readonly Random random = new Random();
     

        public Dusman(Size hareketAlaniBoyutlari): base(hareketAlaniBoyutlari)
        {
            HareketMasafesi = (int)(Height * 0.15);
            Left = random.Next(hareketAlaniBoyutlari.Width - Width + 1);
        }
        public Ates CArptiMi (List<Ates> atesler)
        {
            foreach (var ates in atesler)
            {
                var carptimi = ates.Top < Bottom && ates.Right > Left && ates.Left < Right;
                if (carptimi) return ates;
            }
            return null;
        }
    }
}
