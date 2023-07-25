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
using System.Drawing;
using System.Windows.Forms;
using savas.Libary.Abstract;
using savas.Libary.Enum;
using savas.Libary.Interface;
using savas.Libary.Concrete;


namespace savas.Libary.Abstract

{
    internal abstract class Cisim : PictureBox , IHareket
    {
        public Size HareketAlaniBoyutlari { get; }

        public int HareketMasafesi { get; protected set; }
        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }
        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }
        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }
        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }

        protected Cisim(Size hareketAlaniBoyutlari)
        {    
            Image = Image.FromFile($@"icons\{GetType().Name}.png");
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;          
        }

      
          
           
        

        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Yukari:
                    return YukariHarketEttir();
                case Yon.Saga:
                    return SagaHarketEttir();                   
                case Yon.Asagi:
                    return AsagiHarketEttir();
                case Yon.Sola:
                    return SolaHarketEttir();
                default: throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
                   

            }
        }

        private bool SolaHarketEttir()
        {
            if (Left == 0) return true;
            var Y_Left = Left - HareketMasafesi;
            var tasmak = Y_Left < 0;
            Left = tasmak ? 0 : Y_Left;
            return Left == 0;
        }

        private bool AsagiHarketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Height) return true;
            var Y_Bottom = Bottom + HareketMasafesi;
            var tasmak = Y_Bottom > HareketAlaniBoyutlari.Height;
            Bottom = tasmak ? HareketAlaniBoyutlari.Height : Y_Bottom;         
            return Bottom == HareketAlaniBoyutlari.Height;
        }

        private bool SagaHarketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width) return true;
            var Y_Right = Right + HareketMasafesi;
            var tasmak = Y_Right > HareketAlaniBoyutlari.Width;
            Right = tasmak ? HareketAlaniBoyutlari.Width : Y_Right;     
            return Right == HareketAlaniBoyutlari.Width;
        }

        private bool YukariHarketEttir()
        {

            if (Top == 0) return true;
            var y_Top = Top - HareketMasafesi;
            var tasmak = y_Top < 0;
            Top = tasmak ? 0 : y_Top;
            return Top == 0;
        }
    }
}
