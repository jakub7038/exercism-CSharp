public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter) 
    {
        int index = str.IndexOf(delimiter);
        return str.Substring(index + delimiter.Length);
    }

    public static string SubstringBetween(this string str, string start, string end)
    {
        int startIndex = str.IndexOf(start) + start.Length;
        int endIndex = str.IndexOf(end, startIndex);

        return str.Substring(startIndex, endIndex - startIndex);
    }


    public static string Message(this string str)
    {
        int splitIndex = str.IndexOf(':');
        return str.Substring(splitIndex + 1).Trim();
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}