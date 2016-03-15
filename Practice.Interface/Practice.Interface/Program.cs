using System;

namespace Practice.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<Int32> test = new BinaryTree<Int32>();
            test.head.Data = 4;
            test.Add(0);
            test.Delete(0);
            Console.Write(test.InOrderTraversal());
        }
    }
}
