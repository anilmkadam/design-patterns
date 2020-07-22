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

            string image  = args[0];
            string format = image.Substring(image.IndexOf('.'));

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
                Console.WriteLine("Inside if");
                decodedImage = reader.GetDecodedImage();
                Console.WriteLine(decodedImage.ToString());
            }
            Console.WriteLine("Outside if");
        }
    }
}
