using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Raet.Recruitment.Algorithmic.StringCompression
{
    [TestClass()]
    public class CompressorTests
    {
        private Compressor _stringCompressor;

        [TestInitialize]
        public void Initialize()
        {
            _stringCompressor = new Compressor();
        }

        [TestMethod]
        public void givenEmptyInput_whenCompress_thenReturnEmpty()
        {
            var toAssert = _stringCompressor.Compress(null);
            Assert.AreEqual(string.Empty, toAssert);
        }

        [TestMethod]
        public void givenInput_whenCompress_thenReturnCommpressed()
        {
            var toAssert = _stringCompressor.Compress("aabcccccaaa");
            Assert.AreEqual(toAssert, "a2b1c5a3");
        }

        [TestMethod]
        public void givenInputWithGreaterThanTenRepetitions_whenCompress_thenReturnCommpressed()
        {
            var toAssert = _stringCompressor.Compress("aabccccccccccccccccaaadee");
            Assert.AreEqual(toAssert, "a2b1c0c6a3d1e2");
        }

        [TestMethod]
        public void givenUncompressibleInput_whenCompress_thenReturnSameValue()
        {
            var toAssert = _stringCompressor.Compress("xweeptbb");
            Assert.AreEqual(toAssert, "xweeptbb");
        }
    }
}
