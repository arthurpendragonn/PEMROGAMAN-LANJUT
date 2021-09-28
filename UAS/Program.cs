using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumlahBarang = 0;
            //int[] codeBarang;
            int uangBayar = 0;
            int temp;
            int[] arr = new int[2];

            Console.WriteLine("====================================================");
            Console.WriteLine("Program Transaksi Sederhana by Abdillah Pramudito");
            Console.WriteLine("\t\tUAS Pemrogaman");
            Console.WriteLine("====================================================");

            DaftarBarang man = new DaftarBarang(jumlahBarang, arr, uangBayar);
            man.printManual();

            Console.Write("\nInputkan Jumlah Barang : ");
            jumlahBarang = int.Parse(Console.ReadLine());
            int[] codeBarang = new int[jumlahBarang];

            for (int i = 0; i < jumlahBarang; i++)
            {
                Console.Write(i + 1 + "." + "Inputkan Code Barang :");
                temp = int.Parse(Console.ReadLine());
                codeBarang[i] = temp;
            }

            // Kasir
            Console.Write("Masukkan Jumlah Uang : ");
            uangBayar = int.Parse(Console.ReadLine());

            Machine machine = new Machine(jumlahBarang, codeBarang, uangBayar);         
            Calculator cc = new Calculator(jumlahBarang, codeBarang, uangBayar);
            PrintNota not = new PrintNota(jumlahBarang, codeBarang, uangBayar);

            cc.transaksi();
            not.tampilNota();
        }
    }
}
