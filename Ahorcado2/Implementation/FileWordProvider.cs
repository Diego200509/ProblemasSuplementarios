using System.IO;

namespace Ahorcado2
{
    public class FileWordProvider : IWordProvider
    {
        private readonly string _filePath;
        public FileWordProvider(string filePath)
        {
            _filePath = filePath;
        }

        public string GetWord()
        {
            var lines = File.ReadAllLines(_filePath);
            return lines[new Random().Next(lines.Length)].Trim().ToLower();
        }
    }
}