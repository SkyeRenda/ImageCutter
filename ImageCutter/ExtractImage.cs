using MediaToolkit.Model;
using MediaToolkit.Options;
using MediaToolkit;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using System.IO;

namespace ImageCutter
{

    public class ExtractImage
    {

        public static void extractImage(string filePath, int interval, IProgress<int> progress)

        {
            string directoryPath = Path.GetDirectoryName(filePath) ?? "";
            string newDirectoryPath = Path.Combine(directoryPath, "images");

            // Create the 'images' directory if it doesn't exist
            if (!Directory.Exists(newDirectoryPath))
            {
                Directory.CreateDirectory(newDirectoryPath);
            }
            using (var engine = new Engine())
            {
                var mp4 = new MediaFile { Filename = filePath };

                engine.GetMetadata(mp4);
                double duration = mp4.Metadata.Duration.TotalSeconds;
                //error.ForeColor = Color.Black;
                var i = 0;

                while (i < duration)
                {
                    progress.Report((int)(i / duration * 100));
                    var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(i) };
                    var outputFile = new MediaFile { Filename = string.Format("{0}\\image-{1}.jpeg", newDirectoryPath, i) };
                    engine.GetThumbnail(mp4, outputFile, options);
                    i = i + interval;
                }
            }

        }
    }
}