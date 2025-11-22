using System;
using System.Runtime.Versioning;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Microsoft.Extensions.Options;
using OcrApp.Configuration;

namespace OcrApp.Services
{
    [SupportedOSPlatform("windows6.1")]
    public class OcrService : IOcrService
    {
        private readonly OcrOptions options;
        private readonly string tessdataPath;

        public OcrService(IOptions<OcrOptions> options)
        {
            this.options = options.Value;
            tessdataPath = System.IO.Path.IsPathRooted(this.options.TessdataPath)
                ? this.options.TessdataPath
                : System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, this.options.TessdataPath);
        }

        public string ExtractText(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                throw new ArgumentException("Image path cannot be null or empty");
            }

            using var img = new Image<Bgr, byte>(imagePath);
            using var ocrProvider = new Tesseract(tessdataPath, options.Language, options.EngineMode);
            ocrProvider.SetImage(img);
            ocrProvider.Recognize();
            return ocrProvider.GetUTF8Text().TrimEnd();
        }
    }
}
