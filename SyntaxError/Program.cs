using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration of the tree
            BST tree = new BST();

            //userInput will collect a string of numbers that the user wants to add into the Binary Search Tree
            Console.WriteLine("Enter a Collection of Numbers in the Range [0, 100], separated by spaces: \n");
            string userInput = Console.ReadLine();
            string[] splitFunction = userInput.Split();

            //Converting the string input from userInput into an integer
            //After that we are assigning the integers into collectionNumber
            int[]collectionNum = Array.ConvertAll(splitFunction, int.Parse);

            //Now we are inserting the array of collectionNumber into the Binary Search Tree
            int i = 0;
            while(collectionNum.Length != i) {
                tree.insert(collectionNum[i]);
                i++;
            }
            Console.WriteLine("Tree Contents: ");
            tree.display();
            Console.WriteLine("\nTree Statistics: ");

            int nodeCount = tree.itemCountFunction();
            Console.WriteLine("  Number of Nodes: " + nodeCount);

            int levelCount = tree.levelCount();
            Console.WriteLine("  Number of Levels: " + levelCount);

            int minLevel = tree.minLevelCount();
            Console.WriteLine("Minimum Number of Levels that a Tree with " + nodeCount);
            Console.WriteLine("nodes could have = "+ minLevel);

            Console.WriteLine("Done");

        }
    }
}
