using LyricsCinema;

public class BrainPower
{
    public static void RegisterLyrics()
    {
        // Simulated LRC format embedded in the code for clarity
        var lrcLyrics = new List<(string Time, string Line)>
        {
            // Source: https://www.megalobiz.com/lrc/maker/NOMA+-+Brain+Power.55081362
            ("00:01.13", "Are you ready?"),
            ("00:24.17", "Are you ready?"),
            ("00:46.88", "Adrenaline is pumping"),
            ("00:49.62", "Adrenaline is pumping"),
            ("00:52.41", "Generator. Automatic lover"),
            ("00:58.13", "Atomic. Atomic. Overdrive"),
            ("01:03.13", "Blockbuster. Brain power"),
            ("01:09.88", "Call me a leader. Cocaine"),
            ("01:15.12", "Don't you try it, don't you try it"),
            ("01:20.64", "Innovator. Killer machine"),
            ("01:26.13", "There's no fate. Take control"),
            ("01:31.13", "Brain power"),
            ("01:33.39", "Let the bass kick"),
            ("01:34.87", "O-oooooooooo AAAAE-A-A-I-A-U- JO-oooooooooooo AAE-O-A-A-U-U-A- E-eee-ee-eee AAAAE-A-E-I-E-A- JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA"),
            ("01:45.88", "O-oooooooooo AAAAE-A-A-I-A-U- JO-oooooooooooo AAE-O-A-A-U-U-A- E-eee-ee-eee AAAAE-A-E-I-E-A-"),
            ("01:54.14", "JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA"),
            ("01:57.11", "O-oooooooooo AAAAE-A-A-I-A-U- JO-oooooooooooo AAE-O-A-A-U-U-A- E-eee-ee-eee AAAAE-A-E-I-E-A-"),
            ("02:05.14", "JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA-O----------"),
            ("02:19.63", "Adrenaline is pumping"),
            ("02:22.41", "Adrenaline is pumping"),
            ("02:24.88", "Generator. Automatic lover"),
            ("02:30.63", "Atomic. Atomic. Overdrive"),
            ("02:32.14", "Blockbuster. Brain power"),
            ("02:42.38", "Call me a leader. Cocaine"),
            ("02:47.63", "Don't you try it, don't you try it"),
            ("02:52.87", "Innovator. Killer machine"),
            ("02:58.62", "There's no fate. Take control"),
            ("03:03.88", "Brain power"),
            ("03:05.88", "Let the bass kick"),
            ("03:07.37", "O-oooooooooo AAAAE-A-A-I-A-U- JO-oooooooooooo AAE-O-A-A-U-U-A- E-eee-ee-eee AAAAE-A-E-I-E-A- JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA"),
            ("03:18.38", "O-oooooooooo AAAAE-A-A-I-A-U- JO-oooooooooooo AAE-O-A-A-U-U-A- E-eee-ee-eee AAAAE-A-E-I-E-A-"),
            ("03:26.61", "JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA"),
            ("03:29.62", "O-oooooooooo AAAAE-A-A-I-A-U- JO-oooooooooooo AAE-O-A-A-U-U-A- E-eee-ee-eee AAAAE-A-E-I-E-A-"),
            ("03:37.63", "JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA-O----------"),
            ("03:50.63", "Let the bass kick"),
            ("05:10.63", "O-oooooooooo AAAAE-A-A-I-A-U- JO-oooooooooooo AAE-O-A-A-U-U-A- E-eee-ee-eee AAAAE-A-E-I-E-A- JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA"),
            ("05:21.91", "O-oooooooooo AAAAE-A-A-I-A-U- JO-oooooooooooo AAE-O-A-A-U-U-A- E-eee-ee-eee AAAAE-A-E-I-E-A-"),
            ("05:30.12", "JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA"),
            ("05:32.88", "O-oooooooooo AAAAE-A-A-I-A-U- JO-oooooooooooo AAE-O-A-A-U-U-A- E-eee-ee-eee AAAAE-A-E-I-E-A-"),
            ("05:41.61", "JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA-O----------"),
        };

        List<float> timings = new List<float>();
        List<string> lines = new List<string>();

        foreach (var (time, line) in lrcLyrics)
        {
            timings.Add(Main.ParseLRCTime(time));
            lines.Add(line);
        }

        Main.RegisterSong("brain-power", (timings.ToArray(), lines.ToArray()));
    }

}
