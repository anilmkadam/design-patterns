using System;
using Xunit;

namespace FactoryMethodPattern.Tests
{
    public class FactoryMethodPatternTests
    {
        [Fact]
        public void GifReaderObject_Success()
        {
            DecodedImage decodedImage;
            IImageReader reader = null;

            string image = "anil.gif";

            string format = image.Substring(image.IndexOf('.') + 1);
            if (format.Equals("gif"))
            {
                reader = new GifReader(image);
            }

            Assert.NotNull(reader);
            Assert.IsType<GifReader>(reader);
        }

        [Fact]
        public void JpegReaderObject_Success()
        {
            DecodedImage decodedImage;
            IImageReader reader = null;

            string image = "anil.jpeg";

            string format = image.Substring(image.IndexOf('.') + 1);
            if (format.Equals("jpeg"))
            {
                reader = new JpegReader(image);
            }

            Assert.NotNull(reader);
            Assert.IsType<JpegReader>(reader);
        }
    }
}
