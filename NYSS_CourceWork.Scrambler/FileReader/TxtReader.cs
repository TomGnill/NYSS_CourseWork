using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYSS_CourceWork.Scrambler.FileReader
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
            return File.ReadAllText(Path, Encoding.GetEncoding(1251));
        }

        public void Write(string text)
        {
            File.WriteAllText(Path, text);
        }
    }
}
