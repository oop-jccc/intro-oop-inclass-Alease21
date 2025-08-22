namespace intro_oop;

public class AdvancedMusicPlayer : ITrackPlayer, IPlaylistCreator
{
    public void PlayTrack(string trackId)
    {
        Console.WriteLine($"Playing track with ID: {trackId}");
    }

    public void CreatePlaylist(string playlistName)
    {
        Console.WriteLine($"Creating playlist with name: {playlistName}");
    }
}