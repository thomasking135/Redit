using System;
using System.Threading.Tasks;

namespace REDIT
{
    internal class StreamReader : System.IO.StreamReader
    {
        public StreamReader(string path) : base(path)
        {
        }

        internal Task WriteLineAsync(string text)
        {
            throw new NotImplementedException();
        }
    }
}