namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        ITrackPlayer basicPlayer = new BasicMusicPlayer();
        var advancedPlayer = new AdvancedMusicPlayer();

        basicPlayer.PlayTrack("123"); // This should work fine

        advancedPlayer.PlayTrack("456"); // This should work fine
        advancedPlayer.CreatePlaylist("MyAdvancedPlaylist"); // This should work fine
    }
}