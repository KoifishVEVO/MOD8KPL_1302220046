// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

class Program
{
    private static int fee;

    static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        config.ReadJSON();


        if (config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");

        } else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
        }
        int amount = int.Parse(Console.ReadLine());
        int totalPembayaran;
        
     

        if (amount <= config.threshold) 
        {
            fee = config.low_fee;
            totalPembayaran = amount + fee;
        } else 
        {
             fee = config.high_fee;
            totalPembayaran = amount + fee;
        }

        if (config.lang == "en")
        {
            Console.WriteLine("transfer fee = " + fee);
            Console.WriteLine("Total ammount = "+totalPembayaran);

        } else
        {
            Console.WriteLine("Biaya transfer = " + fee);
            Console.WriteLine("Total Biaya = " + totalPembayaran);
        }

        if (config.lang == "en")
        {
            Console.WriteLine("Select Transfer method: ");

        }
        else
        {
            Console.WriteLine("Pilih metode transfer:");
        }

        for (int i = 0; i < config.methods.Length; i++)
        {
            Console.WriteLine(i+1 + ". " + config.methods[i]);
        }

        int choice = int.Parse(Console.ReadLine());
        string konfirmasi;

        
        if (config.lang == config.en)
        {
            
            
                Console.WriteLine("Please type " + config.en + " to confirm the transaction:");
                konfirmasi = Console.ReadLine();
            if (konfirmasi == config.en)
            {
                Console.WriteLine("The transfer is completed");
            } else
            {
                Console.WriteLine("Transfer is cancelled");
            }
            
            } else
        {
            
            
                Console.WriteLine("Ketik " + config.id + " untuk mengkonfirmasi transaks:");
                konfirmasi = Console.ReadLine();
                if (konfirmasi == config.id)
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            else
            {
                Console.WriteLine("Transfer dibatalkan");
            }
        }


        


    }
}
