using System;

namespace FactoryMethodPattern 
{
    public interface IImageReader 
    {
        DecodedImage GetDecodedImage();
    }

    public class DecodedImage 
    {
        private string image;
        public DecodedImage(string image)
        {
            this.image = image;
        }

        override public string ToString()
        {
            return image + " decoded image";
        }
    }

    public class GifReader : IImageReader 
    {
        private DecodedImage _decodedImage;
        public GifReader(string image)
        {
            _decodedImage = new DecodedImage(image);
        }

        public DecodedImage GetDecodedImage()
        {
            return _decodedImage;
        }
    }
    public class JpegReader : IImageReader 
    {
        private DecodedImage _decodedImage;
        public JpegReader(string image)
        {
            _decodedImage = new DecodedImage(image);
        }

        public DecodedImage GetDecodedImage()
        {
            return _decodedImage;
        }
    }
}