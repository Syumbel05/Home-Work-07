// See https://aka.ms/new-console-template for more information
double [,] matrix=new double[3,4];

void PrintArray(double[,]matrix)
{
for (int i=0;i<3;i++)
    {
for (int j=0;j<4;j++)
      {
    Console.Write($"{matrix[i,j]}");
      }
Console.WriteLine();
    }
}
void FillArray(double[,]matrix)
{
for (int i=0;i<matrix.GetLength(0);i++)
  {
    for (int j=0;j<matrix.GetLength(1);j++)
    {

matrix[i,j]=Convert.ToDouble(new Random().Next(-100, 100)) / 10;
    }
  }
}
FillArray(matrix);
PrintArray(matrix);
