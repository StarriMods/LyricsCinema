using LyricsCinema;

public class Levitating
{
    public static void RegisterLyrics()
    {
        // Simulated LRC format embedded in the code for clarity
        var lrcLyrics = new List<(string Time, string Line)>
        {
            // Source: https://www.megalobiz.com/lrc/maker/Levitating.55130600
            ("00:04.11", "If you wanna run away with me,"),
            ("00:05.60", "I know a galaxy"),
            ("00:06.35", "And I can take you for a ride"),
            ("00:08.60", "I had a premonition that"),
            ("00:09.88", "We fell into a rhythm"),
            ("00:10.96", "Where the music"),
            ("00:11.85", "Don't stop for life"),
            ("00:13.35", "Glitter in the sky,"),
            ("00:15.11", "Glitter in my eyes"),
            ("00:15.85", "Shining just the way I like"),
            ("00:18.10", "If you're feeling like you"),
            ("00:19.10", "Need a little bit of company"),
            ("00:20.38", "You met me at the perfect time"),
            ("00:23.11", "You want me, I want you, baby"),
            ("00:25.60", "My sugarboo, I'm levitating"),
            ("00:27.85", "The Milky Way, we're renegading"),
            ("00:29.81", "Yeah, yeah, yeah, yeah, yeah"),
            ("00:31.81", "I got you, moonlight,"),
            ("00:34.37", "You're my starlight"),
            ("00:36.86", "I need you all night, come on,"),
            ("00:39.85", "Dance with me"),
            ("00:40.85", "I'm levitating"),
            ("00:41.61", "You, moonlight, you're my"),
            ("00:44.85", "Starlight (You're the moonlight)"),
            ("00:46.60", "I need you all night, come on,"),
            ("00:49.11", "Dance with me"),
            ("00:49.86", "I'm levitating"),
            ("00:55.36", "I believe that you're for me,"),
            ("00:56.62", "I feel it in our energy"),
            ("00:57.85", "I see us written in the stars"),
            ("00:59.87", "We can go wherever,"),
            ("01:01.10", "So let's do it now or never"),
            ("01:02.11", "Baby, nothing's ever,"),
            ("01:03.36", "Ever too far"),
            ("01:04.85", "Glitter in the sky,"),
            ("01:05.87", "Glitter in our eyes"),
            ("01:06.86", "Shining just the way we are"),
            ("01:09.35", "I feel like we're forever"),
            ("01:10.35", "Every time we get together"),
            ("01:11.61", "But whatever,"),
            ("01:12.35", "Let's get lost on Mars"),
            ("01:14.36", "You want me, I want you, baby"),
            ("01:16.61", "My sugarboo, I'm levitating"),
            ("01:19.10", "The Milky Way, we're renegading"),
            ("01:21.11", "Yeah, yeah, yeah, yeah, yeah"),
            ("01:23.11", "I got you, moonlight,"),
            ("01:25.60", "You're my starlight"),
            ("01:27.85", "I need you all night, come on,"),
            ("01:30.85", "Dance with me"),
            ("01:32.10", "I'm levitating"),
            ("01:32.63", "You, moonlight, you're my"),
            ("01:36.11", "Starlight (You're the moonlight)"),
            ("01:38.12", "I need you all night, come on,"),
            ("01:40.36", "Dance with me"),
            ("01:41.10", "I'm levitating"),
            ("01:43.61", "You can fly away"),
            ("01:44.10", "With me tonight"),
            ("01:44.85", "You can fly away"),
            ("01:45.86", "With me tonight"),
            ("01:47.10", "Baby, let me take you for a ride"),
            ("01:48.89", "Yeah, yeah, yeah, yeah, yeah"),
            ("01:50.63", "I'm levitating (Woo)"),
            ("01:51.61", "You can fly away"),
            ("01:52.85", "With me tonight"),
            ("01:54.10", "You can fly away"),
            ("01:54.85", "With me tonight"),
            ("01:56.60", "Baby, let me take you for a ride"),
            ("01:58.35", "Yeah, yeah, yeah, yeah,"),
            ("01:59.10", "Yeah (Woo)"),
            ("02:01.11", "My love is like a rocket,"),
            ("02:01.85", "Watch it blast off"),
            ("02:02.86", "And I'm feeling so electric,"),
            ("02:03.85", "Dance my ass off"),
            ("02:05.35", "And even if I wanted to,"),
            ("02:06.10", "I can't stop"),
            ("02:07.60", "Yeah, yeah, yeah, yeah, yeah"),
            ("02:10.36", "My love is like a rocket,"),
            ("02:11.10", "Watch it blast off"),
            ("02:12.07", "And I'm feeling so electric,"),
            ("02:13.34", "Dance my ass off"),
            ("02:14.33", "And even if I wanted to,"),
            ("02:15.60", "I can't stop"),
            ("02:16.58", "Yeah, yeah, yeah, yeah, yeah"),
            ("02:19.83", "You want me, I want you, baby"),
            ("02:21.82", "My sugarboo, I'm levitating"),
            ("02:24.10", "The Milky Way, we're renegading"),
            ("02:26.31", "I got you (Yeah), moonlight,"),
            ("02:31.10", "You're my starlight"),
            ("02:33.10", "I need you all night (All night),"),
            ("02:35.85", "Come on, dance with me"),
            ("02:37.10", "I'm levitating (Woo)"),
            ("02:38.36", "You can fly away"),
            ("02:39.85", "With me tonight (Tonight)"),
            ("02:40.61", "You can fly away"),
            ("02:41.89", "With me tonight"),
            ("02:43.11", "Baby, let me take you for a ride"),
            ("02:44.86", "Yeah, yeah, yeah, yeah,"),
            ("02:45.85", "Yeah (Take you for a ride)"),
            ("02:47.35", "I'm levitating (Woo)"),
            ("02:48.11", "You can fly away"),
            ("02:49.11", "With me tonight (Tonight)"),
            ("02:50.11", "You can fly away"),
            ("02:50.85", "With me tonight"),
            ("02:52.35", "Baby, let me take you for a ride"),
            ("02:53.35", "Yeah, yeah, yeah, yeah,"),
            ("02:54.85", "Yeah (Let me take you for a ride)"),
            ("02:56.61", "I got you, moonlight, you're my"),
            ("02:59.36", "Starlight (You are my starlight)"),
            ("03:01.32", "I need you all night, come on,"),
            ("03:03.58", "Dance with me"),
            ("03:05.31", "(Come on, dance with me)"),
            ("03:05.81", "I'm levitating"),
            ("03:06.63", "You, moonlight, you're my"),
            ("03:09.36", "Starlight (You're the moonlight)"),
            ("03:10.35", "I need you all night, come on,"),
            ("03:13.35", "Dance with me"),
            ("03:14.37", "I'm levitating"),

        };

        List<float> timings = new List<float>();
        List<string> lines = new List<string>();

        foreach (var (time, line) in lrcLyrics)
        {
            timings.Add(Main.ParseLRCTime(time));
            lines.Add(line);
        }

        Main.RegisterSong("levitating", (timings.ToArray(), lines.ToArray()));
    }

}
