
namespace Practice.Interface
{
    /// <summary>
    /// Defines the standards for a binary tree. Makes no assumptions as to what kind of
    /// binary tree implements this
    /// </summary>
    /// <typeparam name="T">Any object</typeparam>
    public class BinaryTree<T> : IBinaryTree<T>
    {
        /// <summary>
        /// Head of the tree.
        /// </summary>
        public Node<T> head = new Node<T>();
        
        /// <summary>
        /// String returned for in order traversal.
        /// </summary>
        private string str = string.Empty;
        
        /// <summary>
        /// Bool result that indicates if delete was successful or not
        /// </summary>
        private bool deleteResult = false;

        /// <summary>
        /// Adds a new element to the tree if it is not already present. Equality checks
        /// should be done using the T type's .Equals()
        /// </summary>
        /// <param name="addition">The element to add to the tree</param>
        /// <returns>Whether or not the element was actually added to the tree</returns>
        public bool Add(T addition)
		{
            return AddHelper(head, addition); 
		}

        /// <summary>
        /// Adds nodes to tree and indicates success status of addition.
        /// </summary>
        /// <param name="node">Node to be traversed or modified</param>
        /// <param name="addition">value being added</param>
        /// <returns></returns>
        private bool AddHelper(Node<T> node, T addition)
        {
            if (node.Data.Equals(addition))
            {
                return false;
            }
            if (node.Left == null)
            {
                node.Left = new Node<T>
                {
                    Data = addition
                };
                return true;
            }
            if (node.Right == null)
            {
                node.Right= new Node<T>
                {
                    Data = addition
                };
                return true;
            }
            if (node.Left != null)
            {
                return AddHelper(node.Left, addition);
            }
            if (node.Right != null)
            {
                return AddHelper(node.Right, addition);
            }

            return false; 
        }

        /// <summary>
        /// Deletes the item out of the tree if it is present. Equality checks
        /// should be done using the T type's .Equals()
        /// </summary>
        /// <param name="target">value to be deleted</param>
        /// <returns>Whether or not the element was actually deleted from the tree</returns>
        public bool Delete(T target)
        {
            deleteResult = false;
            DeleteHelper(head, target);
            return deleteResult;
        }

        /// <summary>
        /// Deletes input target by traversing the tree and setting the Data attribute to default empty value of object.
        /// </summary>
        /// <param name="node">node being modified or traversed</param>
        /// <param name="target">value being deleted</param>
        private void DeleteHelper(Node<T> node, T target)
        {
            if (node.Data.Equals(target))
            {
                node.Data = default(T);
                deleteResult = true;
            }
            if (node.Left != null)
            {
                DeleteHelper(node.Left, target);
            }
            if (node.Right != null)
            {
                DeleteHelper(node.Right, target);
            }
        }

        /// <summary>
        /// Traverses the binary tree using the In Order algorithm
        /// and generates a comma delimited list. Representing the
        /// elements as strings should be done using the T type's .ToString()
        /// A null (empty) tree should still return "[]"
        /// </summary>
        /// <returns>A comma delimited list as a string of the values, e.g. [e1, e2]</returns>
        public string InOrderTraversal()
        {
            if (head.Left == null && head.Right == null)
            {
                return "[]";
            }
            IOTraversalHelper(head);
            return "[" + str.TrimEnd(',') + "]";
        }

        /// <summary>
        /// Adds to string according to in order algorithm.
        /// </summary>
        private void IOTraversalHelper(Node<T> node)
        {
            if (node.Left != null)
            {
                IOTraversalHelper(node.Left);
            }
            str += node.Data.ToString() + ",";
            if (node.Right != null)
            {
                 IOTraversalHelper(node.Right);
            }
        }
    }
}