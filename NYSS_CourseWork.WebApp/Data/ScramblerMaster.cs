using System.Threading.Tasks;
using NYSS_CourseWork.Scrambler;

namespace NYSS_CourseWork.WebApp.Data
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
