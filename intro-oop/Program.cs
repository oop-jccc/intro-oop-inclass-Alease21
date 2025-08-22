namespace intro_oop;

internal static class Program
{
    private static void Main(string[] args)
    {
        IMusicApp basicPlayer = new BasicMusicPlayer();
        IMusicApp advancedPlayer = new AdvancedMusicPlayer();
        
        basicPlayer.PlayTrack("123"); // This should work fine
        try
        {
            basicPlayer.CreatePlaylist("MyPlaylist"); // This should throw a NotImplementedException
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Basic player cannot create playlists.");
        }
        
        advancedPlayer.PlayTrack("456"); // This should work fine
        advancedPlayer.CreatePlaylist("MyAdvancedPlaylist"); // This should work fine
    }
}