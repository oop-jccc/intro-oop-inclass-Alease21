namespace intro_oop;

public class BasicMusicPlayer : ITrackPlayer
{
    public void PlayTrack(string trackId)
    {
        Console.WriteLine($"Playing track with ID: {trackId}");
    }
}