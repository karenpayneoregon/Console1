/*
    Example using an NuGet package to create random data.  This package was difficult to install because of OED security but I found a way around this :-)
    .NET 6 which requires the SDK to be installed.
    No namespace, this is .net 6
*/


using System.Text.Json.Nodes;
using GenFu;
using static System.Console;

const string languageReleasePrefix = "C# 10";
const string languageRelease = $"{languageReleasePrefix} to be released in November 2021.";

Chunking();
DateOnlyExample();
TupleSample();
WriteLine("");
SetForColor("Main");
WriteLine(languageRelease);
WriteLine("");



static void TupleSample()
{

    SetForColor(nameof(TupleSample));

    var person = new Person("Karen", "Payne");

        // Deconstruct the person object.
        var (firstName, lastName, _ , _ ) = person;
        Console.WriteLine($"Hello {firstName} {lastName}");
}

static void Chunking()
{
    SetForColor(nameof(Chunking));
    WriteLine("");

    A.Configure<Person1>()
        .Fill(p => p.Age)
        .WithinRange(19, 25);

        List<Person1> people = A.ListOf<Person1>();

        int index = 0;

        foreach (var item in people.Chunk(10))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Group: {index + 1}");
            Console.ResetColor();

            foreach (var person in item)
            {
                
                Console.WriteLine($"\t{person.FirstName,-12}{person.LastName,-15}{person.Age}");
            }


            index += 1;
        }

    WriteLine("");
}

/*
    DateOnly and TimeOnly are .NET Core 6
*/
static void DateOnlyExample()
{

    SetForColor(nameof(DateOnlyExample));

    DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
    
    WriteLine(currentDate);
    WriteLine($"Month: {currentDate.Month}");
    WriteLine($"Day: {currentDate.Day}");
    WriteLine("");

    SetForColor("DateTime");
    WriteLine(DateTime.Now);
    WriteLine("");

    SetForColor("TimeOnly");
    var currentTime = TimeOnly.FromDateTime(DateTime.Now);
    WriteLine(currentTime);
    WriteLine($"Hour: {currentTime.Hour}");
    WriteLine($"Minutes: {currentTime.Minute}");

    WriteLine("");

}

static void SetForColor(string sender)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    WriteLine(sender);
    Console.ResetColor();

}

