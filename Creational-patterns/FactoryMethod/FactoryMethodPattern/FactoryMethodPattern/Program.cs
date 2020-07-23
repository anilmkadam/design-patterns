using System;

namespace FactoryMethodPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DecodedImage decodedImage;
            IImageReader reader = null;

            string image  = "anil.gif";
            string format = image.Substring(image.IndexOf('.') + 1);

            if (format.Equals("gif")) 
            {
                reader = new GifReader(image);
            }
            if (format.Equals("jpeg")) 
            {
                reader = new JpegReader(image);
            }

            if(reader != null)
            {
                decodedImage = reader.GetDecodedImage();
                Console.WriteLine(decodedImage.ToString());
            }
        }
    }
}
