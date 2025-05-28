using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class FileWordPicker : IWordPicker
    {
        public string FilePath { get; set; }
        private string[]? _words;
        public FileWordPicker(string filePath)
        {
            this.FilePath = filePath;
            SetWords();
        }

        private void SetWords()
        {
            List<string> list = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(this.FilePath);
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
                this._words = list.ToArray();
            }
            catch (System.Exception)
            {
                this._words = null;
                throw;
            }

        }
        public string PickRandomWord()
        {
            if (_words == null || _words.Length == 0)
            {
                SetWords();
            }
            return this._words[new Random().Next(0, this._words.Length)];
        }
    }
}
