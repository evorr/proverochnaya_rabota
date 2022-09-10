string allElements = String.Empty;
string[] GetArray(string allElements)
{
    Console.Write("Введите значение, если ввод значений закончен нажмите f: ");
    string word = Console.ReadLine();
    if(word!="f")
    {
        allElements += word + ";";
        return GetArray(allElements);
    }
    else
    {
        allElements = allElements.Remove(allElements.Length-1);
        string[] array = allElements.Split(";");
        return array;
    }
}

string [] StringLess4 (string[] array)
{
    string temp = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            temp += array[i] + ";";
        }
    }
    if(temp.Length>=2) temp = temp.Remove(temp.Length-1);
    string[] newArray = temp.Split(";");
    return newArray;
}
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i==0) Console.Write("[");
        if(i<array.Length-1) Console.Write(array[i]+", ");
        else Console.Write(array[i]+"]");
    }
}
string[] array1 = GetArray(allElements);
string[] array2 = StringLess4(array1);
PrintArray(array1);
Console.Write("->");
PrintArray(array2);