using LyricsCinema;

public class Chandelier
{
    public static void RegisterLyrics()
    {
        // Simulated LRC format embedded in the code for clarity
        var lrcLyrics = new List<(string Time, string Line)>
        {
            // Source: https://www.megalobiz.com/lrc/maker/Sia+-+Chandelier+%28LYRIC+VIDEO%29.54472488
            ("00:01.44", "Party girls don't get hurt"),
            ("00:03.13", "Can't feel anything"),
            ("00:04.37", "When will I learn?"),
            ("00:06.11", "I push it down, I push it down"),
            ("00:12.13", "I'm the one \"for a good time call\""),
            ("00:14.16", "Phone's blowing up"),
            ("00:15.62", "Ringing my doorbell"),
            ("00:17.15", "I feel the love, I feel the love"),
            ("00:22.88", "One, two, three"),
            ("00:23.88", "One, two, three, drink"),
            ("00:25.63", "One, two, three"),
            ("00:26.87", "One, two, three, drink"),
            ("00:28.38", "One, two, three"),
            ("00:29.37", "One, two, three, drink"),
            ("00:31.12", "Throw 'em back, till I lose count"),
            ("00:33.88", "I'm gonna swing from the chandelier"),
            ("00:41.65", "From the chandelier"),
            ("00:44.90", "I'm gonna live like tomorrow doesn't exist"),
            ("00:52.91", "Like it doesn't exist"),
            ("00:56.13", "I'm gonna fly like a bird through the night"),
            ("01:03.88", "Feel my tears as they dry"),
            ("01:06.87", "I'm gonna swing from the chandelier"),
            ("01:14.63", "From the chandelier"),
            ("01:17.63", "But I'm holding on for dear life"),
            ("01:19.37", "Won't look down, won't open my eyes"),
            ("01:22.41", "Keep my glass full until morning light"),
            ("01:25.13", "'Cause I'm just holding on for tonight"),
            ("01:27.90", "Help me, I'm holding on for dear life"),
            ("01:30.62", "Won't look down, won't open my eyes"),
            ("01:33.38", "Keep my glass full until morning light"),
            ("01:35.88", "'Cause I'm just holding on for tonight"),
            ("01:38.38", "On for tonight"),
            ("01:40.12", "Sun is up, I'm a mess"),
            ("01:42.38", "Gotta get out now"),
            ("01:43.89", "Gotta run from this"),
            ("01:45.43", "Here comes the shame, here comes the shame"),
            ("01:49.63", "Aaaaah"),
            ("01:51.13", "One, two, three"),
            ("01:52.37", "One, two, three, drink"),
            ("01:53.63", "One, two, three"),
            ("01:54.89", "One, two, three, drink"),
            ("01:56.63", "One, two, three"),
            ("01:57.63", "One, two, three, drink"),
            ("01:59.13", "Throw 'em back, till I lose count"),
            ("02:02.15", "I'm gonna swing from the chandelier"),
            ("02:09.88", "From the chandelier"),
            ("02:13.13", "I'm gonna live like tomorrow doesn't exist"),
            ("02:20.88", "Like it doesn't exist"),
            ("02:24.16", "I'm gonna fly like a bird through the night"),
            ("02:31.88", "Feel my tears as they dry"),
            ("02:34.90", "I'm gonna swing from the chandelier"),
            ("02:42.88", "From the chandelier"),
            ("02:45.37", "But I'm holding on for dear life"),
            ("02:47.38", "Won't look down, won't open my eyes"),
            ("02:50.37", "Keep my glass full until morning light"),
            ("02:52.88", "'Cause I'm just holding on for tonight"),
            ("02:55.87", "Help me, I'm holding on for dear life"),
            ("02:58.90", "Won't look down, won't open my eyes"),
            ("03:01.40", "Keep my glass full until morning light"),
            ("03:04.15", "'Cause I'm just holding on for tonight"),
            ("03:06.37", "On for tonight"),
            ("03:08.16", "On for tonight"),
            ("03:09.88", "'Cause I'm just holding on for tonight"),
            ("03:12.37", "Oh, I'm just holding on for tonight"),
            ("03:14.88", "On for tonight"),
            ("03:16.39", "On for tonight"),
            ("03:18.38", "'Cause I'm just holding on for tonight"),
            ("03:20.88", "'Cause I'm just holding on for tonight"),
            ("03:23.62", "Oh, I'm just holding on for tonight"),
            ("03:25.88", "On for tonight"),
            ("03:27.11", "On for tonight"),
        };

        List<float> timings = new List<float>();
        List<string> lines = new List<string>();

        foreach (var (time, line) in lrcLyrics)
        {
            timings.Add(Main.ParseLRCTime(time));
            lines.Add(line);
        }

        Main.RegisterSong("chandelier", (timings.ToArray(), lines.ToArray()));
    }

}
