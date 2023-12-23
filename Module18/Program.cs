namespace Module18
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Введите ссылку на Youtube-видео:");
            string videoUrl = Console.ReadLine();

            Console.WriteLine("\nВведите путь для сохранения видео:");
            string outputFilePath = Console.ReadLine();

            var youtubeSender = new YoutubeSender();

            var firstCommand = new GetVideoInfoCommand(videoUrl);
            var secondCommand = new DownloadVideoCommand(videoUrl, outputFilePath);

            youtubeSender.AddCommand(firstCommand);
            youtubeSender.AddCommand(secondCommand);

            await youtubeSender.Run();

            Console.WriteLine("\nНажмите Enter, чтобы закрыть приложение.");
            Console.ReadLine();
        }
    }    
}