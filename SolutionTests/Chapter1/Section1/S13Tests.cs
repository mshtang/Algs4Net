namespace SolutionTests.Chapter1.Section1;
using Solutions.Chapter1.Section1;

[TestClass]
public class S13Tests
{
    [TestMethod]
    public void TransposeTests()
    {
        var mat = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        var res = S13.Transpose(mat);
        Assert.IsTrue(res.GetUpperBound(0) + 1 == 3);
        Assert.IsTrue(res.GetUpperBound(1) + 1 == 2);
        Assert.IsTrue(res[0, 1] == mat[1, 0]);
        Assert.IsTrue(res[1, 0] == mat[0, 1]);
        Assert.IsTrue(res[1, 1] == mat[1, 1]);
    }
}
