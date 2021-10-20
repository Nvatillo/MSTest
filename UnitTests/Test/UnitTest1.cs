
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UnitTests.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Sum Values Test
        /// </summary>
        [TestMethod]
        public void SumValues()
        {
            /// AAA

            ///Arrange
            ApplicationCoreP.Services.Sum suma = new ApplicationCoreP.Services.Sum();
            ///Act
            var result = suma.SumValues(5, 2);
            ///Assert
            Assert.AreEqual(7, result);
        }
    }
}