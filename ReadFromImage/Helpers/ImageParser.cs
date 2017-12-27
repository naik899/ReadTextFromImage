using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace ReadFromImage.Helpers
{
    public class ImageParser
    {
        internal static string GetTextFromImage(Bitmap imgsource)
        {
            try
            {
                var ocrtext = string.Empty;
                var tessdataPath = string.Empty; // this should contain the tess data in the folder tessdata
                var engine = new TesseractEngine(tessdataPath, "eng");
                using (var img = PixConverter.ToPix(imgsource))
                {
                    using (var page = engine.Process(img))
                    {
                        ocrtext = page.GetText();
                    }
                }

                return ocrtext;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception at GetTextFromImage: " + ex.ToString());

                return ex.ToString();
            }
        }
    }
}
