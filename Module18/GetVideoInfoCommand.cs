using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Module18
{
    public class GetVideoInfoCommand : YoutubeCommand
    {
        public GetVideoInfoCommand(string videoURL) : base(videoURL) { }

        public override async Task Run()
        {
            var youtube = new YoutubeClient();

            try
            {
                var video = await youtube.Videos.GetAsync(VideoURL);

                Console.WriteLine("\nНазвание видео: " + video.Title);
                Console.WriteLine("Описание видео: " + video.Description);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
