using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args){
        // Create an empty List of type object    
            var boxing = new List<object>();
        // Add the following values to the list: 7, 28, -1, true, "chair"    
            boxing.Add(7);
            boxing.Add(28);
            boxing.Add(-1);
            boxing.Add(true);
            boxing.Add("chair");
            Console.WriteLine($"We have {boxing.Count} items in our list.");
        // Loop through the list and print all values 
            int sum = 0;
            foreach(var item in boxing){
                Console.WriteLine(item);
        // Add all values that are Int type together and output the sum
                if(item is int){
                    sum += (int)item;
                }
            }
            Console.WriteLine($"Current sum: {sum}");    
        }
    }
}
