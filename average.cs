using System;

public class Average
{
	public static void Main()
	{
		double NumberCounter, AddNumbers, counter, AverageResult;
		NumberCounter = 0;
		counter = 0;
		string mark;
		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();
		for (NumberCounter = 0; mark != "end"; counter++) //count of all the marks, until the user types "end"
		{
			AddNumbers = Convert.ToDouble(mark);
			NumberCounter += AddNumbers;	// The number is added to the sum, and the counter adds one
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}
		if (counter != 0)
		{
			AverageResult = NumberCounter / counter;  //calculate the average
			Console.WriteLine("The average is {0}.", AverageResult);
		}
	}
}
