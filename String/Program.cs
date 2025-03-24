using System.Security.Cryptography.X509Certificates;
using System;
using System.Text;

namespace String
{
    class Program
    {
        static string ConcatenateStrings(string string1, string string2)
        {
            return string1 + string2;
        }

        static string GreetUser(string name, int age)
        {
            return $"Hello, {name}! You are {age} years.\n";
        }

        static string ProcessString(string input)
        {
            int lenght = input.Length;

            string upperCase = input.ToUpper();

            string lowerCase = input.ToLower();

            return $"number of characters: {lenght}\n" +
                   $"upper case: {upperCase}\n" +
                   $"lower case: {lowerCase}\n";
        }

        static StringBuilder CombineStrings(string[] stringArray)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < stringArray.Length; i++)
            {
                result.Append(stringArray[i]);

                if (i < stringArray.Length - 1)
                {
                    result.Append(" ");
                }
            }
            return result;
        }

        static string ReplaceWord(string inputString, string wordToReplace, string replacementWord)
        {
            if (inputString == null || wordToReplace == null || replacementWord == null)
            {
                throw new ArgumentNullException("Good afternoon, my friend!");
            }

            return inputString.Replace(wordToReplace, replacementWord);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            string str1 = "Hello, ";
            string str2 = "World!\n";

            string result = ConcatenateStrings(str1, str2);

            Console.WriteLine(result);

            Console.WriteLine("Задание 2:");
            string greetingMessage = GreetUser("Sasha", 24);
            Console.WriteLine(greetingMessage);

            Console.WriteLine("Задание 3:");
            string input = "Home work";
            string result1 = ProcessString(input);
            Console.WriteLine(result1);

            Console.WriteLine("Задание 4:");
            string stringSub = "Netology";
            string subString = stringSub.Substring(0, 5);
            Console.WriteLine($"{subString}\n");

            Console.WriteLine("Задание 5:");
            string[] strings = { "Here is", "an example", "of the", "method\n" };
            StringBuilder combined = CombineStrings(strings);
            Console.WriteLine(combined.ToString());

            Console.WriteLine("Задание 6:");
            string inputString = "Hello, my friend!";
            string wordToReplace = "Hello";
            string replacementWord = "Good afternoon";

            string results = ReplaceWord(inputString, wordToReplace, replacementWord);
            Console.WriteLine(results);
        }
    }
}




