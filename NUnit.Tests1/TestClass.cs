using NUnit.Framework;
using static Task.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    /// <summary>
    /// Test class checks results of MergeSort
    /// </summary>
    [TestFixture]
    public class TestClass
    {
        /// <summary>
        /// void method with no parameters
        /// </summary>
        [Test]
        public void Sorting_SortArray()
        {
            int[] test_arr1 = { 3, 1, 56, 87, 0, 19, 54 };
            int[] test_arr2 = { 3, 1, 56, 87, 0, 19, 54 };
            Array.Sort(test_arr1);
            Sorting(test_arr2);
            CollectionAssert.AreEqual(test_arr1, test_arr2);
        }

        [TestCase(null)]
        public void Sorting_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => Sorting(array));
        }
    }
}
