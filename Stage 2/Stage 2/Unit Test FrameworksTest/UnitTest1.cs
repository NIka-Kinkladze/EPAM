using NUnit.Framework;

[TestFixture]
public class StringUtilTests
{
    [Test]
    public void MaxConsecutiveUnequalChars_WithEmptyString_ReturnsZero()
    {
        int result = StringUtil.MaxConsecutiveUnequalChars("");
        Assert.AreEqual(0, result);
    }

    [Test]
    public void MaxConsecutiveUnequalChars_WithSingleChar_ReturnsOne()
    {
        int result = StringUtil.MaxConsecutiveUnequalChars("a");
        Assert.AreEqual(1, result);
    }

    [Test]
    public void MaxConsecutiveUnequalChars_WithConsecutiveChars_ReturnsCorrectCount()
    {
        int result = StringUtil.MaxConsecutiveUnequalChars("aabbc");
        Assert.AreEqual(2, result);
    }

    [Test]
    public void MaxConsecutiveLatinLetters_WithEmptyString_ReturnsZero()
    {
        int result = StringUtil.MaxConsecutiveLatinLetters("");
        Assert.AreEqual(0, result);
    }

    [Test]
    public void MaxConsecutiveLatinLetters_WithSingleLetter_ReturnsOne()
    {
        int result = StringUtil.MaxConsecutiveLatinLetters("a");
        Assert.AreEqual(1, result);
    }

    [Test]
    public void MaxConsecutiveLatinLetters_WithConsecutiveLatinLetters_ReturnsCorrectCount()
    {
        int result = StringUtil.MaxConsecutiveLatinLetters("aabbcc");
        Assert.AreEqual(2, result);
    }

    [Test]
    public void MaxConsecutiveDigits_WithEmptyString_ReturnsZero()
    {
        int result = StringUtil.MaxConsecutiveDigits("");
        Assert.AreEqual(0, result);
    }

    [Test]
    public void MaxConsecutiveDigits_WithSingleDigit_ReturnsOne()
    {
        int result = StringUtil.MaxConsecutiveDigits("5");
        Assert.AreEqual(1, result);
    }

    [Test]
    public void MaxConsecutiveDigits_WithConsecutiveDigits_ReturnsCorrectCount()
    {
        int result = StringUtil.MaxConsecutiveDigits("112233");
        Assert.AreEqual(2, result);
    }
}
