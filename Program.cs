string[] arraySource = new string[10] {"hi", "goodbye", "hello", "tiger", "wolf", "morning", "friend", "pork", "guy", "thanks"};
int resLength = 0;

for (int i = 0; i < arraySource.Length; i++)
{
    if (arraySource[i].Length <= 3)
    {
        resLength +=1;
    }
}

if (resLength > 0)
{
    string[] res = new string[resLength];
    int k = 0;
    for (int i = 0; i < arraySource.Length; i++)
    {
        if (arraySource[i].Length <= 3)
        {
            res[k] = arraySource[i];
            k++;
        }
    }
    PrintArray(res);
} 
else
{
    Console.Write("Подходящих элементов нет");
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }
    Console.Write("]");
}
