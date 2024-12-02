int n = 7;
int m = 7;
double[,] matrix = new double[n, m];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = rand.NextDouble() * 20 - 10;
    }
}
Console.WriteLine("Сгенерированная матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{matrix[i, j]:0.00}\t");
    }
    Console.WriteLine();
}
double product = 1;
bool hasPositive = false; 
for (int i = 1; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (matrix[i, j] > 0)
        {
            product *= matrix[i, j];
            hasPositive = true;
        }
    }
}
if (!hasPositive)
{
    product = 0;
}
Console.WriteLine($"Произведение положительных элементов под главной диагональю: {product}");