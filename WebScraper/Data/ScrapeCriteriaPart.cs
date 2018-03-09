using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebScraper.Data
{
    class ScrapeCriteriaPart
    {
        public string Regex { set; get; }
        public RegexOptions RegexOption { set; get; }
    }
}
