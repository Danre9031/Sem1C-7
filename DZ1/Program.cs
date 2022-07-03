int m = Input("m=");
int n = Input("n=");
double[,] number = new double[m, n];

FillSeccondsArrayNumbers(number);
PrintSeccondArray(number);

void PrintSeccondArray(double[,] array)
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

void FillSeccondsArrayNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (Convert.ToDouble(new Random().Next(-99, 100)))/10;
        }
    }
}
