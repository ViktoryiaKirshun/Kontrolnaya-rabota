string[] Array = {"hello", "2", "world", ":-)" };
string str = string.Join(", ", Array);
Console.Write($"[{str}] -> ");

for (int i = 0; i < Array.Length; i++)

{
    if (Array[i].Length <= 3)
    {
        if (i != Array.Length - 1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}");
        }
    }
}
