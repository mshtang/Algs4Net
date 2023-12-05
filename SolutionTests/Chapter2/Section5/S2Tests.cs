using Solutions.Chapter2.Section5;

namespace SolutionTests.Chapter2.Section5;

[TestClass]
public class S2Tests
{
    [TestMethod]
    public void TestFindCompoundWords()
    {
        var actualRes = S2.FindCompoundWords(new List<string>{
            "abc", "afterthought", "us", "great", "thought", "word", "compound", "find",
            "compoundword", "after", "well", "wellthought", "happy", "happyus"
        });
        var expected = new List<string> { "compoundword", "wellthought", "afterthought", "happyus" };

        CollectionAssert.AreEquivalent(expected, actualRes);
    }
}