namespace PalindromeCalulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //testing strange results 
            //var no89 = CalculatePalindrome(89, 0);
            //CalculatePalindrome(196, 0);

            for (ulong i = 10; i <= 200; i++)
            {
                ulong stepNo = 0;
                var result = CalculatePalindrome(i, stepNo);
                Console.WriteLine($"Original Number: {i}; Resulting Number: {result.Item1}; Steps: {result.Item2}");
            }
        }
        static Tuple<ulong, ulong> CalculatePalindrome(ulong number, ulong step)
        {
            var reversedNum = ReversUlong(number);
            var tupleCounter = new Tuple<ulong, ulong>(number, step);

            if (reversedNum != number)
            {
                number += reversedNum;
                step++;
                tupleCounter = CalculatePalindrome(number, step);
            }

            return tupleCounter;
        }
        //stolen from StackOverflow
        static ulong ReversUlong(ulong number, ulong result = 0)
        {
            return number == 0 ? result : ReversUlong(number / 10, result * 10 + number % 10);
        }
    }
}
