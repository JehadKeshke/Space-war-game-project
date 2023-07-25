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
using System.Windows.Forms;
using System.Drawing;
using System;

namespace savas.Libary.Concrete
{
    internal class Ucaksavar : Cisim
    {
        public Ucaksavar (int panelboyutu, Size hareketAlaniBoyutlari): base(hareketAlaniBoyutlari)
        {
            Left = (panelboyutu - Width) / 2;
           
            HareketMasafesi = Width;
          /*  SizeMode = PictureBoxSizeMode.AutoSize;*/
        }

        
    }
}
