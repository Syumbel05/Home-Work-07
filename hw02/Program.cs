
int m = 3;
int n = 4;
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m || b>n)
 Console.WriteLine("такого числа нет,вышли за пределы массива");
 else
 {
 Object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }