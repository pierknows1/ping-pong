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
      Triangle.ClearAll();
    }
    
    }
  }