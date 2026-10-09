int temp;
do
{
    Console.WriteLine("enter a temperature for a science experiment!");
    temp = int.Parse(Console.ReadLine());

} while (temp <= -50 || temp >= 150);

Console.WriteLine ("temperature recorded " + temp);

if ( temp < 0)
{
    Console.WriteLine("Freezing");
}
else if (temp < 30 )
{
    Console.WriteLine("Normal");
}
else if ( temp < 100)
{
    Console.WriteLine("Hot");
}
else
{
    Console.WriteLine("Extremely Hot");
}