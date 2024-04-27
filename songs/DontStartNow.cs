using LyricsCinema;

public class DontStartNow
{
    public static void RegisterLyrics()
    {
        // Simulated LRC format embedded in the code for clarity
        var lrcLyrics = new List<(string Time, string Line)>
        {
            ("00:00.96", "If you don't wanna see me"),
            ("00:07.07", "Did a full 180, crazy"),
            ("00:12.12", "Thinking 'bout the way I was"),
            ("00:15.48", "Did the heartbreak change me? Maybe"),
            ("00:19.99", "But look at where I ended up"),
            ("00:22.92", "I'm all good already"),
            ("00:25.57", "So moved on, it's scary"),
            ("00:27.43", "I'm not where you left me at all, so"),
            ("00:31.16", "If you don't wanna see me dancing with somebody"),
            ("00:36.46", "If you wanna believe that anything could stop me"),
            ("00:44.96", "Don't show up, don't come out"),
            ("00:50.28", "Don't start caring about me now"),
            ("00:54.26", "Walk away, you know how"),
            ("00:58.25", "Don't start caring about me now"),
            ("01:01.70", "Aren't you the guy who tried to"),
            ("01:06.37", "Hurt me with the word \"goodbye\"?"),
            ("01:08.94", "Though it took some time to survive you"),
            ("01:13.99", "I'm better on the other side"),
            ("01:16.91", "I'm all good already"),
            ("01:19.48", "So moved on, it's scary"),
            ("01:21.33", "I'm not where you left me at all, so"),
            ("01:25.32", "If you don't wanna see me dancing with somebody"),
            ("01:31.17", "If you wanna believe that anything could stop me"),
            ("01:38.86", "Don't show up, don't come out"),
            ("01:44.44", "Don't start caring about me now"),
            ("01:48.70", "Walk away, you know how"),
            ("01:52.41", "Don't start caring about me now ('bout me now, 'bout me)"),
            ("01:55.34", "Oh, oh"),
            ("01:58.68", "Don't come out, out, out"),
            ("02:00.81", "Don't show up, up, up"),
            ("02:03.19", "Don't start now (oh)"),
            ("02:04.53", "Oh, oh"),
            ("02:06.65", "Don't come out, out"),
            ("02:08.41", "I'm not where you left me at all, so"),
            ("02:11.86", "If you don't wanna see me dancing with somebody"),
            ("02:20.53", "If you wanna believe that anything could stop me"),
            ("02:27.16", "Don't show up (don't show up), don't come out (don't come out)"),
            ("02:31.15", "Don't start caring about me now ('bout me now)"),
            ("02:35.13", "Walk away (walk away), you know how (you know how)"),
            ("02:39.12", "Don't start caring about me now (so)"),
            ("02:42.58", "Oh, oh"),
            ("02:45.69", "Don't come out, out, out"),
            ("02:47.20", "Don't show up, up, up"),
            ("02:49.57", "Walk away, walk away (so)"),
            ("02:51.61", "Oh, oh"),
            ("02:53.20", "Don't come out, out, out"),
            ("02:55.33", "Don't show up, up, up"),
            ("02:56.82", "Walk away, walk away, oh"),
        };

        List<float> timings = new List<float>();
        List<string> lines = new List<string>();

        foreach (var (time, line) in lrcLyrics)
        {
            timings.Add(Main.ParseLRCTime(time));
            lines.Add(line);
        }

        Main.RegisterSong("dont-start-now", (timings.ToArray(), lines.ToArray()));
    }

}
