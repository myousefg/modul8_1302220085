using System.Collections.Generic;
using System.Numerics;
using modul8_1302220085;

internal class Program
{
    private static void Main(string[] args)
    {
        int biaya_transfer = 0;
        int nominal_transfer = 0;
        UIConfig uIConfig = new UIConfig();
        if (uIConfig.config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");

            Console.WriteLine("Transfer fee = ", "<biaya_transfer>", " and Total amount = ", "<nominal_transfer + biaya_transfer>");
        } else {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");

            Console.WriteLine("Biaya transfer = ", "<biaya_transfer>", " dan Total biaya = ", "<nominal_transfer + biaya_transfer>");

        }
    }
}