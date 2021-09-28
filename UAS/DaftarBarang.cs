using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class DaftarBarang : Machine
    {
        public DaftarBarang(int jumlah, int[] code, int cash) : base(jumlah, code, cash) { }
        public void printManual()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("\t\tManual\t");
            for (int i=0; i <= 3; i++)
            {
                Console.WriteLine(i+1 + ". " + barang[i] + " | " + "Rp. " + harga[i] + " | " + "Code " + (i + 1));       
            }
            Console.WriteLine("====================================================");

        }
    }
}
