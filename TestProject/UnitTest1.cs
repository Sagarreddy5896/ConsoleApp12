using Xunit;
using System;
using Lengthstring;


namespace TestProject
{
    public class UnitTest1
    {
        Lengthhelper helpher = new Lengthhelper();


        [Fact]
        public void Test1()
        {
            Assert.Equal(3, helpher.findlength("123"));
        }

        [Fact]

        public void Test2()
        {
            Assert.Equal(12, helpher.findlength("123456789010"));
        }
    }
}