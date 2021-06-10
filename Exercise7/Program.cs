using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {

            int pinNum;
            Console.WriteLine("Enter Your Pin Number");
            pinNum = Convert.ToInt32(Console.ReadLine());

            User user = new User(123, "guohua");
            Bank bank = new Bank(user);
            if (pinNum == user.GetpinNum())
            {

   
                bool isFlag = true;
                while (isFlag)
                {

                    Console.WriteLine("******** Welcome To ATM Service " + user.GetName() + " *********\n");

                    Console.WriteLine("1. Check Balance\n");
                    Console.WriteLine("2. Withdraw Cash\n");
                    Console.WriteLine("3. Deposit Cash\n");
                    Console.WriteLine("4. Quit");
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("Enter Your Choice (1-4):");

                    int selection = Utility.readmenuSelection();
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("You Balance is : " + user.GetBalance());
                            break;
                        case 2:
                            Console.WriteLine("Withdraw Cash: ");
                            int lessmoney = Utility.readNumber();
                            // handle user.GetBalance()
                            if (user.GetBalance() >= lessmoney)
                            {
                                user.Withdraw(lessmoney);
                            }
                            else
                            {
                                Console.WriteLine("no enough money! Withdraw failed");
                            }
                            Console.WriteLine("Withdraw " + lessmoney + " finished !, You Balance is "+ user.GetBalance());
                            break;
                        case 3:
                            Console.WriteLine("Deposit Cash: ");
                            int moremoney = Utility.readNumber();

                            // handle user.GetBalance()
                            user.Deposit( moremoney);
                            Console.WriteLine("Deposit" + moremoney + " finished !,You Balance is " + user.GetBalance());

                            break;
                        case 4:
                            Console.WriteLine("confirm exit(Y/N): ");
                            char isExit = Utility.readConfirmSelection();
                            if (isExit == 'Y')
                            {
                                isFlag = false;
                            }

                            break;

                    }


                }
            }
            else
            {
                Console.WriteLine("your pin number is wrong, exit");
            }
        }
    }
}
