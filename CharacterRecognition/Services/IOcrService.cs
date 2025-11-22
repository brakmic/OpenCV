using System.Runtime.Versioning;

namespace OcrApp.Services
{
    [SupportedOSPlatform("windows6.1")]
    public interface IOcrService
    {
        string ExtractText(string imagePath);
    }
}
