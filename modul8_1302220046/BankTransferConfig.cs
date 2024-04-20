using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

public class BankTransferConfig
{


	public string lang { get; set; }
	
	

	public string[] methods { get; set; }

	public class confirmation
	{
        public string en { get; set; }
        public string id { get; set; }
    }
    public class transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }








    public BankTransferConfig ReadJSON()
	{
		
		string json = File.ReadAllText("C:\\Users\\LENOVO\\Downloads\\modul8_1302220046\\modul8_1302220046\\bank_transfer_config.json");
		BankTransferConfig data = JsonConvert.DeserializeObject<BankTransferConfig>(json);
        this.lang = data.lang;
        this = data.threshold;
        this.low_fee = data.low_fee;
        this.high_fee = data.high_fee;
        this.methods = data.methods;
        this.en = data.en;
        this.id = data.id;



        return data;
		

	}
}
