int[] MyArray =  { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };
int n = MyArray.Length;

bool[] visited = new bool[n];

for (int i = 1; i <= 5; i++)
{
    
    int count = 0;

    
    for (int j = 0; j < n; j++)
    {
        if (visited[j] == true)
            continue;

        if (MyArray[j] == i)
        {
            visited[j] = true;
            count++;
        }
    }


    Console.Write(i + ": ");
    for (int k = 0; k < count; k++)
    {
        Console.Write('*');
    }
    Console.WriteLine();
}