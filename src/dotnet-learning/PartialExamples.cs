namespace dotnet_learning;

internal partial class PartialExamples(string firstName, string lastName)
{
    private string FirstName { get; set; } = firstName;
    private string LastName { get; set; } = lastName;

    private partial string GetFullName();
}

internal partial class PartialExamples
{
    public void PrintFullName()
    {
        Console.WriteLine(GetFullName());
    }

    private partial string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}