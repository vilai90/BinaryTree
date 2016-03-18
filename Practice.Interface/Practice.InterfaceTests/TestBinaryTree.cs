using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Interface;

namespace Practice.Test
{
    /// <summary>
    /// Unit tests the various functions of <Concrete Binary Tree type name goes here>
    /// </summary>
    [TestClass]
    public class TestBinaryTree
    {
        private IBinaryTree<Int32> _mock;

        [TestInitialize]
        public void TestInit()
        {
            _mock = new BinaryTree<Int32>(); // TODO set this to an instance of the Concrete type
        }

        [TestMethod]
        public void TestAdd()
        {
            // Arrange (TODO add a few test integers)
            int[] integerArray = new int[] { 1, 3, 5, 10, 12, 7 };

            // Act (TODO more additions to cover all cases)
            foreach (int number in integerArray)
            {
                // Assert (TODO)
                bool additionSuccess = _mock.Add(number);
                Assert.IsTrue(additionSuccess, "number wasn't successfully added");
            }

            // Assert (TODO)
            bool additionFailure = _mock.Add(1);
            Assert.IsFalse(additionFailure, "number was added");
        }

        [TestMethod]
        public void TestDelete()
        {
            // Arrange (TODO add a few test integers)
            int[] integerArray = new int[] { 1, 3, 5, 10, 12, 7 };
            
            foreach (int number in integerArray)
            {
                // Assert (TODO)
                bool additionSuccess = _mock.Add(number);
                Assert.IsTrue(additionSuccess, "number wasn't successfully added");
            }

            // Act (TODO add more deletions to cover all cases)
            foreach (int number in integerArray)
            {
                // Assert (TODO)
                bool deletionSuccess = _mock.Delete(number);
                Assert.IsTrue(deletionSuccess, "number wasn't successfully deleted");
            }

            // Assert (TODO)
            bool deletionFailure = _mock.Delete(6);
            Assert.IsFalse(deletionFailure, "number was somehow deleted");
        }

        [TestMethod]
        public void TestInOrderTravesal()
        {
            // Assert (TODO)
            string emptyResult = _mock.InOrderTraversal();
            Assert.IsTrue(emptyResult == "[]", "tree not empty");

            // Arrange (TODO add a few test integers)
            int[] integerArray = new int[] { 1, 3, 5, 10, 12, 7 };
            
            foreach (int number in integerArray)
            {
                // Assert (TODO)
                bool additionSuccess = _mock.Add(number);
                Assert.IsTrue(additionSuccess, "number wasn't successfully added");
            }

            // Assert (TODO)
            string result = _mock.InOrderTraversal();
            Assert.IsTrue(result == "[12,5,7,1,10,0,3]");
        }
    }
}