Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Add add = new Add();
Console.WriteLine("Total: " + add.AddTwoNumbers(firstNumber, secondNumber));