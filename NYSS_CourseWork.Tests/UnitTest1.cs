using System;
using NUnit.Framework;
using NYSS_CourseWork.Scrambler;
using NYSS_CourseWork.Scrambler.FileReader;

namespace NYSS_CourseWork.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test()]
        public void Test1()
        {
            //проверка на соответствие шифровки-расшифровки
            Scrambler.Scrambler newScrambler = new Scrambler.Scrambler("дедушка", new RussianAlphabet());
            string startWord = "Андрей";
            string encryptWord = newScrambler.Encrypt(startWord).Result;
            string decryptWord = newScrambler.Decrypt(encryptWord).Result;
            Assert.AreEqual(startWord, decryptWord);
        }

        [Test()]
        public void Test2()
        {
            //проверка на не соответствие ключей
            Scrambler.Scrambler newScrambler = new Scrambler.Scrambler("дедушка", new RussianAlphabet());
            string startWord = "Андрей";
            string encryptWord = newScrambler.Encrypt(startWord).Result;
            Scrambler.Scrambler newScrambler2 = new Scrambler.Scrambler("девушка", new RussianAlphabet());
            string decryptWord = newScrambler2.Decrypt(encryptWord).Result;
            Assert.AreNotEqual(startWord, decryptWord);
        }

        [Test()]
        public void Test3()
        {
            //проверка на соответствие шифровки-расшифровки с латинскими символами
            Scrambler.Scrambler newScrambler = new Scrambler.Scrambler("father", new EnglishAlphabet());
            string startWord = "Andrey";
            string encryptWord = newScrambler.Encrypt(startWord).Result;
            string decryptWord = newScrambler.Decrypt(encryptWord).Result;
            Assert.AreEqual(startWord, decryptWord);
        }
        [Test()]
        public void Test4()
        {
            //проверка на проверка на работу шифратора через текстовые файлы
            Scrambler.Scrambler newScrambler = new Scrambler.Scrambler("дедушка", new RussianAlphabet());
            IFileReader newReader = new TxtReader("D:\\testtext.txt");
            IFileReader newWriter = new TxtReader("D:\\result.txt");
            IFileReader newWriterOut = new TxtReader("D:\\result1.txt");
            string text = newReader.Read();
            newWriter.Write(newScrambler.Encrypt(text).Result);
            string text1 = newWriter.Read();
            newWriterOut.Write(newScrambler.Decrypt(text1).Result);

            string firstFile = newWriterOut.Read();
            Assert.AreEqual(text, firstFile);
            Assert.AreNotEqual(text,text1);
        }
    }
}