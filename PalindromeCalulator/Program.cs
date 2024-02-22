namespace PalindromeCalulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //testing strange results 
            //var no89 = CalculatePalindrome(89, 0);
            var no196 = CalculatePalindrome(196, 0);
            for (ulong i = 10; i <= 200; i++)
            {
                ulong stepNo = 0;
                var result = CalculatePalindrome(i, stepNo);
                Console.WriteLine($"Original Number: {i}; Resulting Number: {result.Item1}; Steps: {result.Item2}");
            }
        }
        //the fun way, but will bug out memory
        static Tuple<ulong, ulong> CalculatePalindrome(ulong number, ulong step)
        {
            var reversedNum = ReverseInt(number);
            var tupleCounter = new Tuple<ulong, ulong>(number, step);

            Console.WriteLine($"reversedNo: {reversedNum}, Step: {step}");
            if (reversedNum != number)
            {
                number += reversedNum;
                step++;
                Console.WriteLine($"newNumber: {number}");
                tupleCounter = CalculatePalindrome(number, step);
            }

            return tupleCounter;
        }

        //stolen from StackOverflow
        static ulong ReverseInt(ulong number, ulong result = 0)
        {
            return number == 0 ? result : ReverseInt(number / 10, result * 10 + number % 10);
        }
    }
}
