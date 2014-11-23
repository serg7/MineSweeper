using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Miner;

namespace MinerUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckUniqueMinerInstance()
        {
            Assert.AreEqual(Game.Instance, Game.Instance);
        }
    }
}
