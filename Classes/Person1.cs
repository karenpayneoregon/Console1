public class Person1
{
    public String? FirstName { get; set; }
    public String? LastName { get; set; }
    public int Age { get; set; }
    
    public override bool Equals(object? obj)
    {
        return obj is Person1 person &&
               FirstName == person.FirstName &&
               LastName == person.LastName &&
               Age == person.Age;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}