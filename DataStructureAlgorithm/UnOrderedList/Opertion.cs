using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.UnOrderedList
{
    public class Opertion
    {
        public void ReadFileAndPerformOperation(string filepath)
        {
            LinkedList<string> list = new LinkedList<string>();
            string readAllText = File.ReadAllText(filepath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                list.Add(data);
            }
            Console.WriteLine("Before Text:");
            list.Display();
            Console.WriteLine("\nEnter the string to input else delete");
            string input = Console.ReadLine();
            list.Operation(input);
            Console.WriteLine("\nAfter Text:");
            list.Display();
        }
    }
}
