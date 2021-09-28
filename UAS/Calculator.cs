using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Calculator : Machine
    {
        public Calculator(int jumlah, int[] code, int cash) : base(jumlah, code, cash) { }
        int temp;
        int total;

        public void transaksi()
        {
            for (int i = 0; i < jumlah; i++)
            {
                temp = code[i] - 1;
                total += harga[temp];
            }

            if (cash >= total)
            {
                Console.WriteLine("Transaksi Berhasil");
                if (cash == total)
                {
                    Console.WriteLine("Uang Pas");
                }
                else
                {
                    Console.Write("Kembalian = ");
                    Console.WriteLine(cash - total);
                }
            } else
                Console.WriteLine("Uang Kurang")
;
        }

    }
}
