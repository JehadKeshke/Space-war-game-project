using System.Drawing;
using savas.Libary.Enum;



namespace savas.Libary.Interface
{
    internal interface HareketEden
    {
       Size HareketAlaniBoyutlari { get;  }
        
        int HareketMasafesi { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yon"></param>
        /// <returns></returns>
        bool HarketEttir(Yon yon);
    }
}
