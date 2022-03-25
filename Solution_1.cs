using System;
using System.Linq;

public class Test
{
	public static void Main()
	{
		int[] arr = Enumerable.Range(1, 99).ToArray();
		
		var random = new Random();
			
			arr[random.Next(99)] = 100;
			
            int missingNumber,Totalsum;
            Totalsum = (arr.Length + 1) * (arr.Length + 2) / 2;

            foreach (int item in arr)
            {
                Totalsum = Totalsum - item;
            }
            missingNumber = Totalsum;

            Console.WriteLine("missing number  : {0}",missingNumber);
	}
}
