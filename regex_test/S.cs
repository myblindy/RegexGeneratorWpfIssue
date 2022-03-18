using System.Text.RegularExpressions;

static partial class S
{
    [RegexGenerator(@"\w:\w")]
    public static partial Regex CompactAtaRegex();
}