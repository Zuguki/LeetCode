using NUnit.Framework;

namespace Credit_Card_Mask;

[TestFixture]
public class Tests
{
    [Test]
    public void TestToRoman_001()
    {
        int input = 1;
        string expected = "I";

        string actual = RomanNumerals.ToRoman(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestToRoman_002()
    {
        int input = 2;
        string expected = "II";

        string actual = RomanNumerals.ToRoman(input);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void TestToRoman_003()
    {
        int input = 4;
        string expected = "IV";

        string actual = RomanNumerals.ToRoman(input);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void TestToRoman_004()
    {
        int input = 1270;
        string expected = "MCCLXX";

        string actual = RomanNumerals.ToRoman(input);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void TestToRoman_005()
    {
        int input = 9;
        string expected = "IX";

        string actual = RomanNumerals.ToRoman(input);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void TestToRoman_006()
    {
        int input = 3938;
        string expected = "MMMCMXXXVIII";

        string actual = RomanNumerals.ToRoman(input);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void TestToRoman_007()
    {
        int input = 3398;
        string expected = "MMMCCCXCVIII";

        string actual = RomanNumerals.ToRoman(input);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void TestToRoman_008()
    {
        int input = 92;
        string expected = "XCII";

        string actual = RomanNumerals.ToRoman(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestFromRoman_001()
    {
        string input = "I";
        int expected = 1;

        int actual = RomanNumerals.FromRoman(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestFromRoman_002()
    {
        string input = "II";
        int expected = 2;

        int actual = RomanNumerals.FromRoman(input);

        Assert.AreEqual(expected, actual);
    }
}