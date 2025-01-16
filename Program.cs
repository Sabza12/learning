MinutesToSeconds minutesToSeconds = new MinutesToSeconds(); 

Console.WriteLine("Enter the number of minutes you would like to convert.");
int minutes = int.Parse(Console.ReadLine());

Console.WriteLine("converted: " + minutesToSeconds.ConvertinuteSeconds(minutes));