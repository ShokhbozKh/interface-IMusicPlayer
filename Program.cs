namespace misol6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicPlayer player = new MusicPlayer();
            player.Play();
            player.Pause();
            player.Stop();
        }
    }
    public interface IPlayer
    {
        void Play();
        void Pause();
        void Stop();

    }
    public class MusicPlayer : IPlayer
    {
        public void Play()
        {
            Console.WriteLine("Playing music");
        }
        public void Pause()
        {
            Console.WriteLine("Pausing music");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping music");
        }
    }
}