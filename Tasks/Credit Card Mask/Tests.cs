using NUnit.Framework;

namespace Credit_Card_Mask;

[TestFixture]
public class Test
{
    [Test]
    public void Test1()
    {
        StringAssert.AreEqualIgnoringCase("loquen", Kata.Remove_char("eloquent"));
        StringAssert.AreEqualIgnoringCase("ountr", Kata.Remove_char("country"));
        StringAssert.AreEqualIgnoringCase("erso", Kata.Remove_char("person"));
        StringAssert.AreEqualIgnoringCase("lac", Kata.Remove_char("place"));
        StringAssert.AreEqualIgnoringCase("", Kata.Remove_char("ok"));
    }
}