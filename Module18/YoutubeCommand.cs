namespace Module18
{
    public abstract class YoutubeCommand
    {
        public string VideoURL;

        public YoutubeCommand(string videoURL)
        {
            VideoURL = videoURL;
        }

        public abstract Task Run();
    }
}
