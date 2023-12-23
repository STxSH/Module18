namespace Module18
{
    public class YoutubeSender
    {
        List<YoutubeCommand> commands = new List<YoutubeCommand>();

        public void AddCommand(YoutubeCommand youtubeCommand)
        {
            commands.Add(youtubeCommand);
        }

        public async Task Run()
        {
            foreach (var item in commands)
            {
                await item.Run();
            }
        }
    }
}
