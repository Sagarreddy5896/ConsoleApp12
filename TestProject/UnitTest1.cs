using Xunit;
using System;
using Lengthstring;


namespace TestProject
{
    public class UnitTest1
    {
        Lengthhelper sl = new Lengthhelper();


        [Fact]
        public void Test()
        {
            Assert.Equal(3, sl.findlength("123"));
        }

        [Fact]

        public void Test1()
        {
            Assert.Equal(12, sl.findlength("123456789010"));
        }
    }
}