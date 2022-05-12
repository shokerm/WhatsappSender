using System;
using System.Diagnostics;
namespace WhatsappSender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter number phone");
            string phoneNumber = Console.ReadLine();

            if (phoneNumber.Contains('-') && phoneNumber.Substring(0, 1) == "0")
            {
                for (int i = 0; i < phoneNumber.Count(); i++)
                {
                    if(phoneNumber.Contains('-'))
                    {
                        int y = phoneNumber.IndexOf('-');
                        phoneNumber = phoneNumber.Remove(y, 1);
                    }

                }

                phoneNumber = "+972" + phoneNumber.Substring(1, 9);
                Console.WriteLine(phoneNumber);

            }
            else if (!phoneNumber.Contains('-') && phoneNumber.Substring(0, 2) == "05")
            {
                phoneNumber = "+972" + phoneNumber.Substring(1, 9);
                Console.WriteLine(phoneNumber);

            }

            //if (phoneNumber.Substring(3, 1) == "-" && phoneNumber.Substring(0, 1) == "0")
            //{
            //    phoneNumber = phoneNumber.Remove(3, 1);
            //    phoneNumber = "+972" + phoneNumber.Substring(1, 9);
            //    Console.WriteLine(phoneNumber);

            //}
            //else if (!phoneNumber.Contains('-') && phoneNumber.Substring(0,2) == "05")
            //{
            //    phoneNumber = "+972" + phoneNumber.Substring(1, 9);
            //    Console.WriteLine(phoneNumber);

            //}




            //if (phoneNumber?.Substring(0, 1) == "0")
            //{
            //    phoneNumber = "+972" + phoneNumber.Substring(1, 9);
            //    var ps = new ProcessStartInfo($"https://web.whatsapp.com/send?phone= + {phoneNumber}");
            //    ps.UseShellExecute = true;
            //    Process.Start(ps);


            //}
        }
    }
}
