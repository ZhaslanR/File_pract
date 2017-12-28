using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_pract
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        private static void SecondTask()
        {
            const string PATH = "Text2.txt";
            const string NAME = "Zhaslan";
            const string LAST_NAME = "RYSPEKOV";
            const int AGE = 16;

            using (StreamWriter streamWriter = new StreamWriter(PATH))
            {
                streamWriter.WriteLine(NAME);
                streamWriter.WriteLine(LAST_NAME);
                streamWriter.WriteLine(AGE);
            }
        }

        private static void FirstTask()
        {
            const string PATH = "Text1.txt";
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(PATH)))
            {
                var lenght = binaryReader.BaseStream.Length;
                for (int i = 0; i < lenght; i++)
                {
                    char symbol = Convert.ToChar(binaryReader.ReadByte());
                    if (!dictionary.ContainsKey(symbol))
                    {
                        dictionary.Add(symbol, 1);
                    }
                    else
                    {
                        dictionary[symbol]++;
                    }
                }
            }
            var keys = dictionary.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine("[{0}] - [{1}]", key, dictionary[key]);
            }
        }
    }
}
