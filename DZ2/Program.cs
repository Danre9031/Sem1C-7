int numberСoordinators = Input("Введите координаты числа в массиве в виде двух значного числа=");
int[,] array = new int[3, 3];
int lineArray = numberСoordinators / 10;
int columnArray = numberСoordinators % 2;
int result=0;
if (array.GetLength(0) < lineArray || array.GetLength(1) < columnArray)
{
    Console.WriteLine($"({lineArray},{columnArray})-> такого чиссла в массиве нет");
}
else
{
    FillSeccondsArrayRandomsNumbers(array);
    PrintSeccondArray(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (lineArray == i && columnArray == j)
            {
                result=array[i,j];
                break;
            }

        }
    }
Console.WriteLine($"({lineArray},{columnArray})-> {result}");
}

void PrintSeccondArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillSeccondsArrayRandomsNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 100);
        }
    }
}
