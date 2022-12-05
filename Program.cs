Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
double average = 0;
double [,] matrix = new double [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
for(int j = 0; j < n; j++)
{
    for(int i = 0; i < m; i++)
    {
        average+=matrix[i,j];        
    }
    Console.Write(Math.Round(average/m, 1) + "; ");
    average = 0;
}