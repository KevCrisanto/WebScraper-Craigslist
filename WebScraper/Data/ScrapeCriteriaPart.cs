using System.Text.RegularExpressions;

namespace WebScraper.Data
{
    class ScrapeCriteriaPart
    {
        public string Regex { set; get; }
        public RegexOptions RegexOption { set; get; }
    }
}
