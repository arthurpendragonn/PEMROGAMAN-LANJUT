using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Machine
    {
        public int[] code;
        public int jumlah;
        public int total = 0;
        public int cash;


        public Machine(int jumlah, int[] code, int cash)
        {
            this.jumlah = jumlah;
            this.code = code;
            this.cash = cash;
        }

        public string[] barang = new string[4] {
            "Kulkas", "Kipas ", "HP    ", "Laptop"
            };
        public int[] harga = new int[4] {
            1000000,2000000,3000000,5000000
            };
    }
}
