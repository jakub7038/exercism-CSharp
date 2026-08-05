public static class PythagoreanTriplet
{
    public static bool IsTriplet(int a, int b, int c, int sum)
    {
        if (a * a + b * b != c * c) return false;
        if (a + b + c != sum) return false;
        return true;
    }

    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var list = new List<(int a, int b, int c)>();

        for (int a = 1; a < sum / 3; a++)
        {
            for (int b = a + 1; ; b++)
            {
                int c = sum - a - b;

                if (b >= c)
                {
                    break;
                }

                if (IsTriplet(a, b, c, sum))
                {
                    list.Add((a, b, c));
                }
            }
        }

        return list;
    }
}