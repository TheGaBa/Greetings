using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.AI.MachineLearning;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Greetings.Helpers
{
    public static class ImageConverter
    {
        public static async Task<BitmapImage> GetBitmapAsync(byte[] data)
        {
            if (data == null) return null;

            var bitmapImage = new BitmapImage();

            using (var stream = new InMemoryRandomAccessStream())
            {
                using (var writer = new DataWriter(stream))
                {
                    writer.WriteBytes(data);
                    await writer.StoreAsync();
                    await writer.FlushAsync();
                    writer.DetachStream();
                }

                stream.Seek(0);
                await bitmapImage.SetSourceAsync(stream);
            }

            return bitmapImage;
        }

        private static async Task<ImageSource> GetImageSourceAsync(byte[] data) => await GetBitmapAsync(data);

        //public static async Task<ImageSource[]> GetImagesSourceAsync(List<byte[]> list) => await Task.WhenAll(list.ConvertAll(GetImageSourceAsync));

        internal static async Task<List<Task<ImageSource>>> GetImagesSourceAsync(Task<List<byte[]>> imagesData)
        {
            List<Task<ImageSource>> source = new List<Task<ImageSource>>();
            foreach (var item in await imagesData)
            {
                source.Add(GetImageSourceAsync(item));
            }

            return source;
        }

        internal static async Task<List<ImageSource>> CreateImageSources(List<byte[]> imagesData)
        {
            List<ImageSource> imageSources = new List<ImageSource>();

            foreach (var item in imagesData)
            {
                imageSources.Add(await GetImageSourceAsync(item));    
            }

            return imageSources;
        }
    }
}