// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using PingPong.Models;
// using System.Collections.Generic;
// using System;

// namespace PingPong.Tests
// {
//   [TestClass]
//   public class NumTransformTests  //: IDisposable
//   {
//    // public void Dispose()
//    // {
//    //   NumTransform.ClearAll();
//   //  }
//     [TestMethod]

//     public void
//     Output_ReturnsUserNumWithPingPong()
//     {
//         int userNum = 3;
//         NumTransform newNumTransform = new NumTransform();

//         int result = newNumTransform.userNum;
//         Assert.AreEqual(userNum.ToString(), result);

//     }

//     }

//   }


using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;

namespace PingPong.Tests
{
    [TestClass]
    public class NumTransformTests
    {
        [TestMethod]
        public void Output_ReturnsUserNumWithPingPong()
        {
            int userNum = 2;
            NumTransform newNumTransform = new NumTransform(userNum) { UserNum = userNum };

            string result = newNumTransform.Output();

            Assert.AreEqual(userNum.ToString(), result);
        }

        [TestMethod]
        public void Output_ReturnsUserNum3WithPing()
        {
            string OutputString = "ping";
            NumTransform newNumTransform = new NumTransform(3);

            string result = newNumTransform.Output();

            Assert.AreEqual(OutputString, result);
        }
        [TestMethod]
        public void Output_ReturnsUserNum5WithPong()
        {
            string OutputString = "pong";
            NumTransform newNumTransform = new NumTransform(5);

            string result = newNumTransform.Output();

            Assert.AreEqual(OutputString, result);
        }
        [TestMethod]
        public void Output_ReturnsUserNum15WithPingPong()
        {
            string OutputString = "ping pong";
            NumTransform newNumTransform = new NumTransform(15);

            string result = newNumTransform.Output();

            Assert.AreEqual(OutputString, result);
        }
    }
}