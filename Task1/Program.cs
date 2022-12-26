// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.

Console.WriteLine("Enter five-digit number");
int num = int.Parse(Console.ReadLine());

int figure1 = num/10000;
int figure2 = (num-(figure1*10000))/1000;
int figure4 = (num/10)%10;
int figure5 = num%10;

if (9999 < num && num < 100000)
{
   if (figure1==figure5 && figure2==figure4)
   {
    Console.WriteLine("The number is interpreter");
   }
   else Console.WriteLine("The number is not interpreter");
}
else Console.WriteLine("The number is not five-digit");

// Console.WriteLine($"{figure1} {figure2} {figure4} {figure5}");
