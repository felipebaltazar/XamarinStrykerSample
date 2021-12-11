using System.Text.RegularExpressions;

namespace StrykerSample
{
    public class MyViewModel
    {
        private readonly Regex _cpfMask = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", RegexOptions.Compiled);

        public bool IsValidCPF(string cpfInput)
        {
            if (string.IsNullOrWhiteSpace(cpfInput))
                return false;

            return _cpfMask.Match(cpfInput).Success;
        }
    }
}
