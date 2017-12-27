using ReadFromImage.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromImage
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = string.Empty;
            var bitMap = new Bitmap(filePath);
            var finalString = ImageParser.GetTextFromImage(bitMap);
            Console.WriteLine(finalString);
        }
    }
}
