using QRCoder;
using System;
using System.Drawing;
using System.IO;

namespace Hometown_Application.Helpers
{
    public class QRCodeHelper
    {
        public string GenerateQRCode(string data)
        {
            // Create the QRCodeGenerator object
            var qrGenerator = new QRCodeGenerator();

            // Generate QR code data
            var qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);

            // Create a QRCode from the QR code data
          // -- var qrCode = new QRCode(qrCodeData);

            // Generate the QR code image with pixel size of 20
           // --var qrImage = qrCode.GetGraphic(20);

            using (var memoryStream = new MemoryStream())
            {
                // Save the QR image to the memory stream
             //  -- qrImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                // Convert the image to a byte array and then to a Base64 string
                var byteArray = memoryStream.ToArray();

                return Convert.ToBase64String(byteArray); // Return Base64 encoded string
            }
        }
    }
}
