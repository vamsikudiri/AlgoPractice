using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    /// <summary>
    /// Generic binary tree node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTreeNode<T> : Data
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryTreeNode{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public BinaryTreeNode(T data)
            : base()
        {
            Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryTreeNode{T}"/> class.
        /// </summary>
        public BinaryTreeNode()
        {

        }

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
        /// Gets or sets the left.
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        public BinaryTreeNode<T> Left
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the right.
        /// </summary>
        /// <value>
        /// The right.
        /// </value>
        public BinaryTreeNode<T> Right
        {
            get;
            set;
        }

        /// <summary>
        /// Reads from string.
        /// index,data; so on... index root node index should be 1.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputTree">The input tree.</param>
        /// <returns></returns>
        public static BinaryTreeNode<T> ReadFromString<T>(string inputTree)
        {
            BinaryTreeNode<T> rootNode = null;

            string[] nodeStrings = inputTree.Split(Constants.SEPARATOR_BETWEEN_TREE_NODES);

            if (nodeStrings.Length > 0)
            {
                Dictionary<UInt32, BinaryTreeNode<T>> treeDetails = new Dictionary<UInt32, BinaryTreeNode<T>>();
                string[] nodeDetails;
                UInt32 index = 0;
                T data = default(T);

                if (treeDetails.Keys.Contains((UInt32)0))
                {
                    rootNode = treeDetails[0];
                }

                foreach (string node in nodeStrings)
                {
                    nodeDetails = node.Split(Constants.SEPARATOR_IN_TREE_NODES);
                    index = UInt32.Parse(nodeDetails[0]);
                    data = Helper.ConvertFromString<T>(nodeDetails[1]);
                    treeDetails[index] = new BinaryTreeNode<T>(data);
                }

                foreach (KeyValuePair<UInt32, BinaryTreeNode<T>> node in treeDetails)
                {
                    if (treeDetails.Keys.Contains(node.Key * 2))
                    {
                        node.Value.Left = treeDetails[node.Key * 2];
                    }
                    if (treeDetails.Keys.Contains(node.Key * 2 + 1))
                    {
                        node.Value.Right = treeDetails[node.Key * 2 + 1];
                    }
                }

                return rootNode;

            }

            return rootNode;
        }
    }
}
