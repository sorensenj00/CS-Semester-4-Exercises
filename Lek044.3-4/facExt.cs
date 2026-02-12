namespace Lek044komma3;

public static class facExt
{
    public static int Factorial(this int n)
    {
        int factorialrekursiv(int n)
        {
            if (n == 1) return 1;
            return n * factorialrekursiv(n - 1);
        }
        
        return factorialrekursiv(n);
    }


    public static int Power(this int n, int p)
    {
        if (p >= 0)
        {
            int result = 1; 
            for (int i = 0; i < p; i++)
            {
                result *= n;
            }

            return result; 
        }
        return 1; 
    }
}