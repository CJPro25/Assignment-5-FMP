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
            

            int HowManyStickers(int a){return (a * a * 6);}

            Console.WriteLine(HowManyStickers(1)); // 6
            Console.WriteLine(HowManyStickers(2)); // 24
            Console.WriteLine(HowManyStickers(3)); // 54
            

            string[] names = { "" };
            string input = "";

            while(input != "Exit")
            {
                Console.WriteLine("Enter a name: ");
                input = Console.ReadLine();
                names = new string[] { input };
                //idk some stuff
            }
            

            string[] Alist = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine("The given list: " + Alist[0] + ", " + Alist[1] + ", " + Alist[2] + ", " + Alist[3] + ", " + Alist[4] + ", " + Alist[5] + ", " + Alist[6]);

            Console.WriteLine("The first element of the list: " + Alist[0]);

            Console.WriteLine("The last element of the list: " + Alist[Alist.Length - 1]);
            

            Console.WriteLine(DateTime.Now);
            */

          
            int x = 10, y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"Swapped ints: x = {x}, y = {y}");
            string first = "Hello", second = "World";
            Swap(ref first, ref second);
            Console.WriteLine($"Swapped strings: first = {first}, second = {second}");
            double d1 = 1.5, d2 = 2.5;
            Swap(ref d1, ref d2);
            Console.WriteLine($"Swapped doubles: d1 = {d1}, d2 = {d2}");

            

            static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }

        }
    }   
    
}
