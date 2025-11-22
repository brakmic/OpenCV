using Emgu.CV.OCR;

namespace OcrApp.Configuration
{
    public class OcrOptions
    {
        public const string SectionName = "Ocr";

        public string TessdataPath { get; set; } = "tessdata";
        public string Language { get; set; } = "eng";
        public OcrEngineMode EngineMode { get; set; } = OcrEngineMode.Default;
    }
}
