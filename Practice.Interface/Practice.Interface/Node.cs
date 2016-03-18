
namespace Practice.Interface
{
    /// <summary>
    /// Class representing node object.
    /// </summary>
    /// <typeparam name="T">any type of object</typeparam>
    public class Node<T>
    {
        private T data;
        public Node<T> Left, Right;

        public T Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}
