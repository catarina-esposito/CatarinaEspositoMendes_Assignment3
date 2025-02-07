namespace lab3
{
    public class StringCompressor
    {
        public string Compress(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            var compressed = new System.Text.StringBuilder();
            int count = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                }
                else
                {
                    compressed.Append(str[i - 1]).Append(count);
                    count = 1;
                }
            }

            compressed.Append(str[^1]).Append(count);

            if (compressed.Length < str.Length)
            {
                return compressed.ToString();
            }
            else
            {
                return str;
            }
        }
    }
}