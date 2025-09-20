# Triangle Validation CLI Tool

A C# console application that validates whether three natural numbers can form a triangle using the triangle inequality theorem.

## Requirements

- .NET 8.0 or later
- Windows, macOS, or Linux

## Usage

```bash
# Run the application
dotnet run --project TriangleApp -- <a> <b> <c>

# Examples
dotnet run --project TriangleApp -- 3 4 5    # Output: Yes
dotnet run --project TriangleApp -- 1 2 3    # Output: No
dotnet run --project TriangleApp -- 1 a 3    # Output: Error: Non-numeric string detected
```