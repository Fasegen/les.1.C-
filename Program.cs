Console.WriteLine ("Введите число X и Y");                                       //Задача 1
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if ( x > y)
{  Console.WriteLine("max" + x);
}
else
{ Console.WriteLine("max " + y);
}

Console.WriteLine ("Введите число X, Y и Z");                                     //Задача 2
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z = Convert.ToInt32(Console.ReadLine());
if ( x > y & x > z)
{  Console.WriteLine("max " + x);
}
else if ( y > x & y > z)
{ Console.WriteLine("max " + y);
}
else if ( z > x & z > y)
{Console.WriteLine("max " + z);
}



Console.WriteLine ("Введите число X");                                            //Задача 3
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
if ( x%2 == 0 )
{ Console.WriteLine("Да, делится");
}
else
{ Console.WriteLine("Нет, не делится");
}

Console.WriteLine ("Введите число N");                                             //Задача 4
Console.Write("N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int x = 1; x < N; x++)       
if (x%2 == 0)            
Console.WriteLine(x);

