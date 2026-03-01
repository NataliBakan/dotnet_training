using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace repetition
{
    internal class Program
    {
        public static int[] GetArrayMoreAverage(int[] nums, out int min, out int max)
        {
            min = 0;
            max = 0;

            if (nums.Length == 0)
            {
                return [];
            }

            min = nums.Min();
            max = nums.Max();
            double avg = nums.Average();

            return nums.Where(num => num > avg).ToArray();
        }
        
        static void Main(string[] args)
        {
            // 1

            //var str = Console.ReadLine();
            //var result = str.Replace('.', ',');

            //double.TryParse(result, out double parsed);
            //Console.WriteLine(parsed);

            // 2 
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            var res = GetArrayMoreAverage(numbers, out var min, out var max);
            Console.WriteLine(min);
            Console.WriteLine(max);
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }

            // 3
            var text = Console.ReadLine();

            int countVowels = 0;
            string vowels = "аеёиоуыэюя";

            foreach (var letter in text)
            {
                if (vowels.Contains(char.ToLower(letter)))
                {
                    countVowels += 1;
                }
            }

            var qwe = "qwe123".ToArray().Reverse().ToArray();

            Console.WriteLine(qwe);

            var newText = text.Replace(" ", "_");

            var сharArray = newText.ToCharArray();
            Array.Reverse(сharArray);
            var reversedText = new string(сharArray);

            Console.WriteLine(countVowels);
            Console.WriteLine(reversedText);

           
        }
    }
}
