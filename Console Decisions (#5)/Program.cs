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
                        Console.WriteLine($"Invalid input\n$-0.75\nNew Balance {money}");
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
                            Console.WriteLine($"Invalid input\n$-0.75\nNew Balance {money}");
                        }
                    }
                    else
                    {
                        money = money - 0.75;
                        Console.WriteLine($"Invalid input\n$-0.75\nNew Balance {money}");
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
                            Console.WriteLine($"Invalid input\n$-0.75\nNew Balance {money}");
                        }
                    }
                    else
                    {
                        money = money - 0.75;
                        Console.WriteLine($"Invalid input\n$-0.75\nNew Balance {money}");
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
                    Console.WriteLine($"Current bills\n Heating:{heating.ToString("C")}\n Water:{water.ToString("C")}\nOverdue HotdogEnjoyersUnited fees:{hotdog.ToString("C")}");
                    if (money >= heating + water + hotdog + 0.75)
                    {
                        Console.WriteLine("Bills subtrated\nThank for choosing Bob for your banking services");
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
            int baseFee = 2, hourlyFee = 2;
            double timeParked, cost = 0;
            bool repeat = true;
            Console.WriteLine("Welcome to parking lots inc. Where you can stay as long as you need\nHow long will you be parking? In minutes please");
            Console.WriteLine("Also if you'd like to leave simply say Exit");

            while (repeat == true)
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "exit")
                {
                    repeat = false;
                    continue;
                }
                else if (double.TryParse(userInput, out timeParked) & timeParked >= 0)
                {
                    cost = Math.Ceiling(timeParked / 60) * hourlyFee + baseFee;
                    if (cost > 20)
                        cost = 20;
                    Console.WriteLine($"Cool, that'll be {cost.ToString("C")}");
                }
                else
                {
                    while (double.TryParse(userInput, out timeParked) == false || timeParked < 0)
                    {
                        Console.WriteLine("Look man I'm just trying to do my job, I don't need your riddles.\nSo how long are you going to park here?");
                        userInput = Console.ReadLine();
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
            while (!int.TryParse(Console.ReadLine(), out hurricane))
            {
                switch (hurricane)
                {
                    case 1:
                        Console.WriteLine("The speed of your hurricane is between 74-96 Mph, 119-153 Km, or 64-82 Kt");
                        break;
                    case 2:
                        Console.WriteLine("The speed of your hurricane is between 96-110 Mph, 154-177 Km, or 83-95 Kt");
                        break;
                    case 3:
                        Console.WriteLine("The speed of your hurricane is between 111-130 Mph, 178-209 Km, or 96-113 Kt");
                        break;
                    case 4:
                        Console.WriteLine("The speed of your hurricane is between 131-155 Mph, 210-249 Km, or 114-135 Kt");
                        break;
                    case 5:
                        Console.WriteLine("The speed of your hurricane is between 155+ Mph, 249+ Km, or 135+ Kt");
                        break;
                    case < 1:
                        Console.WriteLine("Invalid Input. Please Make sure your number is between 1-5");
                        int.TryParse(Console.ReadLine(), out hurricane);
                        break;
                    case > 5:
                        Console.WriteLine("Invalid Input. Please Make sure your number is between 1-5");
                        int.TryParse(Console.ReadLine(), out hurricane);
                        break;
                }
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