using SkiaSharp;
using SkiaSharp.QrCode;
using System.IO;
using TwoFactorAuthNet.Providers.Qr;

namespace TwoFactorAuthNetSkiaSharpQrProvider
{
    /// <summary>
    /// QR Code Provider for TwoFactorAuth.Net using SkiaSharp
    /// </summary>
    public class SkiaSharpQrCodeProvider : IQrCodeProvider
    {
        /// <summary>
        /// Return the mime type of the generated image
        /// </summary>
        /// <returns>image/png</returns>
        public string GetMimeType()
        {
            return "image/png";
        }

        /// <summary>
        /// Get a byte array for the QR Code image
        /// </summary>
        /// <param name="text">Text to be encoded</param>
        /// <param name="size">Image size</param>
        /// <returns>Image bytes</returns>
        public byte[] GetQrCodeImage(string text, int size)
        {
            byte[] result;
            using (var generator = new QRCodeGenerator())
            {
                // Generate QrCode
                QRCodeData qr = generator.CreateQrCode(text, ECCLevel.L);

                // Render to canvas
                var info = new SKImageInfo(size, size);
                using (SKSurface surface = SKSurface.Create(info))
                {
                    SKCanvas canvas = surface.Canvas;
                    canvas.Render(qr, info.Width, info.Height, new SKColor(255,255,255));

                    // Output to Stream -> Array
                    using (var image = surface.Snapshot())
                    {
                        using (var data = image.Encode(SKEncodedImageFormat.Png, 100))
                        {
                            using (var stream = new MemoryStream())
                            {
                                data.SaveTo(stream);
                                result = stream.ToArray();
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
