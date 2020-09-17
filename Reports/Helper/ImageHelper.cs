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
                    var item = new Bitmap(image, new Size(50, 50));
                    item.Save(ms, ImageFormat.Jpeg);
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
        public static Bitmap ConvertByteToImageWithResizing(byte[] imageArray)
        {
            Bitmap bitmap;
            using (MemoryStream ms = new MemoryStream(imageArray))
            {
                var image = Image.FromStream(ms);
                int width = (int) image.Width / 4;
                int height = (int) image.Height / 4;

                bitmap = new Bitmap(image, new Size(width, height));
            }
            return bitmap;
        }
    }
}
