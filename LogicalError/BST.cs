using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW1
{
    public class BST
    {
        //Public member of the Tree
        //The root is the very first Node in the tree and normally found at the peak of it
        public Node rootPtr;

        //Public member that focuses on keeping count of the number of items in the tree with no duplicates
        public int itemCount = 1;

        /// <summary>
        /// insertHelper focuses on using the value that is inserted to create a new node
        /// and insert it into the Binary Search Tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        private void insertHelper(Node treeNode, int value) {
            if(rootPtr == null) {rootPtr = new Node(value); }
            else
            {
                if(treeNode.Data < value)
                {
                    if (treeNode.rightPointer == null) {
                        treeNode.rightPointer = new Node(value);
                        itemCount++;
                    
                    }
                    else { insertHelper(treeNode.rightPointer, value); }
                    
                }
                else if (value < treeNode.Data)
                {
                    if(treeNode.leftPointer == null) {
                        treeNode.leftPointer = new Node(value);
                        itemCount++;
                    }
                    else { insertHelper(treeNode.leftPointer,value); }
                    
                }
                else { Console.Write("Duplicate, tree again"); }
            }

        }
        /// <summary>
        /// Displays the Tree from Lowest number to the greatest aka in order Traversal
        /// </summary>
        /// <param name="tree"></param>
        private void displayTreeHelper(Node tree) { 
            if(tree != null)
            {
                displayTreeHelper(tree.leftPointer);
                Console.Write(" " + tree.Data);
                displayTreeHelper(tree.rightPointer);
            }
        }

        /// <summary>
        /// Counts the number of levels within the tree aka the height of the tree
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        private int levelCountHelper(Node tree)
        {
            int count = 0;
            if (tree != null) { count = Math.Max(levelCountHelper(tree.leftPointer), levelCountHelper(tree.rightPointer)); }
            return count;
        }

      
        /// <summary>
        /// Constructor for the Binary Search Tree, sets the root pointer to null
        /// </summary>
        public BST() { this.rootPtr = null; }

        /// <summary>
        /// Insert calls for the private function of insertHelper which does all the work
        /// on inserting the value into the tree
        /// </summary>
        /// <param name="value"></param>
        public void insert(int value) {
            insertHelper(this.rootPtr, value);
            
        }

        /// <summary>
        /// Calls the display helper
        /// </summary>
        public void display() { displayTreeHelper(this.rootPtr); }

        /// <summary>
        /// Functions returns the total count of items within the tree
        /// </summary>
        /// <returns></returns>
        public int itemCountFunction() {
            return itemCount;
        }

        /// <summary>
        /// level Count calls the levelCountHelper function which calculates the levels
        /// </summary>
        /// <returns></returns>
        public int levelCount() { return levelCountHelper(this.rootPtr); }

        /// <summary>
        /// minimum Level count focuses on counting the minimum of levels it could take if the items were balanced on both sides
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public int minLevelCount()
        {
            if (itemCount == 1) { return 1; }
            else if (itemCount > 1 && itemCount < 3) { return 1; }
            else if (itemCount > 3 && itemCount < 8) { return 2; }
            else if (itemCount > 7 && itemCount < 15) { return 3; }
            else if (itemCount > 14 && itemCount < 30) { return 4; }
            else if (itemCount > 29 && itemCount < 60) { return 5; }
            else if (itemCount > 59) { return 6; }
            else
            {
                return 0;
            }
        }

    }
}
