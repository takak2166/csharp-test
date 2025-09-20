namespace TriangleApp;

public static class Triangle
{
    public static bool IsValid(int a, int b, int c)
    {
        // Check for non-positive numbers
        if (a <= 0 || b <= 0 || c <= 0) return false;
        
        // Triangle inequality check
        // a + b > c AND b + c > a AND a + c > b
        // Use a > c - b form to avoid overflow
        bool condition1 = a > c - b; // a + b > c
        bool condition2 = b > a - c; // b + c > a  
        bool condition3 = a > b - c; // a + c > b
        
        return condition1 && condition2 && condition3;
    }
}
