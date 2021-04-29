using System.Threading.Tasks;

namespace NYSS_CourseWork.Scrambler.FileReader
{
    public interface IFileReader
    {
        public async Task<string> AsyncRead() => await Task.Run(Read);

        public async Task AsyncWrite(string text) => await Task.Run(() => Write(text));

        public string Read();

        public void Write(string text);
    }
}
