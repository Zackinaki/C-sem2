Console.Clear();
Console.Write("Vvedite chislo pervoe: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite chislo vtoroe: ");
int b = Convert.ToInt32(Console.ReadLine());
if(b%a==0)
    Console.Write("kratno");
else
{
    Console.WriteLine("ne kratno");
    int c =b%a;
    Console.WriteLine(c);
}

// task 12
// Console.Clear();

// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());

// if (n % m == 0)
//     Console.Write("Кратно");
// else
//     Console.Write($"Не кратно, остаток {n % m}");

 