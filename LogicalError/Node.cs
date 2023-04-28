using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{

    /// <summary>
    /// Node holds the left and right pointer of a node
    /// Each left and right pointer is a node, meaning they hold a left and right node as well
    /// EXAMPLE:
    ///         O
    ///        / \
    ///       O   O
    ///      / \ / \
    ///     O  O O  O
    ///    / \
    /// </summary>
    public class Node
    {
        //Data is a member of the node that obtains a value
        public int Data { get; set; } = 0;

        //leftPointer is another member that holds another set of left and right pointers
        public Node leftPointer { get; set; } = null;

        //rightPointer is another member that holds another set of left and right pointers
        public Node rightPointer { get; set; } = null;

        /// <summary>
        /// Constructor that creates a node with the value that is given
        /// </summary>
        /// <param name="newData"></param>
        public Node(int newData) { this.Data = newData; }
    }
}
