using LyricsCinema;

public class CheapThrills
{
    public static void RegisterLyrics()
    {
        // Simulated LRC format embedded in the code for clarity
        var lrcLyrics = new List<(string Time, string Line)>
        {
            // Source: https://www.megalobiz.com/lrc/maker/Cheap+Thrills.55311536
            ("00:10.90", "Come on, come on, turn the radio on"),
            ("00:13.54", "It's Friday night, and it won't be long"),
            ("00:16.05", "Gotta do my hair, put my make-up on"),
            ("00:19.04", "It's Friday night, and it won't be long"),
            ("00:21.04", "'Til I hit the dance floor, hit the dance floor"),
            ("00:24.29", "I got all I need"),
            ("00:26.54", "No, I ain't got cash, I ain't got cash"),
            ("00:29.54", "But I got you, baby"),
            ("00:32.33", "Baby, I don't need dollar bills to have fun tonight"),
            ("00:35.97", "(I love cheap thrills)"),
            ("00:37.23", "Baby, I don't need dollar bills to have fun tonight"),
            ("00:41.48", "(I love cheap thrills)"),
            ("00:42.98", "But I don't need no money"),
            ("00:48.22", "As long as I can feel the beat"),
            ("00:53.73", "I don't need no money"),
            ("00:58.97", "As long as I keep dancing"),
            ("01:04.22", "Come on, come on, turn the radio on"),
            ("01:06.98", "It's Saturday, and it won't be long"),
            ("01:09.48", "Gotta paint my nails, put my high heels on"),
            ("01:12.23", "It's Saturday, and it won't be long"),
            ("01:14.73", "'Til I hit the dance floor, hit the dance floor"),
            ("01:17.98", "I got all I need"),
            ("01:19.88", "No, I ain't got cash, I ain't got cash"),
            ("01:22.89", "But I got you, baby"),
            ("01:25.38", "Baby, I don't need dollar bills to have fun tonight"),
            ("01:29.39", "(I love cheap thrills)"),
            ("01:30.63", "Baby, I don't need dollar bills to have fun tonight"),
            ("01:34.64", "(I love cheap thrills)"),
            ("01:36.14", "But I don't need no money"),
            ("01:41.38", "As long as I can feel the beat"),
            ("01:46.88", "I don't need no money"),
            ("01:52.13", "As long as I keep dancing"),
            ("02:08.89", "I don't need no money"),
            ("02:13.53", "As long as I can feel the beat"),
            ("02:19.03", "I don't need no money"),
            ("02:24.28", "As long as I keep dancing"),
            ("02:28.79", "(Oh, oh, oh)"),
            ("02:29.78", "Baby, I don't need dollar bills to have fun tonight"),
            ("02:33.28", "(I love cheap thrills)"),
            ("02:34.79", "Baby, I don't need dollar bills to have fun tonight"),
            ("02:38.78", "(I love cheap thrills)"),
            ("02:40.28", "But I don't need no money"),
            ("02:45.28", "As long as I can feel the beat"),
            ("02:51.03", "I don't need no money"),
            ("02:56.29", "As long as I keep dancing"),
            ("03:01.54", "La-la-la-la-la"),
            ("03:05.43", "(I love cheap thrills)"),
            ("03:06.42", "La-la-la-la-la"),
            ("03:10.68", "(I love cheap thrills)"),
            ("03:12.18", "La-la-la-la-la"),
            ("03:15.93", "(I love cheap thrills)"),
            ("03:17.68", "La-la-la-la-la"),
            ("03:21.69", "(I love cheap thrills)"),
        };

        List<float> timings = new List<float>();
        List<string> lines = new List<string>();

        foreach (var (time, line) in lrcLyrics)
        {
            timings.Add(Main.ParseLRCTime(time));
            lines.Add(line);
        }

        Main.RegisterSong("cheap-thrills", (timings.ToArray(), lines.ToArray()));
    }

}
