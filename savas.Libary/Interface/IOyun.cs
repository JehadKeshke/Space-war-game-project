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
using savas.Libary.Enum;
using savas.Libary.Interface;

namespace savas.Libary.Interface
{
    
    internal interface IOyun
    {
        
        bool DevamEdiyormu { get; }
       
        void Baslat();
        void AtesEt();
        void UcakHareketEttir(Yon yon);

    }
}
