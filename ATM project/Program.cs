using System;

namespace ATM_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // saadaan € -merkki tulostettua

            BankAtm bankatm = new BankAtm();

            bankatm.OurATM();

            Console.ReadKey();
        }
    }
}
