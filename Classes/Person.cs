public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }

    public Person(string firstName, string middleName, string lastName, string cityName, string stateName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        City = cityName;
        State = stateName;
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        MiddleName = "";
        LastName = lastName;
      }
    // Return the first and last name.
    public void Deconstruct(out string firstName, out string lastName)
    {
        firstName = FirstName;
        MiddleName = "";
        lastName = LastName;
    }


    public void Deconstruct(out string firstName, out string middleName, out string lastName)
    {
        firstName = FirstName;
        middleName = MiddleName;
        lastName = LastName;
    }

    public void Deconstruct(out string firstName, out string lastName, out string city, out string state)
    {
        firstName = FirstName;
        lastName = LastName;
        city = City!;
        state = State!;
    }
}