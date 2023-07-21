namespace Solutions.Chapter1.Section1;

public static class S13
{
    public static int[,] Transpose(int[,] mat)
    {
        var rows = mat.GetUpperBound(0) + 1;
        var cols = mat.GetUpperBound(1) + 1;

        var res = new int[cols, rows];

        for (var r = 0; r < cols; r++)
        {
            for (var c = 0; c < rows; c++)
            {
                res[r, c] = mat[c, r];
            }
        }
        return res;
    }
}
