namespace Task2;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string? username = null;

        // null check using ternary operator
        string checkResult = username == null ? "Username is not available" : username;
        Console.WriteLine($"Ternary Operator: {checkResult}");
        
        // null check using null coalescing operator
        string coalescingResult = username ?? "Username is not available";
        Console.WriteLine($"Null Coalescing Assingment Operator: {coalescingResult}");
        
        // null coalescing assignment operator
        username ??= "Default Username";
        Console.WriteLine($"Null Coalescing Assingment Operator: {username}");
    }
}