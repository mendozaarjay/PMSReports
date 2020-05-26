using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Reports
{
    public static class ImageHelper
    {
        public static byte[] ConvertImageToByte(Image image)
        {
            byte[] returnThis;
            try
            {
                using(MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    returnThis = ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return returnThis;
        }
        public static Image ConvertByteToImage(byte[] imageArray)
        {
            Image image;
            using(MemoryStream ms = new MemoryStream(imageArray))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }
    }
}
