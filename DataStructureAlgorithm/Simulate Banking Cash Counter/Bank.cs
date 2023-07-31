using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureAlgorithm.UnOrderedList;
using static DataStructureAlgorithm.Simulate_Banking_Cash_Counter.QueueList;

namespace DataStructureAlgorithm.Simulate_Banking_Cash_Counter
{
    public class Bank
    {
        Queuelist<string> queue = new Queuelist<string>();
        int amount;
        public void Balance(int amount)
        {
            this.amount = amount;
        }

        public void AddPersonsInQueue()
        {
            Console.WriteLine("Enter num of persons in Queue");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter your Name");
                queue.Enqueue(Console.ReadLine());
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Choose an option to proceed \n1. WithDraw\n2. Deposit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            WithDraw();
                            break;
                        case 2:
                            Deposit();
                            break;
                        case 3:
                            DisplayAmountInATM();
                            break;
                    }
                    queue.Dequeue();
                    flag = false;
                }
            }
        }
        private void DisplayAmountInATM()
        {
            Console.WriteLine("Your balance is " + amount + " Rupees");
        }



        private void Deposit()
        {
            Console.WriteLine("Enter amount to Deposit");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            amount += depositAmount;
            DisplayAmountInATM();
        }



        public void WithDraw()
        {
            Console.WriteLine("Enter amount to withdraw");
            int withDrawAmount = Convert.ToInt32(Console.ReadLine());
            if (withDrawAmount <= amount)
                amount -= withDrawAmount;
            else
            {
                Console.WriteLine("Insufficient Amount.. Please try again later");
                WithDraw();
            }
            DisplayAmountInATM();

        }
    }
}

