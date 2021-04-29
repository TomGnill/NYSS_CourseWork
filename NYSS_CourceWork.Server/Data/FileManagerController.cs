using System.Threading.Tasks;
using NYSS_CourseWork.Scrambler.FileReader;

namespace NYSS_CourseWork.Server.Data
{
    public class FileManagerController
    {
        public async Task SaveTxtFile(string filePath, string text)
        {
            IFileReader newReader = new TxtReader(filePath);
            await newReader.AsyncWrite(text);
        }
        public async Task<string> ReadTxtFile(string filePath)
        {
            IFileReader newReader = new TxtReader(filePath);
            return await newReader.AsyncRead();
        }
    }
}
