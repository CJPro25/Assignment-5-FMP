namespace All_Code_FMP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(howManySeconds(2));// ➞ 7200
            Console.WriteLine(howManySeconds(10));// ➞ 36000
            Console.WriteLine(howManySeconds(24));// ➞ 86400

            Console.WriteLine(howManyHours(7200));// ➞ 2
            Console.WriteLine(howManyHours(36000));// ➞ 10
            Console.WriteLine(howManyHours(86400));// ➞ 24

            Console.WriteLine(howManyHours2(240));// ➞ 4
            Console.WriteLine(howManyHours2(660));// ➞ 11
            Console.WriteLine(howManyHours2(1380));// ➞ 23

            Console.WriteLine(howManyMinutes(4));// ➞ 240
            Console.WriteLine(howManyMinutes(11));// ➞ 660
            Console.WriteLine(howManyMinutes(23));// ➞ 1380

            int howManySeconds(int a) { return a * 60 * 60; }
            int howManyHours(int a) { return (a / 60) / 60; }
            int howManyHours2(int a) { return a / 60; }
            int howManyMinutes(int a) { return a * 60; }
            

            Console.WriteLine(circuitPower(230, 10));// ➞ 2300
            Console.WriteLine(circuitPower(110, 3));// ➞ 330
            Console.WriteLine(circuitPower(480, 20));// ➞ 9600

            int circuitPower(int a, int b) { return a * b; }
            */

            int HowManyStickers(int a){return (a * a * 6);}

            Console.WriteLine(HowManyStickers(1));
            Console.WriteLine(HowManyStickers(2));
            Console.WriteLine(HowManyStickers(3));
        }
    }
}
