using NUnit.Framework;

namespace Credit_Card_Mask;

[TestFixture]
public class Test
{
    [Test]
    public void Testik()
    {
        Assert.AreEqual(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
    }
}