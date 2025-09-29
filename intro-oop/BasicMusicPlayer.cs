namespace intro_oop;

public class BasicMusicPlayer : IPlayMusic
{
    public void PlayTrack(string trackId)
    {
        Console.WriteLine($"Playing track with ID: {trackId}");
    }
}