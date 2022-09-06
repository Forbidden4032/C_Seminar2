// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

void ShowDigit (int x)
    {
    if (x < 999 && x > 99) 
        {int y = (x%100)/10;
        Console.WriteLine($"Трехзначное число {x}, второе число {y}");
        }
    else
        {
        Console.WriteLine($"Число {x} не трехзначное"); 
        }
    }

Console.WriteLine("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
ShowDigit(x);

