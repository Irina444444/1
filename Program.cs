

// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($" {i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


string text = "Просто текст в котором надо заменить пробелы на черточки и меленькие буквы на большие"
            +"а также большие буквы на маленькие";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result + $"{newValue}";
        else result + $"{str[i]}";
    }
return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);





