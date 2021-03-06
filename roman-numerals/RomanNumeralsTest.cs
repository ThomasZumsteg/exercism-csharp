using NUnit.Framework;

[TestFixture]
public class RomanNumeralsTest
{
    // Change 'Ignore = true' to 'Ignore = false' to run a test case.
    // You can also just remove 'Ignore = true'.

    [TestCase(0, ExpectedResult = "")]
    [TestCase(1, ExpectedResult = "I")]
    [TestCase(2, ExpectedResult = "II")]
    [TestCase(3, ExpectedResult = "III")]
    [TestCase(4, ExpectedResult = "IV")]
    [TestCase(5, ExpectedResult = "V")]
    [TestCase(6, ExpectedResult = "VI")]
    [TestCase(9, ExpectedResult = "IX")]
    [TestCase(27, ExpectedResult = "XXVII")]
    [TestCase(48, ExpectedResult = "XLVIII")]
    [TestCase(59, ExpectedResult = "LIX")]
    [TestCase(93, ExpectedResult = "XCIII")]
    [TestCase(141, ExpectedResult = "CXLI")]
    [TestCase(163, ExpectedResult = "CLXIII")]
    [TestCase(402, ExpectedResult = "CDII")]
    [TestCase(575, ExpectedResult = "DLXXV")]
    [TestCase(911, ExpectedResult = "CMXI")]
    [TestCase(1024, ExpectedResult = "MXXIV")]
    [TestCase(3000, ExpectedResult = "MMM")]
    public string Convert_roman_to_arabic_numerals(int arabicNumeral)
    {
        return arabicNumeral.ToRoman();
    }
}