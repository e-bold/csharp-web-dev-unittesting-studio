namespace BalancedBracketsTests;
using BalancedBrackets;



[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.

    [TestMethod]
    public void OnlyBracketsReturnsTrue()
    {
        string testData = "[]";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "A single pair of balanced brackets returns true";
        Assert.IsTrue(actualResult, message);
    }

    [TestMethod]
    public void DoublePairOfBracketsReturnsTrue(){
        string testData2 = "[[]]";
        bool actualResult2 = BalancedBrackets.HasBalancedBrackets(testData2);
        string message2 = "A double pair of balanced brackets returns true";
        Assert.IsTrue(actualResult2, message2);
    }

    [TestMethod]
    public void SingleBracketReturnsFalse(){
        string testData3 = "[";
        bool actualResult3 = BalancedBrackets.HasBalancedBrackets(testData3);
        string message3 = "A single bracket returns false";
        Assert.IsFalse(actualResult3, message3);
    }

    [TestMethod]
    public void InvertedBracketsReturnsFalse(){
        string testData4 = "][";
        bool actualResult4 = BalancedBrackets.HasBalancedBrackets(testData4);
        string message4 = "A pair of inverted brackets returns false";
        Assert.IsTrue(actualResult4, message4);
    }
    

}
