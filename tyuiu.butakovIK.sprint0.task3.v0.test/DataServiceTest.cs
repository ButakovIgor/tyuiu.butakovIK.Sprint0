﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.butakovIK.sprint0.task3.v0.lib;

namespace tyuiu.butakovIK.sprint0.task3.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
