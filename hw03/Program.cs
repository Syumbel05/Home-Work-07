int[,] array=new int[3,4];
for(int i=0;i<3;i++)
{
    for (int j=0;j<4;j++)
    {
        array[i,j]=new Random().Next(0,10);
        Console.Write(array[i,j]);
    }
    Console.WriteLine();
}
for (int j=0;j<4;j++)
{
int sum=0;
for (int i=0;i<3;i++)
{
    sum+= array[i,j];
}
Console.WriteLine("среднее арефмитическое каждого столбца составляет " + sum/3);
}