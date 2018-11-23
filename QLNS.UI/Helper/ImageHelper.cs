using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.UI.Helper
{
    public static class ImageHelper
    {
        /// <summary>
        /// Function to convert image to binary array
        /// </summary>
        /// <param name="fileName">full file name including path</param>
        /// <returns></returns>
        public static byte[] ConvertImgToByte(string fileName)
        {
            FileStream fs;
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        /// <summary>
        /// Function to convert image to binary array string to save to database
        /// </summary>
        /// <param name="fileName">full file name including path</param>
        /// <returns></returns>
        public static string ConvertImgToByteString(string fileName)
        {
            return Convert.ToBase64String(ConvertImgToByte(fileName));
        }
        /// <summary>
        /// Function to convert binary array string to image
        /// </summary>
        /// <param name="byteString"></param>
        /// <returns></returns>
        public static Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }
}
