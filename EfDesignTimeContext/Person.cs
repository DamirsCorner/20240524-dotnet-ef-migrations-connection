namespace EfDesignTimeContext;

public class Person(string firstName, string lastName)
{
    public int Id { get; set; }
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
}
