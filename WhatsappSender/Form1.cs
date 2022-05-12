using System.Diagnostics;
namespace WhatsappSender
{
    public partial class Form1 : Form
    {
        public string phoneNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void numberTxb_TextChanged(object sender, EventArgs e)
        {
            phoneNumber = numberTxb.Text;
        }

        private void browserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (phoneNumber.Contains('-') && phoneNumber.Substring(0, 1) == "0")
                {
                    for (int i = 0; i < phoneNumber.Count(); i++)
                    {
                        if (phoneNumber.Contains('-'))
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
                                                    
                    var ps = new ProcessStartInfo($"https://web.whatsapp.com/send?phone= + {phoneNumber}");
                    ps.UseShellExecute = true;
                    Process.Start(ps);
                    numberTxb.Text = "";

                
            }
            catch (Exception)
            {


            }
        }

        private void appBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (phoneNumber.Contains('-') && phoneNumber.Substring(0, 1) == "0")
                {
                    for (int i = 0; i < phoneNumber.Count(); i++)
                    {
                        if (phoneNumber.Contains('-'))
                        {
                            int y = phoneNumber.IndexOf('-');
                            phoneNumber = phoneNumber.Remove(y, 1);
                        }

                    }

                    phoneNumber = "972" + phoneNumber.Substring(1, 9);
                   

                }
                else if (!phoneNumber.Contains('-') && phoneNumber.Substring(0, 2) == "05")
                {
                    phoneNumber = "972" + phoneNumber.Substring(1, 9);
                    

                }

               
                    var ps1 = new ProcessStartInfo($"https://api.whatsapp.com/send?phone={phoneNumber}");
                    ps1.UseShellExecute = true;
                    Process.Start(ps1);
                    numberTxb.Text = "";
                
              
            }
            catch (Exception)
            {


            }
        }

        
    }
}