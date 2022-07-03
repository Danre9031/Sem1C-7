int lineArray = Input("m=");
int columnArray = Input("n=");
double[,] array = new double[lineArray, columnArray];
double result=0;

FillSeccondsArrayRandomsNumbers(array);
PrintSeccondArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
        int sizeJ=array.GetLength(1);
        result+=array[i,j];
        if (j == sizeJ-1)
            {
                result=result/sizeJ;
                Console.Write(Math.Round(result,2) + "/");
                result=0;
            }

        }
}

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

void FillSeccondsArrayRandomsNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}