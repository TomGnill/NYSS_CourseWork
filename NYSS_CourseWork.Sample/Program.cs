using System;
using NYSS_CourseWork.Scrambler;
using NYSS_CourseWork.Scrambler.FileReader;

namespace NYSS_CourseWork.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Scrambler.Scrambler newScrambler = new Scrambler.Scrambler("дедушка",new RussianAlphabet());
            string test = newScrambler.Encrypt("Андрей").Result;
            Console.WriteLine(newScrambler.Encrypt("Андрей").Result);
            Console.WriteLine(newScrambler.Decrypt(test).Result);
            IFileReader newReader = new TxtReader("D:\\testtext.txt");
            IFileReader newWriter = new TxtReader("D:\\result.txt");
            IFileReader newWriterOut = new TxtReader("D:\\result1.txt");
            string text = newReader.Read();
            newWriter.Write(newScrambler.Encrypt(text).Result);
            string text1 = newWriter.Read();
            newWriterOut.Write(newScrambler.Decrypt(text1).Result);
           */
        }
    }
}
