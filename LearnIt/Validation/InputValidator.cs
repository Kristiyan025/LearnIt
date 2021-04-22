namespace LearnIt.Validation
{
    public static class InputValidator
    {
        public static bool IsOnlyFromLettersAndSpaces(string s)
        {
            foreach (char c in s)
            {
                if (!(char.IsLetter(c) || c == ' ')) return false;
            }

            return true;
        }

        public static bool ContainsSpaces(string s)
        {
            foreach (char c in s)
            {
                if (c == ' ') return true;
            }

            return false;
        }
    }
}
