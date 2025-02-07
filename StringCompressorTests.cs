namespace lab3
{
    [TestClass]
    public sealed class StringCompressorTests
    {
        [TestMethod]
        public void Handle_Compressor_EmptyString()
        {
            var compressor = new StringCompressor();
            Assert.AreEqual("", compressor.Compress(""));
        }

        [TestMethod]
        public void Handle_Compressor_NoConsecutiveCharacters()
        {
            var compressor = new StringCompressor();
            Assert.AreEqual("abcab", compressor.Compress("abcab"));
        }

        [TestMethod]
        public void Handle_Compressor_ConsecutiveCharacters()
        {
            var compressor = new StringCompressor();
            Assert.AreEqual("a1b2c3d4", compressor.Compress("abbcccdddd"));
        }

        [TestMethod]
        public void Handle_Compressor_NoCompressor()
        {
            var compressor = new StringCompressor();
            Assert.AreEqual("abcde", compressor.Compress("abcde"));
        }

        [TestMethod]
        public void Handle_Compressor_ManyConsecutiveCharacters()
        {
            var compressor = new StringCompressor();
            Assert.AreEqual("a10", compressor.Compress("aaaaaaaaaa"));
        }

        [TestMethod]
        public void Handle_Decompress_EmptyString()
        {
            var decompressor = new StringDecompressor();
            Assert.AreEqual("", decompressor.Decompress(""));
        }

        [TestMethod]
        public void Handle_Decompress_ConsecutiveCharacters()
        {
            var decompressor = new StringDecompressor();
            Assert.AreEqual("abbcccdddd", decompressor.Decompress("a1b2c3d4"));
        }

        [TestMethod]
        public void Handle_Decompress_ManyConsecutiveCharacters()
        {
            var decompressor = new StringDecompressor();
            Assert.AreEqual("aaaaaaaaaa", decompressor.Decompress("a10"));
        }
    }
}