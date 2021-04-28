using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NYSS_CourceWork.Scrambler;

namespace NYSS_CourceWork.Client.Data
{
    public class ScramblerMaster
    {
        public async Task<string> GetDecryption(string key, string text, Alphabet alphabet)
        {
            return await new Scrambler.Scrambler(key, alphabet).Decrypt(text);
        }
        public async Task<string> GetEncryption(string key, string text, Alphabet alphabet)
        {
            return await new Scrambler.Scrambler(key, alphabet).Encrypt(text);
        }
    }
}
