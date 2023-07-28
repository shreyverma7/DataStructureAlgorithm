using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.OrderedList
{
    public class OrderedListOperation
    {
        public void ReadFileAndPerformOperation(string filepath)
        {
            OrderedList list = new OrderedList();
            string readAllText = File.ReadAllText(filepath);
            string[] words = readAllText.Split(",");
            foreach (var data in words)
            {
                list.Add(Convert.ToInt32(data));
            }
            Console.WriteLine("Before Text:");
            list.Display(words.Length);
            Console.WriteLine("\nAfter Text:");
            list.Operation(90, words.Length);
        }
    }
}
