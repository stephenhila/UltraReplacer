using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraReplacer.Core.Models
{
    public class ReplaceOptions
    {
        public List<Replacement> Replacements { get; set; }
        public char[] TrimmedChars { get; set; }

        public ReplaceOptions()
        {
            Replacements = new List<Replacement>();
        }
    }
}
