using System.Data.SqlTypes;

namespace Console_Decisions___5_
{
    internal class Program
    {
        //Banking
        static void BobBank()
        {
            Console.Clear();
            double money = 150, depositAmount, withdrawAmount, heating = 25, water = 5, hotdog = 101.34;
            string action = "null";
            while (action != "exit")
            {
                while (action != "deposit" & action != "withdraw" & action != "pay bills" & action != "check balance" & action != "exit")
                {
                    Console.WriteLine("Please type what you would like to do. Or type Exit to quit");
                    Console.WriteLine("Just a reminder that each transaction cost 0.75$");
                    Console.WriteLine("Deposit");
                    Console.WriteLine("Withdraw");
                    Console.WriteLine("Pay Bills");
                    Console.WriteLine("Check Balance");
                    action = Console.ReadLine().ToLower().Trim();
                    if (action != "deposit" & action != "withdraw" & action != "pay bills" & action != "check balance" & action != "exit")
                    {
                        money = money - 0.75;
                        Console.WriteLine($"Invalid input\n $-0.75\n New Balance {money}");
                    }
                }

                //Deposit
                if (action == "deposit")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    if (double.TryParse(Console.ReadLine(), out depositAmount))
                    {
                        if (depositAmount < 0)
                        {
                            depositAmount = Math.Round(depositAmount, 2);
                            money = money + depositAmount;
                            Console.WriteLine($"You have succesfully deposited {depositAmount}");
                            Console.WriteLine("Thank you for choosing Bob for your banking services");
                            money = money - 0.75;
                        }
                        else
                        {
                            money = money - 0.75;
                            Console.WriteLine($"Invalid input\n $-0.75\n New Balance {money}");
                        }
                    }
                    else
                    {
                        money = money - 0.75;
                        Console.WriteLine($"Invalid input\n $-0.75\n New Balance {money}");
                    }
                }

                //Withdraw
                else if (action == "withdraw")
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    if (double.TryParse(Console.ReadLine(), out withdrawAmount))
                    {
                        if (withdrawAmount < 0 || withdrawAmount > money - 0.75)
                        {
                            withdrawAmount = Math.Round(withdrawAmount, 2);
                            money = money - withdrawAmount;
                            Console.WriteLine($"You have succesfully withdrawn {withdrawAmount}");
                            Console.WriteLine("Thank you for choosing Bob for your banking services");
                            money = money - 0.75;
                        }
                        else
                        {
                            money = money - 0.75;
                            Console.WriteLine($"Invalid input\n $-0.75\n New Balance {money}");
                        }
                    }
                    else
                    {
                        money = money - 0.75;
                        Console.WriteLine($"Invalid input\n $-0.75\n New Balance {money}");
                    }
                }

                //Balance
                else if (action == "check balance")
                {
                    money = money - 0.75;
                    Console.WriteLine($"Current Balance is {money.ToString("C")}");
                }

                //Bills
                else if (action == "pay bills")
                {
                    Console.WriteLine($"Current bills\n Heating:{heating.ToString("C")}\n Water:{water.ToString("C")}\n Overdue HotdogEnjoyersUnited fees:{hotdog.ToString("C")}");
                    if (money >= heating + water + hotdog + 0.75)
                    {
                        Console.WriteLine("Bills subtrated\n Thank for choosing Bob for your banking services");
                        heating = 0;
                        water = 0;
                        hotdog = 0;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money to pay your bills, you should get a job");
                        money = money - 0.75;
                    }
                }
            }
            
        }

        //Parking
        static void Parking()
        {
            Console.Clear();
            int baseFee = 4, hourlyFee = 2;
            double timeParked;
            bool repeat = true;
            Console.WriteLine("Welcome to parking lots inc. Where you can stay as long as you need\n How long will you be parking? In minutes please");
            Console.WriteLine("Also if you'd like to leave simply say Exit");

            while (repeat == true)
            {
                if (Console.ReadLine().ToLower() == "exit")
                {
                    repeat = false;
                    continue;
                }
                if (double.TryParse(Console.ReadLine(), out timeParked) & timeParked >= 0)
                {
                    Console.WriteLine($"Cool, that'll be {(Math.Ceiling(timeParked / 60) * hourlyFee + baseFee).ToString("C")}");
                }
                else
                {
                    while (double.TryParse(Console.ReadLine(), out timeParked) == false || timeParked < 0)
                    {
                        Console.WriteLine("Look man I'm just trying to do my job, I don't need your riddles.\n So how long are you going to park here?");
                    }
                }
            }
        }

        //Bad Weather
        static void Hurricane()
        {
            Console.Clear();
            int hurricane;
            string windSpeedMPH, windSpeedKM, windSpeedKT;
            Console.WriteLine("Welcome to the Saffir Simpson Hurricane scale.\nPlease input your catagory of hurricane from 1-5 and we'll describe it for you.\nType Exit to quit");
            int.TryParse(Console.ReadLine(), out hurricane);
            switch (hurricane)
            {
                case 1:
                    windSpeedMPH = "74 - 95"; windSpeedKM = 0; windSpeedKT = 0;
                    Console.WriteLine("The speed of your hurricane is between " );
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                default:

                    break;

            }
        }
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.Clear();
                int num;
                Console.WriteLine("Press 1 for Bob Bank. Press 2 for Parking Garage. Or press 3 for Hurricane Catagorizer");
                int.TryParse(Console.ReadLine(), out num);
                while (num != 1 & num != 2 & num != 3)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Press 1 for Bob Bank. Press 2 for Parking Garage. Or press 3 for Hurricane Catagorizer");
                    int.TryParse(Console.ReadLine(), out num);
                }
                if (num == 1)
                    BobBank();
                else if (num == 2)
                    Parking();
                else if (num == 3)
                    Hurricane();
            }
        }
    }
}