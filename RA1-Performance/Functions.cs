namespace RA1_Performance;

public static class Functions
{
    public static bool IsValidNumber(string? valueFromUser)
    {
        if (int.TryParse(valueFromUser, out _) && !string.IsNullOrEmpty(valueFromUser) && !string.IsNullOrWhiteSpace(valueFromUser))
            return true;
    
        return false;
    }
}