using System;

namespace ATM_project
{
    public class BankAtm
    {
        double balance = 199.9;
        int pin = 1234;
        int pin1;
        int choice;
        double amount;
        int exit = 0;
        int receipt;

        public void OurATM()
        {
            Console.WriteLine("Please enter your pin: ");
            pin1 = Convert.ToInt32(Console.ReadLine());

            if (pin == pin1)
            {
                Console.Clear();
                Console.WriteLine("Pin verification successful");

                do // switchin sisällä olevat break -komennot ohjaavat takaisin tähän valintaan
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. To check balance");
                    Console.WriteLine("2. To withdraw money");
                    Console.WriteLine("3. To quit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (choice)
                    {
                        case 1: //saldon tarkistus
                            
                            Console.WriteLine($"The balance on your account is {balance} €");
                            break; // ohjaa takaisin do - while:n alkuun
                        case 2: // rahan nosto
                            Console.Clear();
                            Console.WriteLine("Enter the amount to withdraw: ");
                            {
                                amount = Convert.ToDouble(Console.ReadLine());

                                 if (amount >= 0) // Ettei pysty nostamaan negatiivista summaa
                                {

                                }

                                else 
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You can't withdraw negative amount, please try again");

                                    break;

                                }


                                if (amount <= balance) 
                                {
                                    Console.Clear();
                                    Console.WriteLine("Would you like a receipt?");
                                    Console.WriteLine("1. Yes   2. No");
                                    receipt = Convert.ToInt32(Console.ReadLine());
                                    balance = Math.Round((balance - amount), 2); // tilin uusi saldo tallennetaan tässä vaiheessa uudestaan balance -muuttujaan

                                    if (receipt == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"You withdrew {amount} €, and your balance is {balance} €"); /* saadaan tulostettua tilin uusi saldo, koska saldosta 
                                                                                                                        vähennetty nostettu summa ja näiden tulos tallennettu ylempänä*/
                                        Console.WriteLine("Please remove your card!");
                                    }
                            

                                    else
                                    {
                                        Console.WriteLine("Please take your money");
                                    }
                                }



                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Your account doesn't have sufficient balance");
                                    Console.WriteLine("Please remove your card!");
                                }
                            }
                            exit = 1; // ohjaa ulos do - while:sta, koska exit alustettu nollaksi ja tässä exit on jotain muuta kuin nolla
                            break; // ohjaa takaisin do - while:n alkuun
                        case 3:
                            Console.WriteLine("Please remove your card!");
                            exit = 1; // ohjaa ulos do - while:sta, koska exit alustettu nollaksi ja tässä exit on jotain muuta kuin nolla
                            break;
                    }
                }
                while (exit == 0); //toteuttaa case 1 ja case 2 looppeja
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong pin code, please remove your card!");


            }
        }
    }
}