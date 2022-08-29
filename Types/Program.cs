
byte? selectedNumber = null; // NULL

if (selectedNumber.HasValue)
{
    Console.WriteLine(selectedNumber);
}
else
{
    Console.WriteLine("Numer nie został wybrany.");
}

// #######################################
// Typy wartościowe (Value Types)
// #######################################

// Typy tekstowe
string name = "Marcin";
char sign = 'M';
string selectedColor = null;

char initial = name[0];

// Typy numeryczne

// liczby całkowite
byte? age = null; // 0..255
sbyte temperature = -10; // -127...127
short year = 2022;  //  -32768...32767
ushort capacity = 65000; // 0...65535
int quantity = 65000; // -2147483648...2147483647
uint cells = 4294967295; // 0...4294967295

// Liczby rzeczywiste
float weight = 0.5f;
double preasure = 1024.01;
decimal salary = 1000.05m;

// Typ logiczny
bool isApproved = true;

bool? isConfirmed = null;

// Typy daty i czasu
DateTime currentDate = DateTime.Now;

DateOnly dueDate = DateOnly.ParseExact("2022-08-22", "yyyy-MM-dd");
Console.WriteLine(dueDate);

TimeOnly openHour = TimeOnly.ParseExact("09:00", "HH:mm");
// snippets: cw
Console.WriteLine(openHour);

// #######################################
// Typy referencyjne (References Types)
// #######################################

// obiekty (objects)

Types.Person person = new Types.Person
{
    firstName = "Marcin",
    lastName = "Sulecki",
    age = 18
};




















