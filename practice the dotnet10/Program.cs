Console.WriteLine("Hello, World!");

Console.WriteLine("size of sbyte: " + sizeof(sbyte));
Console.WriteLine("size of byte: " + sizeof(byte));
Console.WriteLine("size of short: " + sizeof(short));
Console.WriteLine("size of ushort: " + sizeof(ushort));
Console.WriteLine("size of int: " + sizeof(int));
Console.WriteLine("size of uint: " + sizeof(uint));
Console.WriteLine("size of long: " + sizeof(long));
Console.WriteLine("size of ulong: " + sizeof(ulong));


// declaraction and assignment of a variable
// type [variable name];
// type [variable name] = [value];

int totalProducts = 100;
long views = 500;
float price = 19.99f;
double result = 15000.80002;
decimal balance = 100000.50m;
bool isActive = true;
char grade = 'A';
string message = "Hello, World!";
var name = "i well call you latter";


//System.Console class
// read the user input from the console : return string
Console.ReadLine();

// print text to the console with new line : return void
Console.WriteLine();

// print text to the console without new line : return void
Console.Write(message);

// clear the console : return void
Console.Clear();



var userName = Console.ReadLine();
var password = Console.ReadLine();

Console.WriteLine($"User name: {userName}, Password: {password}");

Console.Clear();