using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureResizer {
    internal class Photo {
        private long allowedFileSize; // filesize in KB
        private long finalFileSize = 0;
        private readonly PropertyItem originalOrientation;
        private const int OrientationId = 0x0112;
        private int quality = 90;
        private ImageCodecInfo codec; // = ImageCodecInfo.GetImageEncoders()[1];
        private ImageFormat imageFormat; // = ImageFormat.Jpeg;

        internal Image originalPhoto { get; }
        internal Image targetPhoto;


        internal void SetQuality(int value) {
            this.quality = value;
        }

        internal void SetSourceInfo(string sourceFile) {
            FileInfo fi = new FileInfo(sourceFile);

            switch (fi.Extension) {
                case ".bmp":
                    this.codec = ImageCodecInfo.GetImageEncoders()[0];
                    this.imageFormat = ImageFormat.Bmp;
                    break;
                case ".gif":
                    this.codec = ImageCodecInfo.GetImageEncoders()[2];
                    this.imageFormat = ImageFormat.Gif;
                    break;
                case ".tiff":
                    this.codec = ImageCodecInfo.GetImageEncoders()[3];
                    this.imageFormat = ImageFormat.Tiff;
                    break;
                case ".png":
                    this.codec = ImageCodecInfo.GetImageEncoders()[4];
                    this.imageFormat = ImageFormat.Png;
                    break;
                default: // this includes JPG
                    this.codec = ImageCodecInfo.GetImageEncoders()[1];
                    this.imageFormat = ImageFormat.Jpeg;
                    break;
            }
        }

        internal void SetAllowedFileSize(int SizeInKiloBytes) {
            this.allowedFileSize = SizeInKiloBytes * 1024; //size in bytes
        }

        internal Photo(Image sourceImage) {
            this.originalPhoto = new Bitmap(sourceImage);
            using (Image getOrientation = sourceImage) {
                if (getOrientation.PropertyIdList.Contains(OrientationId)) {
                    this.originalOrientation = getOrientation.GetPropertyItem(OrientationId);
                }
            }
        }

        internal void ScalePhoto() {
            using (MemoryStream ms = new MemoryStream()) {
                using (Image tempImage = originalPhoto) {
                    Bitmap bmp = (Bitmap)tempImage;
                    SaveTemporary(bmp, ms);

                    while (ms.Length < 0.9 * this.allowedFileSize || ms.Length > this.allowedFileSize) {
                        double scale = Math.Sqrt((double)this.allowedFileSize / (double)ms.Length);
                        ms.SetLength(0);
                        bmp = ScalePhoto(bmp, scale);
                        SaveTemporary(bmp, ms);
                    }

                    if (bmp != null) {
                        bmp.Dispose();
                        this.targetPhoto = new Bitmap( Image.FromStream(ms));
                    }
                }
                finalFileSize = ms.Length;
            }
        }

        private Bitmap ScalePhoto(Bitmap image, double scale) {
            int newWidth = (int)(image.Width * scale);
            int newHeight = (int)(image.Height * scale);

            Bitmap result = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);
            result.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(result)) {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                g.DrawImage(image, 0, 0, result.Width, result.Height);
            }
            return result;
        }

        private void SaveTemporary(Bitmap bmp, MemoryStream ms) {
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            var encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;

            if (this.originalOrientation != null) {
                bmp.SetPropertyItem(this.originalOrientation);
            }

            if (codec != null)
                bmp.Save(ms, codec, encoderParams);
            else
                bmp.Save(ms, imageFormat);
        }

        internal void SaveFile(string fileName) {
            Bitmap saveFile = new Bitmap(this.targetPhoto);
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            var encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;

            if (this.originalOrientation != null) {
                saveFile.SetPropertyItem(this.originalOrientation);
            }

            if (codec != null)
                saveFile.Save(fileName, codec, encoderParams);
            else
                saveFile.Save(fileName, imageFormat);
        }
    }
    }

