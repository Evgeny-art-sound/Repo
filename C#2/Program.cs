Console.Write("input digit A ");
int a = int.Parse(Console.ReadLine());
Console.Write("input digit B ");
int b = int.Parse(Console.ReadLine());
Console.Write("input digit C ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > a)
{
   max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("max = ");
Console.WriteLine(max);