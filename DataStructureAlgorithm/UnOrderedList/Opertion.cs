using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.UnOrderedList
{
    public class Opertion
    {
         LinkedList<string> linkedList = new LinkedList<string>();
        public void ReadFileAndPerformOperation(string filepath)
        {
            string readAllText = File.ReadAllText(filepath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                linkedList.Add(data);
            }
            Console.WriteLine("Before Text:");
            linkedList.Display();
            Console.WriteLine("\nEnter a number to search");
            string input = Console.ReadLine();
            int position = linkedList.Search(input);
            if(position == -1)
            {
                linkedList.Add(input);
            }
            else
            {
                linkedList.DeleteNodeAtParticularPosition(position);
            }
            Console.WriteLine("\nAfter Text:");
            linkedList.Display();
        }
    }
}
