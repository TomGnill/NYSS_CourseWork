using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NYSS_CourceWork.Scrambler
{
    public class Scrambler
    {
        public string Key { get; set; }
        public Alphabet Alphabet { get; set; }
        public Scrambler(string key, Alphabet alphabet)
        {
            Alphabet = alphabet;
            Key = key;
        }
        public async Task<string> Encrypt(string text)
        {
           return await Task.Run(() => Execute(text, true));
        }
        public async  Task<string> Decrypt(string text)
        {
            return await Task.Run(() => Execute(text, false));
        }
        public string Execute(string text, bool encryption)
        {
            StringBuilder output = new StringBuilder(text.Length);
            Key = Key.ToUpperInvariant();

            int flag = 0;
            foreach (var letter in text)
            {
                int letterIndex = Array.IndexOf(Alphabet.alphabet, char.ToUpper(letter));

                if (letterIndex >= 0)
                {
                    if (encryption)
                    {
                        letterIndex += Array.IndexOf(Alphabet.alphabet, Key[flag]);
                    }
                    else
                    {
                        letterIndex -= Array.IndexOf(Alphabet.alphabet, Key[flag]);
                    }

                    if ((letterIndex %= Alphabet.alphabet.Length) < 0)
                    {
                        letterIndex += Alphabet.alphabet.Length;
                    }

                    output.Append(Char.IsUpper(letter)
                        ? Alphabet.alphabet[letterIndex]
                        : char.ToLower(Alphabet.alphabet[letterIndex]));

                    flag++;
                    if (flag == Key.Length)
                    {
                        flag = 0;
                    }
                }
                else
                {
                    output.Append(letter);
                }


            }
            return output.ToString();
        }
    }
}
