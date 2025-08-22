namespace intro_oop;

public class BasicMusicPlayer : IMusicApp
{
    public void PlayTrack(string trackId)
    {
        Console.WriteLine($"Playing track with ID: {trackId}");
    }

    public void CreatePlaylist(string playlistName)
    {
        // This basic player isn't supposed to create playlists, but it has to implement this method due to ISP violation
        throw new NotImplementedException();
    }
}