public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        String[] parts = phoneNumber.Split('-');

        (bool IsNewYork, bool IsFake, string LocalNumber) arguments;

        arguments.IsNewYork = parts[0] == "212";
        arguments.IsFake = parts[1] == "555";
        arguments.LocalNumber = parts[2];

        return arguments;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
