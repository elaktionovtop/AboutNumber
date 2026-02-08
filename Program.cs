/*
Пользователь вводит число в интервал [-999;999].
Вывести описание этого числа: положительное/отрицательное, четное/нечетное, сколько знаков.
*/

WriteTitle("Свойства числа");

ExitApp();


void WriteTitle(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
    Console.WriteLine();
}

void ExitApp()
{
    Console.WriteLine();
    Console.Write("Для выхода нажми Enter");
    Console.ReadLine();
}
