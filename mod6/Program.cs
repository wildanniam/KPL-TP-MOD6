namespace mod6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Wildan Syukri Niam]");
            video.IncreasePlayCount(26);
            video.PrintVideoDetails();
        }
    }
}