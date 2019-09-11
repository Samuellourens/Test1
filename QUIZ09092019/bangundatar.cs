using System;

namespace QUIZ09092019
{
    class bangundatar   
{
public void Luas_persegi()
{
    int sisi , luas;

    Console.WriteLine("Menghitung luas persegi");
    Console.WriteLine("-----------------------");

    Console.Write("Sisi = ");
    sisi = Convert.ToInt32(Console.ReadLine());

    luas = sisi * sisi;

    Console.WriteLine("Luas persegi = "+luas);
}

    public void Luas_Segitiga()
    {
        int alas , tinggi , luas2;

        Console.WriteLine("Menghitung Luas Segitiga");
        Console.WriteLine("------------------------");

        Console.Write("alas = ");
        alas = Convert.ToInt32(Console.ReadLine());

        Console.Write("tinggi = ");
        tinggi = Convert.ToInt32(Console.ReadLine());

        luas2 = alas * tinggi / 2;

        Console.WriteLine("Luas segitiga = "+luas2);


    }
    public void Luas_Lingkaran()
    {
        double radius, luas;

        Console.WriteLine("Menghitung Luas Lingkaran");
        Console.WriteLine("-------------------------");

        Console.Write("radius = ");
        radius = Convert.ToInt32(Console.ReadLine());

        luas = 3.14 * radius * radius;

        Console.WriteLine("Luas Lingkaran = "+luas);
    
    }

        
    }
}

