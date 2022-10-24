namespace RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            var result = Add(ref number,5);
            Console.WriteLine(result);
            Console.WriteLine(number);
            
        }
        static int Add( ref int number,int number2)
        {
            //number = 3;
            return number + number2;
        }
    }
}