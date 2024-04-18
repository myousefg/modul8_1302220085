using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using modul8_1302220085;

namespace modul8_1302220085
{
    internal class UIConfig
    {
        public BankTransferConfig config;
        public const String filePath = @"C:\\Users\\myous\\Documents\\GitHub\\tpmodul8_1302220085\\modul8_1302220085\\modul8_1302220085\\config.json";
        public UIConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }
        private BankTransferConfig ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
            return config;
        }

        public void SetDefault() 
        { 
            Transfer transfer = new Transfer(25000000, 6500, 15000);
            List<string> method = new List<string>() { "RTO(real - time)", "SKN", "RTGS", "BI FAST" };
            Confirmation confirmation = new Confirmation("yes", "ya");
            config = new BankTransferConfig ("en", transfer, method, confirmation);
        }
            

        private void WriteNewConfigFile()
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };
                String jsonString = JsonSerializer.Serialize(config, options);
                File.WriteAllText(filePath, jsonString);
        }
    }
}