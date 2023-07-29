using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.BalancedParanthesis
{
    internal class StackOperation
    {
        LinkedListStack<string> linkedList = new LinkedListStack<string>();
        public void ReadFileAndPerformOperation(string filepath)
        {
            string readAllText = File.ReadAllText(filepath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                if (data.Equals("("))
                    linkedList.Push(data);
                if(data.Equals(")"))
                    linkedList.Pop();
            }
            if (linkedList.IsEmpty())
                Console.WriteLine("Balanced Paranthesis");
            else
                Console.WriteLine("Not a Balanced Paranthesis");

        }
    }
}
