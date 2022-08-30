
using Arrays;

int?[] numbers = new int?[3];
numbers[0] = 10;
numbers[2] = 20;

foreach (int? number in numbers)
{
    if (number.HasValue)
        Console.WriteLine(number);
}

string[] names = new string[10];
names[0] = "Marcin";
names[2] = "John";

names[0] = null;

foreach (string name in names)
{
    Console.WriteLine(name);
}


List<Person> members = new List<Person>();
members.Add(new Person { Id = 1, Name = "Marcin" });
members.Add(new Person { Id = 2, Name = "John" });
members.Add(new Person { Id = 3, Name = "Ann" });

// members.Remove("Marcin");

int id = 2;

// Person toRemove = members.Single(p => p.Id == 2); // wyrażenie lambda

Person toRemove = null;

foreach (Person member in members)
{
    if (member.Id == id)
    {
        toRemove = member;
        break;
    }
}

members.Remove(toRemove);

// members.RemoveAt();

foreach (Person member in members)
{
    Console.WriteLine(member.Name);
}
