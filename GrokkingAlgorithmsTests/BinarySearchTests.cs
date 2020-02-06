using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrokkingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void TryGetResultTest()
        {
            //Arrange
            
            List<int> list = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(i);
            }
            var binsearch = new BinarySearch<int>(list,list.Last());
            //Act
            binsearch.TryGetResult(list,list.Last());
            //Assert

        }
    }
}