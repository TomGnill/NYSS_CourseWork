using System.IO;
using System.Text;

namespace NYSS_CourseWork.Scrambler.FileReader
{
    public class TxtReader : IFileReader
    {
        private string Path { get; }

        public TxtReader(string path)
        {
            Path = path;
        }

        public string Read()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            return File.ReadAllText(Path, Encoding.UTF8);
        }

        public void Write(string text)
        {
            File.WriteAllText(Path, text);
        }
    }
}
