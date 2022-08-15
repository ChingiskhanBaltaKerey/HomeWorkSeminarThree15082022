//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write ("Введите пятизначное число:  ");
int userDay = Convert.ToInt32 (Console.ReadLine ());
string LineNumber = Convert.ToString (userDay);
while (LineNumber.Length <5  || LineNumber.Length >5)
{
    Console.Write ("Введите пятизначное число:  ");
    userDay = Convert.ToInt32 (Console.ReadLine ());
    LineNumber = Convert.ToString(userDay); 
}
if (LineNumber [0] == LineNumber [4] && LineNumber [1] == LineNumber [3])
{
Console.Write ($"Число палиндром");
}
else
{
    Console.Write ($"Число  НЕ панлиндром");
}
