namespace intro_oop;

internal static class Program
{
    private static void Main(string[] args)
    {
        IPlayMusic basicPlayer = new BasicMusicPlayer();
        var advancedPlayer = new AdvancedMusicPlayer();
                
        advancedPlayer.PlayTrack("456"); // This should work fine
        advancedPlayer.CreatePlaylist("MyAdvancedPlaylist"); // This should work fine
    }
}