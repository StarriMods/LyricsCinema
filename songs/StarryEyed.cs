using LyricsCinema;

public class StarryEyed
{
    public static void RegisterLyrics()
    {
        // Simulated LRC format embedded in the code for clarity
        var lrcLyrics = new List<(string Time, string Line)>
        {
            // Source: https://www.megalobiz.com/lrc/maker/Starry+Eyed.55375523
            ("00:03.10", "Ah, ah"),
            ("00:09.22", "Got me upside down, spinnin' around you (ah, ah)"),
            ("00:13.07", "Wanna taste the clouds, dance with the moon (ah)"),
            ("00:17.23", "Take a trip around your body"),
            ("00:19.55", "Boy I love the way you got me"),
            ("00:21.60", "Starry eyed, got me starry eyed"),
            ("00:25.72", "Losing all my focus, I can't even control it"),
            ("00:29.81", "You know your lips are golden, baby get me high (ah)"),
            ("00:34.45", "Touching me like lightning, yeah, keepin' it exciting"),
            ("00:38.81", "You know exactly what to do to blow my mind (ah)"),
            ("00:43.18", "You're from another planet"),
            ("00:45.50", "I've never felt like this"),
            ("00:47.03", "I don't know how I ever survived without it"),
            ("00:50.16", "I'm starry eyed"),
            ("00:51.42", "Ah, ah"),
            ("00:52.73", "Got me upside down, spinnin' around you (ah, ah)"),
            ("00:56.82", "Wanna taste the clouds, dance with the moon (ah)"),
            ("01:00.65", "Take a trip around your body"),
            ("01:02.98", "Boy I love the way you got me"),
            ("01:05.30", "Starry eyed, got me starry eyed"),
            ("01:09.42", "This bed is outer space, just keep painting constellations"),
            ("01:11.73", "You cover me in glitter 'til I'm shining bright (ah, yeah)"),
            ("01:18.16", "I never wanna leave the sky, the way you make me feel alive"),
            ("01:22.28", "I was in the dark and baby you're the light (ah)"),
            ("01:26.39", "You're from another planet"),
            ("01:28.96", "I've never felt like this"),
            ("01:31.02", "I don't know how l ever survived without it"),
            ("01:33.57", "I'm starry eyed"),
            ("01:35.09", "Ah, ah"),
            ("01:36.62", "Got me upside down, spinnin' around you (ah, ah)"),
            ("01:40.72", "Wanna taste the clouds, dance with the moon (ah)"),
            ("01:44.29", "Take a trip around your body"),
            ("01:46.86", "Boy I love the way you got me"),
            ("01:49.16", "Starry eyed, got me starry eyed"),
            ("01:53.78", "Couldn't fight if l wanted, flying to places that I never thought I could go"),
            ("01:58.38", "You're a meteor shower, fallin' down all over me yeah you're making me glow"),
            ("02:02.73", "Couldn't fight if I wanted, flying to places that I'll never thought I could go"),
            ("02:06.33", "Starry eyed, got me starry eyed"),
            ("02:11.29", "Wanna taste the clouds, dance with the moon (ah)"),
            ("02:19.50", "Take a trip around your body"),
            ("02:21.84", "Boy I love the way you got me"),
            ("02:24.14", "Starry eyed, got me starry eyed"),
            ("02:27.74", "Ah, ah"),
            ("02:28.77", "Got me upside down, spinnin' around you (ah, ah)"),
            ("02:33.13", "Wanna taste the clouds, dance with the moon (ah)"),
            ("02:36.72", "Take a trip around your body"),
            ("02:39.28", "Boy I love the way you got me"),
            ("02:41.58", "Starry eyed, got me starry eyed"),
            ("02:44.89", "Ah, ah"),
            ("02:46.18", "Got me upside down, spinnin' around you (ah, ah)"),
            ("02:50.56", "Wanna taste the clouds, dance with the moon (ah)"),
            ("02:54.17", "Take a trip around your body"),
            ("02:56.48", "Boy I love the way you got me"),
        };

        List<float> timings = new List<float>();
        List<string> lines = new List<string>();

        foreach (var (time, line) in lrcLyrics)
        {
            timings.Add(Main.ParseLRCTime(time));
            lines.Add(line);
        }

        Main.RegisterSong("starry-eyed", (timings.ToArray(), lines.ToArray()));
    }

}
