/*
    Example using an NuGet package to create random data.
        This package was difficult to install because of OED security but I found a way around this :-)

    This project is using .NET 6 which requires the SDK to be installed.

    Notes
        1. No namespace, this is .net 6
*/

using System;
using GenFu;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GenFu.ValueGenerators.Temporal;
using System.Runtime.CompilerServices;
using static System.Console;

//Chunking();
DateOnlyExample();

static void Chunking()
{
    A.Configure<Person>()
        .Fill(p => p.Age)
        .WithinRange(19, 25);

        List<Person> people = A.ListOf<Person>();

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
}

/*
    DateOnly and TimeOnly are .NET Core 6
*/
static void DateOnlyExample()
{
    
    DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
    WriteLine(currentDate);
    WriteLine(DateTime.Now);
    var currentTime = TimeOnly.FromDateTime(DateTime.Now);
    WriteLine(currentTime);
}


