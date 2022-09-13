using NUnit.Framework;

namespace Credit_Card_Mask;

[TestFixture]
public class Test
{
    [Test]
    public void test1() 
    {
        Assert.AreEqual(1,Kata.RowSumOddNumbers(1));
        Assert.AreEqual(74088,Kata.RowSumOddNumbers(42));
    }
}