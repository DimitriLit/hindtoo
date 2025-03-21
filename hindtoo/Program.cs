
using hindtoo;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("");


        var result = PeopleList.people
            .ToLookup(x => x.Age);

        foreach (var age in result)
        {
            Console.WriteLine("Age group: " + age.Key);

            foreach (var item in age)
            {
                Console.WriteLine("Person name: " + item.Name);

            }
        }

    }

}

/*
 * Kui listis on palju inimesi kellest aeg on sama,
 * siis ToLookUp tegib üks Key ja kui Age on sama, siis ToLookUp sorteerib sama sugune Age selles Key,
 * aga kui Age on erineb, siis ToLookUp tegib uue Key.
*/