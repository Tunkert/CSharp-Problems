using System;

namespace dotnet_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int num1;
            int num2;
            int difference;
            bool breaker = false;
            for( int i = 0; i < nums.Length; i++ )
            {
                num1 = nums[i];
                difference = target - num1;
                for ( int x = 0; x < nums.Length && !breaker ; x++ )
                {
                    if ( difference == nums[x] && i != x )
                    {
                        Console.WriteLine("Output => [" + i + " , " + x + "]");
                        num2 = nums[x];
                        breaker = true;
                        break;
                    }
                }
            }
        }
    }
}
