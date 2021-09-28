using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace UAS
{
    class PrintNota : Machine
    {
        int temp;
        int total;
        int kembalian;
        public PrintNota (int jumlah, int[] code, int cash) : base(jumlah, code, cash) { }
        public void tampilNota()
        {
            for (int i = 0; i < jumlah; i++)
            {
                temp = code[i] - 1;
                total += harga[temp];
            }
            if (cash >= total)
            {
                Console.WriteLine("\n====================================================");
                Console.WriteLine("\t\tNota Pembelian");
                Console.WriteLine("====================================================");
                Console.WriteLine("Daftar barang yang dibeli");
                for (int i = 0; i < jumlah; i++)
                {
                    temp = code[i] - 1;
                    Console.WriteLine("\t" + barang[temp] + " | " + "Rp. " + harga[temp]);
                }
                Console.WriteLine("\nUang  Bayar = \t" + cash);
                Console.WriteLine("Total Harga = \t" + total);
                Console.WriteLine("-------------------------------  -");
                Console.Write("\t\t");
                Console.WriteLine(cash - total);
                Console.WriteLine("====================================================");

                string path = @"D:\textFile\my_file.txt";

                // The line below will create a text file, my_file.txt, in 
                // the Text_Files folder in D:\ drive.
                // The CreateText method that returns a StreamWriter object

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLineAsync("\n====================================================");
                    sw.WriteLineAsync("\t\tNota Pembelian");
                    sw.WriteLineAsync("====================================================");
                    sw.WriteLineAsync("Daftar barang yang dibeli");
                    for (int i = 0; i < jumlah; i++)
                    {
                        temp = code[i] - 1;
                        sw.WriteLineAsync("\t" + barang[temp] + " | " + "Rp. " + harga[temp]);
                    }
                    sw.WriteLineAsync("\nUang  Bayar = \t" + cash);
                    sw.WriteLineAsync("Total Harga = \t" + total);
                    sw.WriteLineAsync("-------------------------------  -");
                    sw.WriteAsync("\t\t");
                    kembalian = cash - total;
                    sw.WriteLineAsync("Rp. " + kembalian);
                    sw.WriteLineAsync("====================================================");

                    Console.WriteLine(@"Nota Printed D:\textFile\my_file.txt");
                }
            }
            else
            {
                Console.WriteLine("Nota Skipped");
            }

        }
    }
}
