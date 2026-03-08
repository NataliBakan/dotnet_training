namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 
            var person = new Person("Ivan", 21, "ivanuska@gmail.com", true);
            ReflectionTest.PrintProperties(person);

            // 2
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            if (!File.Exists(inputPath))
            {
                File.Create(inputPath).Close();
                Console.WriteLine("Файл не найден, создан пустой файл.");
            }

            int lineCount = 0;
            int charCount = 0;
            string fileContent = "";

            using (StreamReader reader = new StreamReader(inputPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;
                    fileContent += line + Environment.NewLine;
                }
            }

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine($"Количество строк: {lineCount}");
                writer.WriteLine($"Количество символов: {charCount}");
                writer.WriteLine();
                writer.WriteLine(fileContent);
            }

            Console.WriteLine("Обработка завершена!");
            Console.WriteLine($"Строк: {lineCount}");
            Console.WriteLine($"Символов: {charCount}");
        }
    }
}
