string x = Console.ReadLine();
if (x[0] == x[4] & x[1] == x[3])
{
Console.WriteLine("Da");
}
else
{
Console.WriteLine("No");
}



int x = Convert.ToInt32(Console.ReadLine());
int stepen = 3;
for (int i = 1; i < x+1; i++)
    if (i < x)
        {
        Console.Write($"{Math.Pow(i, stepen)}, ");
        }
    else
        {
        Console.Write(value: $"{Math.Pow(i, stepen)}. ");
        }



Console.WriteLine("Введите координаты точки А");
int[] A = new int[3];
for (int i = 0; i < A.Length; i++)
{
    A[i] = int.Parse(Console.ReadLine());    
}
for (int i = 0; i < A.Length; i++)
    if (i == 0)
{
    Console.Write($"A = ({A[i]}, ");
}
    else if (i == 1)
{
    Console.Write($"{A[i]}, ");
}
    else
{
    Console.WriteLine($"{A[i]}) ");    
}
Console.WriteLine("Введите координаты точки B");
int[] B = new int[3];
for (int i = 0; i < A.Length; i++)
{
    B[i] = int.Parse(Console.ReadLine());    
}
for (int i = 0; i < A.Length; i++)
    if (i == 0)
{
    Console.Write($"B = ({B[i]}, ");
}
    else if (i == 1)
{
    Console.Write($"{B[i]}, ");
}
    else
{
    Console.WriteLine($"{B[i]}) ");    
}
double a = Math.Sqrt(Math.Pow(A[0]-B[0], 2) + Math.Pow(A[1]-B[1], 2) + Math.Pow(A[2]-B[2], 2));
Console.WriteLine(a);


