//very simple console application that ask the user for his/her name and then returns it
string naam = "";
do
{
    Console.Write("Geef je naam op: ");
    naam = Console.ReadLine();

} while (string.IsNullOrWhiteSpace(naam));
Console.WriteLine("Welkom: " + naam);
