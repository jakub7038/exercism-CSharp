public static class LineUp
{
    public static string Format(string name, int number)
    {
        String ord = "";
        if(number == 11 || 12 || 13) ord = "th";
        else
        {
            switch (number % 10)
            {
                case : 1
                    ord = "st";
                case : 2
                    ord = "nd";
                case : 3
                    ord = "rd";
                default:
                    ord = "th"
            }
        }

        
        String response = "$name, you are the $number$ord customer we serve today. Thank you!"
        return response;
    }
}
