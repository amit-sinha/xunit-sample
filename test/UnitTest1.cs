using System;
using Xunit;
using impl;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var actual = Program.Add(1, 2);
            Assert.Equal(3, actual);
        }
    }
}
