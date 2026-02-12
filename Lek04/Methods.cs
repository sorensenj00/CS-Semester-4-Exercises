
namespace Lek04
{
    public static class Methods
    {
        delegate int Operation(int a, int b);

        static void CalculateAndDisplay(int a, int b, Operation operation)
        {
            Console.WriteLine("a: " + a + ", b: " + b + ", result: " + operation(a, b));
            
        }

        public static bool Lang(string str, int n)
        {
            return str != null && str.Length > n;
        }
        
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    
}
