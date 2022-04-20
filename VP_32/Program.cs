// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К".

string text="- Я думаю, - сказал князь, улыбаясь, что, "
            + "ежели бы вас послали вместо нашего милого Виценгероде,"
            + "вы бы взяыли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s="ВАляВаля"
 //          01231
// s[3]//В
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i=0; i<length; i++)
    {
        if(text[i]==oldValue) result=result + $"{newValue}";
        else result=result + $"{text[i]}";
    }
    return result;
}
string newText =Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
 newText =Replase(newText,'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
 newText =Replase(newText,'C', 'c');
Console.WriteLine(newText);
