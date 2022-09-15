using NUnit.Framework;

namespace Credit_Card_Mask;

[TestFixture]
public class Tests
{
    [Test]
    public void ASimpleKataTest()
    {
        Assert.AreEqual("110", Kata.Add("91", "19"));
        Assert.AreEqual("1111111111", Kata.Add("123456789", "987654322"));
        Assert.AreEqual("1000000000", Kata.Add("999999999", "1"));
    }
}