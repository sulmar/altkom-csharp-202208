

int x = 10;
int y = 3;

// Operatory arytmetyczne
Console.WriteLine(x + y);
Console.WriteLine(x - y);
Console.WriteLine(x * y);
Console.WriteLine(x / y);
Console.WriteLine(x % y);

// Kolejność działań
int r = (2 + 3) * 4;

// Inkrementacja
Console.WriteLine(++x); // x = x + 1

// Dekrementacja
Console.WriteLine(y--); // y = y - 1

// Przypisania
int z = 10;

// z = z + 5;
z += 5;

Console.WriteLine(z);

// z = z * 3
z *= 3;

Console.WriteLine(z);

// Porównania
int temp = 1;

// Relacje
Console.WriteLine(temp > 0);
Console.WriteLine(temp >= 1);
Console.WriteLine(temp < 0);
Console.WriteLine(temp <= -1);

// Równość
Console.WriteLine(temp == 1);
Console.WriteLine(temp != 0); // temp <> 0

// Operator trójskładnikowy
int points = 110;

string type = points > 100 ? "gold" : "silver";
Console.WriteLine(type);

// wyrażenie warunkowe
if (points > 100)
    type = "gold";
else
    type = "silver";

Console.WriteLine(type);








