using System.Text;

namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    text.Append(input[i]);
                }
            }
            return text.ToString();
        }
    }
}