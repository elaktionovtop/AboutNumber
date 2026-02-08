/*
Пользователь вводит число в интервал [-999;999].
Вывести описание этого числа: положительное/отрицательное, четное/нечетное, сколько знаков.
*/
using static System.Console;

WriteTitle("Свойства числа");

bool repeat;
do
{
    DescribeNumber();
    WriteLine();
    Write("Хотите продолжить? (д/н): ");
    string answer = ReadLine();
    repeat = answer.Trim().ToLower() == "д";
    WriteLine();
} while (repeat);

ExitApp();

void DescribeNumber()
{
    int number = EnterInteger("Введите число в интервале [-999;999]: ");
    while (number < -999 || number > 999)
    {
            WriteLine("Ошибка!");
            number = EnterInteger("Введите число в интервале [-999;999]: ");
    }

    if(number < 0)
        Write("Отрицательное ");
    else if(number > 0)
        Write("Положительное ");
    else
        Write("Нулевое ");

    if(number % 2 == 0)
        Write("Четное ");
    else
        Write("Нечетное ");

    if(number >= -9 && number <= 9)
        Write("Однозначное");
    else if(number >= -99 && number <= 99)
        Write("Двузначное");
    else
        Write("Трехзначное");
}

int EnterInteger(string prompt)
{
    Write(prompt);
    bool result = int.TryParse(ReadLine(), out int number);
    while(!result)
    {
        Write($"Некорректный ввод. {prompt}");
        result = int.TryParse(ReadLine(), out number);
    }
    return number;
}

void WriteTitle(string title)
{
    WriteLine(title);
    WriteLine(new string('-', title.Length));
    WriteLine();
}

void ExitApp()
{
    WriteLine();
    Write("Для выхода нажми Enter");
    ReadLine();
}
