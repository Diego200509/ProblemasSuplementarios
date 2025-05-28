using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
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