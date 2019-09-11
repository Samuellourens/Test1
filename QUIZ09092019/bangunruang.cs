using System;

namespace QUIZ09092019
{
    class bangunruang
{
public void Volume_balok()
{
    int panjang, lebar, tinggi, volume;

    Console.WriteLine("Menghitung Volume Balok");
    Console.WriteLine("----------------------");

    Console.Write("panjang = ");
    panjang = Convert.ToInt32(Console.ReadLine());

    Console.Write("lebar = ");
    lebar = Convert.ToInt32(Console.ReadLine());

    Console.Write("tinggi = ");
    tinggi = Convert.ToInt32(Console.ReadLine());

    volume = panjang * lebar * tinggi;

    Console.WriteLine("Volume balok ="+volume);
}
public void Volume_kubus()
{
    int sisi, volume;

    Console.WriteLine("Menghitung Volume Kubus");
    Console.WriteLine("-----------------------");

    Console.Write("sisi = ");
    sisi = Convert.ToInt32(Console.ReadLine());

    volume = sisi * sisi * sisi;

    Console.WriteLine("Volume Kubus ="+volume);
}
} 
}
