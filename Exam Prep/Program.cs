using System;

// ReSharper disable All

namespace Exam_Prep {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Section_B {
        internal static class Program {
            private static void IsPrime() {
                bool isPrime = true;
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out var number);
                for (var i = 2; i < Math.Ceiling(Math.Sqrt(number)); i++) {
                    if (number % i == 0) {
                        isPrime = false;
                    }
                }
                if (number <= 1)
                    Console.WriteLine("Not greater than 1");
                else {
                    Console.WriteLine(isPrime ? "Is prime" : "Is not prime");
                }
            }

            private static void CharMatcher() {
                Console.Write("Enter word one: ");
                var wordOne = Console.ReadLine()?.ToUpper();
                Console.Write("Enter word two: ");
                var wordTwo = Console.ReadLine()?.ToUpper();

                var wordTwoChars = wordTwo.ToList();
                Console.WriteLine(wordOne.All(i => wordTwoChars.Remove(i)) ? "Match found" : "Match not found");
            }

            private static void MultiModal() {
                int[] inputs = new int[10];
                Console.Write("How many number you want?: ");
                int total = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter that many items, followed by ENTER after every value (between 0 and 9): ");
                
                for (int i = 0; i < total; i++) {
                    Console.Write($"{i + 1}: ");
                    int numToAdd = int.Parse(Console.ReadLine());
                    inputs[numToAdd]++;
                }
                
                var sortedInputs = inputs.ToList();
                sortedInputs.Sort();
                Console.WriteLine(sortedInputs[^1] == sortedInputs[^2] ? "Multimodal" : (inputs.ToList().IndexOf(inputs.Max()).ToString()) + " was repeated " + inputs.Max().ToString() + " times");
            }

            private static void Main() {
                //IsPrime();
                //CharMatcher();
                MultiModal();

                Console.ReadKey();
            }
        }
    }
}