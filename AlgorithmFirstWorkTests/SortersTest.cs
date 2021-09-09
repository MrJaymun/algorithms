using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmFirstWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFirstWork.Tests
{
    [TestClass()]
    public class SortersTest
    {
        [TestMethod()]
        public void BubbleTest()
        {
            BubbleSorter bubbleSorter = new BubbleSorter();
            int[] test = new int[] { 3, -5, 7, 0 };
            int[] finished = bubbleSorter.Sort(test);
            Assert.AreEqual(finished[0], -5);
        }
        [TestMethod()]
        public void InsertTest()
        {
            InsertSorter insertSorter = new InsertSorter();
            int[] test = new int[] { 3, -5, 7, 0 };
            int[] finished = insertSorter.Sort(test);
            Assert.AreEqual(finished[1], 0);
        }
        [TestMethod()]
        public void MergeTest()
        {
            MergeSorter mergeSorter= new MergeSorter();
            int[] test = new int[] { 3, -5, 7, 0 };
            int[] finished = mergeSorter.Sort(test);
            Assert.AreEqual(finished[2], 3);
        }
        [TestMethod()]
        public void SelectionTest()
        {
            SelectionSorter selectionSorter = new SelectionSorter();
            int[] test = new int[] { 3, -5, 7, 0 };
            int[] finished = selectionSorter.Sort(test);
            Assert.AreEqual(finished[3], 7);
        }
    }
}