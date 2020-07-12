using System;
using System.Collections.Generic;
namespace collections_practice
{
    class Program
    {
        static void Main(string[] args){
            //Arrays
            //Create an array to hold integer values 0 through 9

            // int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            // for(int idx = 0; idx<numArray.Length;idx++){
            // Console.WriteLine(numArray[idx]);
            // }

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"

            // string[] nameArray = new string [] {"Tim","Martin", "Nikki","Sara"};
            // foreach(string name in nameArray){
            //     Console.WriteLine(name);
            // }

            //Create an array of length 10 that alternates between true and false values, starting with true

            // bool[] boolies = new bool[10];
            // for(var i = 0; i < boolies.Length; i++){
            //     boolies[i] = i % 2 == 0;
            //     Console.WriteLine(boolies[i]);
            // }

            //List
            //Create a list of ice cream flavors that holds at least 5 different flavors

            // List<string> icecream = new List<string>();
            // icecream.Add("Chocolate");
            // icecream.Add("Vanilla");
            // icecream.Add("Coffee");
            // icecream.Add("Mint");
            // icecream.Add("Strawberry");

            //Output the length of this list after building it
            // Console.WriteLine($"We currently have {icecream.Count} flavors in stock!");

            //Output the third flavor in the list, then remove this value
            // Console.WriteLine(icecream[2]);
            // icecream.Remove("Coffee");
            // Console.WriteLine(icecream[2]);

            //Output the new length of the list (It should just be one fewer!)

            // Console.WriteLine($"Now we currently have {icecream.Count} flavors");

            //Dictonaries
            //Create a dictionary that will store both string keys as well as string values

            // Dictionary<string,string> friends = new Dictionary<string,string>();

            /*
            Add key/value pairs to this dictionary where:
            each key is a name from your names array
            each value is a randomly select a flavor from your flavors list.
            */

            // friends.Add("Tim","Chocolate");
            // friends.Add("Martin","Mint");
            // friends.Add("Nikki","Vanilla");
            // friends.Add("Sara","Strawberry");

            //Loop through the dictionary and print out each user's name and their associated ice cream flavor

            // foreach(var entry in friends){
            //     Console.WriteLine(entry.Key + " - " + entry.Value);
            // }

        }
    }
}
