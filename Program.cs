Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] new_array = create_array();
print_array(new_array);
Console.WriteLine($"Количество четных числен равно {count_even_numbers(new_array)}.");

int count_even_numbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
            count++;
    }
    return count;
}

void print_array(int[] x)
{
    int[] new_array = x;
    for (int i = 0; i < new_array.Length; i++)
        Console.Write($"{new_array[i]} ");
}

int[] create_array()
{
    int[] new_array = new int[size];
    Random randGenerator = new Random();
    for (int i = 0; i < size; i++)
    {
        new_array[i] = randGenerator.Next(100, 1000);
    }
    return(new_array);
}