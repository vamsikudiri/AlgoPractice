using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    /// <summary>
    /// Generic node, it can be used as N array tree node or graphic node.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T> : Data
    {
        #region Fields
        private List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
        #endregion Fields

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public T Data
        {
            get;
            set;
        }


        /// <summary>
        /// Gets the nodes.
        /// </summary>
        /// <value>
        /// The nodes.
        /// </value>
        public List<BinaryTreeNode<T>> Nodes
        {
            get
            {
                return nodes;
            }
        }


    }
}
