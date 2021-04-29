using System;

namespace NYSS_CourseWork.Scrambler
{
   public abstract class Alphabet
   {
       public string language;
       public Char[] alphabet;

       public Alphabet(string name, Char[] alphabet)
       {
           this.language = name;
           this.alphabet = alphabet;
       }
   }

   public class RussianAlphabet : Alphabet
   {
       public RussianAlphabet() : base(name: "Русский", alphabet: "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray())
       { }
   }

   public class EnglishAlphabet : Alphabet
   {
       public EnglishAlphabet() : base(name: "English", alphabet: "abcdefghijklmnopqrstuvwxyz".ToCharArray())
       { }
   }

}
