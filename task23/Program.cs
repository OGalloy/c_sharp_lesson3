Console.WriteLine("Enter you number");

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Set of numbers: ");
showSetCubeNumbers(number);
Console.Write("\n");

//showSetCubeNumbers(number);

void showSetCubeNumbers(int digit)
{
    for(int i = 1; i <= digit; i++)
    {
        Console.Write("{0} ", Math.Pow(i, 3));
    }
}
