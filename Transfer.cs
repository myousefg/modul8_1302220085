using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302220085
{
    internal class Transfer
    {
        public int threshold { set; get; }
        public int low_fee { set; get; }
        public int high_fee { set; get; }

        public Transfer(int threshold, int low_fee, int high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }
}
