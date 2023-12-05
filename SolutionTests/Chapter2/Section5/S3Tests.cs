using Solutions.Chapter2.Section5;

namespace SolutionTests.Chapter2.Section5;

[TestClass]
public class S3Tests
{
    [TestMethod]
    public void TestDeDup()
    {
        var actual = S3.DeDuplicate(new List<string>{
            "apple", "pear", "kiwi", "peach", "apple", "kiwi", "berry"
        });

        var expected = new List<string>{
            "apple", "berry", "kiwi", "peach", "pear"
        };

        CollectionAssert.AreEqual(expected, actual);
    }
}