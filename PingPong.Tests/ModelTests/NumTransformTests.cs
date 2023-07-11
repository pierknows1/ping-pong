using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;
using System.Collections.Generic;
using System;

namespace PingPong.Tests
{
  [TestClass]
  public class NumTransformTests : IDisposable
  {
    public void Dispose()
    {
      NumTransform.ClearAll();
    }
    [TestMethod]

    public void
    Output_ReturnsUserNumWithPingPong()
    {
        int userNum = 3;
        NumTransform newNumTransform = new NumTransform (userNum);

        int result = newNumTransform.userNum;
        Assert.AreEqual(userNum, result);

    }
    
    }

  }