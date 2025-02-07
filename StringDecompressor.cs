namespace lab3
{
    public class StringDecompressor
    {
        public string Decompress(string compressed)
        {
            if (string.IsNullOrEmpty(compressed)) return compressed;

            var decompressed = new System.Text.StringBuilder();

            int i = 0;

            while (i < compressed.Length)
            {
                char character = compressed[i]; // Extract character
                i++;

                if (i >= compressed.Length || !char.IsDigit(compressed[i]))
                    throw new FormatException("Invalid compressed format.");

                int count = 0;
                while (i < compressed.Length && char.IsDigit(compressed[i])) // Handle multi-digit numbers
                {
                    count = count * 10 + (compressed[i] - '0');
                    i++;
                }

                decompressed.Append(character, count); // Append character count times
            }

            return decompressed.ToString();
        }
    }
}