// МЕТОДЫ
// 1 группа методов - не возвращают и не принимают ничего.

/*void Method1()
{
    Console.WriteLine("Автор...");
}

Method1();*/

// 2 группа методов - принимают аргументы, но не возвращают их.
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");*/


/*void Method21(string msg, int count)


{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Method21(msg:"Валя молодец",count: 5);*/
// 3 группа методов - могут что то возвращать,но не принимают аргументы (генерация случайных чисел и т.д).

/*int Method3()
{
    return DateTime.Now.Year;
}
int year=Method3();
Console.WriteLine(year);*/

// 4 группа методов - и принимают и возвращают данные. 

string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty;

    while (i<count)
    {
        result=result+text;
        i++;
    }
    return result;
}
string res = Method4 (10, "Пушистик");
Console.WriteLine(res);
