//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 99)
    {

    while (x >= 1000) 
        { x = x / 10; 
        } 
    int result = x % 10; 
    Console.WriteLine(result);
    }
else
    {
        Console.WriteLine("Третьей цифры нет");
    }

