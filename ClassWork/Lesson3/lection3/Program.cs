// Вид 1 (которые получают данные но не возвращают)

void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

//Вид 2

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(count: 4, msg: "Текст новый");

//Вид 3 что то возвращают но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

// Вид 4 что то принимают и что то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
        while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);
