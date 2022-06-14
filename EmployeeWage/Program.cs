
Console.WriteLine("Welcome to Employee Wage. ");
const int pricePerHr = 20, FullDay = 8; 
Random random = new Random();
int res = random.Next(0, 2);
if(res == 0)
{
    Console.WriteLine("abcent");
    Console.WriteLine("wage : "+(pricePerHr * FullDay));
}
else
{
    Console.WriteLine("Present");
    Console.WriteLine("Wage : 0 " );
}