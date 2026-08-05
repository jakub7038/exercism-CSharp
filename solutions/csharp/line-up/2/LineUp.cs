public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ord = "th";

        int rem = number % 100;
        if (rem != 11 && rem != 12 && rem != 13)
        {
            switch (number % 10)
            {
                case 1:
                    ord = "st";
                    break;
                case 2:
                    ord = "nd";
                    break;
                case 3:
                    ord = "rd";
                    break;
                default:
                    ord = "th";
                    break;
            }
        }

        return $"{name}, you are the {number}{ord} customer we serve today. Thank you!";
    }
}