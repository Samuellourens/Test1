using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            bangundatar kelas = new bangundatar();
            kelas.Luas_persegi(); 
            kelas.Luas_Segitiga();
            kelas.Luas_Lingkaran();
            
            bangunruang kelas2 = new bangunruang();
            kelas2.Volume_balok();
            kelas2.Volume_kubus();
        }
    }
}
