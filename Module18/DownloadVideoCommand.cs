using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18
{
    public class DownloadVideoCommand : YoutubeCommand
    {
        string OutputFilePath;
        public DownloadVideoCommand(string videoURL, string outputFilePath) : base(videoURL)
        {
            OutputFilePath = outputFilePath;
        }

        public override async Task Run()
        {
            var youtube = new YoutubeClient();
            try
            {
                Console.WriteLine("\nЗагрузка видео...");

                var progress = new Progress<double>(p => Console.Title = $"Download progress: [{p:P0}]");
                var video = await youtube.Videos.GetAsync(VideoURL);

                await youtube.Videos.DownloadAsync(VideoURL, $"{OutputFilePath}\\{video.Title}.mp4",
                    builder => builder.SetPreset(ConversionPreset.UltraFast), progress);

                Console.WriteLine("\nЗагрузка завершена!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
