﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void ReturnTypeTest()
        {
            Item item = new Item((decimal)3.50,"a1","Crunch Crunch, Yum!");
            Assert.AreEqual("Crunch Crunch, Yum!", item.GetType());
        }

        [TestMethod]
        public void GetProductNameTest()
        {
            Item item = new Item((decimal)3.50,"a1","Crunch Crunch, Yum!");
            Assert.AreEqual("a1", item.GetProductName());
        }

        [TestMethod]
        public void GetCostTests()
        {
            Item item = new Item((decimal)3.50,"a1","Crunch Crunch, Yum!");
            Assert.AreEqual((decimal)3.50, item.GetCost());
        }
    }
}