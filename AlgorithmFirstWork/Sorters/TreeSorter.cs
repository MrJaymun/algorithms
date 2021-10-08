using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFirstWork
{
    class TreeSorter : ISorter
    {
        public int[] Sort(int[] unsorted)
        {

            var treeNode = new TreeNode(unsorted[0]);
            /*
            foreach (var item in unsorted)
            {
                treeNode.Insert(new TreeNode(item));
            }
            */
            
            for (int i = 1; i < unsorted.Length; i++)
            {
                Console.WriteLine(i);
                treeNode.Insert(new TreeNode(unsorted[i]));
            }
            

            return treeNode.Transform();
        }
    }
    public class TreeNode
    {
        public TreeNode(int data)
        {
            this.data = data;
        
        }

        public int data;
        public TreeNode left;
        public TreeNode right;

        public void Insert(TreeNode node)
        {
            if (node.data < data)
            {
                if (left == null)
                {
                    left = node;
                }
                else
                {
                    left.Insert(node);
                }
            }
            else
            {
                if (right == null)
                {
                    right = node;
                }
                else
                {
                    right.Insert(node);
                }
            }
        }
 
        public int[] Transform(List<int> elements = null)
        {
            if (elements == null)
            {
                elements = new List<int>();
            }

            if (left != null)
            {
                left.Transform(elements);
            }

            elements.Add(data);

            if (right != null)
            {
                right.Transform(elements);
            }

            return elements.ToArray();
        }
    }
}
