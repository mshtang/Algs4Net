using Solutions.Chapter2.Section0;
using Solutions.Utils;

namespace SolutionTests.Chapter2.Section0;

[TestClass]
public class MultiwayTests
{
    [TestMethod]
    public void TestMultiway()
    {
        var stream1 = new TextInput(@"../../../dataset/m1.txt");
        var stream2 = new TextInput(@"../../../dataset/m2.txt");
        var stream3 = new TextInput(@"../../../dataset/m3.txt");
        var actual = Multiway.Merge(new TextInput[] { stream1, stream2, stream3 });
        var expected = "A A B B B C D E F F G H I I J N P Q Q Z";
        Assert.AreEqual(expected, actual);
    }
}