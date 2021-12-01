int counter = 0;

// Read the file and display it line by line.  
foreach (string line in System.IO.File.ReadLines(@"C:\Users\sande\OneDrive - ODISEE\2e jaar\C#Programming\FirstProject\2122-csharpoo-sanderspaas\Blok1\BasicGui\BasicGui\bin\Debug\net6.0-windows\resources\SpyfallData.csv"))
{
    System.Console.WriteLine(line);
    counter++;
}

System.Console.WriteLine("There were {0} lines.", counter);
// Suspend the screen.  
System.Console.ReadLine();