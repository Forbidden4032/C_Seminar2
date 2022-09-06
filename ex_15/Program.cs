//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.


string WeekendCheck(int num)
    {
        if (num == 7) return "Воскресенье, выходной";
        if (num == 6) return "Суббота, выходной";
        if (num == 5) return "Пятница, рабочий день";
        if (num == 4) return "Четверг, рабочий день";
        if (num == 3) return "Среда, рабочий день";
        if (num == 2) return "Вторник, рабочий день";
        if (num == 1) return "Понедельник, рабочий день";
        return "Несуществует";       
    }


Console.WriteLine("Введите цифру дня недели: ");
int num = int.Parse(Console.ReadLine());

string WkShow = WeekendCheck(num);
Console.WriteLine($"Указанный день недели {num}: {WkShow}");
