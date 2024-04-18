using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modul8_1302220085;

namespace modul8_1302220085
{
    internal class BankTransferConfig
    {
        public string lang { set; get; }
        public Transfer Transfer { set; get; }
        public List<string> methods { set; get; }
        public Confirmation confirmation { set; get; }

        public BankTransferConfig() { }
        public BankTransferConfig(string lang, Transfer transfer, List<string> methods, Confirmation confirmation)
        {
            this.lang = lang;
            this.Transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }
}