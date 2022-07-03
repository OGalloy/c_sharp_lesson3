/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.WriteLine("Enter five-digit number");
string number = Console.ReadLine();
if (number.Length != 5)
{
    Console.WriteLine("Your number not five-digit number");
}
else
{
    int result = checkPalindrome(number);

    if(result == 0){
        Console.WriteLine("Number {0} is a palindrome number", number);
    }
    else
    {
        Console.WriteLine("Number {0} is not a palindrome number", number);
    }
}

//function will work with even and odd length of a number.
int checkPalindrome(string number)
{   
    //int temp индекс конца массива. для проверки
    int temp = number.Length - 1; 
    //проверяем только до середины строки
    for (int i = 0; i < number.Length / 2; i++)
    {   
        
        if (number[i] != number[temp])
        {
            return -1; //если не палиндром
        }
        temp--;
    }
    return 0; //если палиндром
}
    

