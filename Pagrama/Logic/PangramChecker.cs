using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Pagrama.Logic
{
    public class PangramChecker : IPangramChecker
    {
        private static readonly HashSet<char> SaxonAlphabet = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");

        public bool IsPangram(string sentence)
        {
            string normalized = RemoveDiacritics(sentence.ToLower());
            HashSet<char> foundLetters = new HashSet<char>();

            foreach (char c in normalized)
            {
                if (SaxonAlphabet.Contains(c))
                {
                    foundLetters.Add(c);
                }
            }

            return foundLetters.Count == SaxonAlphabet.Count;
        }

        public int CountValidCharacters(string sentence)
        {
            int count = 0;
            string normalized = RemoveDiacritics(sentence.ToLower());

            foreach (char c in normalized)
            {
                if (SaxonAlphabet.Contains(c))
                    count++;
            }
            return count;
        }

        private string RemoveDiacritics(string text)
        {
            var normalized = text.Normalize(NormalizationForm.FormD);
            var filtered = new StringBuilder();

            foreach (char c in normalized)
            {
                var unicode = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicode != UnicodeCategory.NonSpacingMark)
                {
                    filtered.Append(c);
                }
            }

            return filtered.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}