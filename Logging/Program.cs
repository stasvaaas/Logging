namespace Logging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\file.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                if (new FileInfo(filePath).Length == 0)
                {
                    writer.WriteLine($"First start at {DateTime.Now}");
                }
                else
                {
                    writer.WriteLine($"{DateTime.Now}");
                }
            }

        }
    }
}
