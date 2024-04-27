using LyricsCinema;

public class GiraGira
{
    public static void RegisterLyrics()
    {
        // Simulated LRC format embedded in the code for clarity
        var lrcLyrics = new List<(string Time, string Line)>
        {
            // Source: https://www.megalobiz.com/lrc/maker/Gira+Gira.55122263
            ("00:20.26", "Aa mou hontou ni nante subarashiki sekai"),
            ("00:26.74", "Nde kyou mo mata onore no shuuakusa ni madou"),
            ("00:31.50", "Da no ni hito wo suki tte omou kimochi dake wa"),
            ("00:36.75", "Icchoumae ni aru kara modaeterun deshou"),
            ("00:43.74", "Ugly shoujiki itte watashi no kao wa"),
            ("00:49.24", "Sou kamisama ga hidarite de kaita mitai"),
            ("00:53.73", "Hitsuzen kono yo ni aru love song wa dore hitotsu"),
            ("00:59.24", "Zettai watashi muke nanka janai deshou"),
            ("01:04.49", "Tsukaimichi no nai kuchidzuke awaremi wo hoshiimama ni"),
            ("01:13.97", "Supankooru no kasabuta de mi wo mamoru"),
            ("01:18.74", "Aisarenai kurai nanda"),
            ("01:25.97", "Gira gira kagayaite watashi wa yoru wo nomi"),
            ("01:31.79", "Rap Tap Tap Tap"),
            ("01:34.37", "Ima ni mitero kono luv"),
            ("01:37.38", "Me ni shimiru wa 1 mg no hanabi"),
            ("01:41.88", "Drag on Drag on"),
            ("01:44.68", "Nante funny kono yo wa bizzare"),
            ("01:48.69", "Gira gira gira gira"),
            ("02:06.19", "Unknown oshakasama mo zonzenu uchi ni"),
            ("02:11.96", "Mou sukoyaka ni kurutteita mitai"),
            ("02:16.45", "Sore wa sekai no hou ka sore to mo watashi no hou desu ka?"),
            ("02:22.55", "Kyousei wa hashi kara muri deshou"),
            ("02:26.82", "Magaimono koso kanashikere mugamuchuu hashiru hashiru"),
            ("02:36.80", "Tsuyoi sanseiu ga arai nagasu mae ni"),
            ("02:41.13", "Keikoushoku no aza daite"),
            ("02:48.16", "Mera mera hi wo fuite watashi wa yoru no ookami"),
            ("02:54.42", "Rap Tap Tap Tap"),
            ("02:56.92", "Soko de mitero kono ranbu"),
            ("02:59.72", "Tsuyoku onari anata nari no make up de"),
            ("03:04.47", "Flap up Flap up"),
            ("03:06.96", "Fui ni fuan ni"),
            ("03:08.27", "Kodoku wa gasoline hikutsu na machi wo yuku"),
            ("03:13.80", "Me wo tojite mou ii kai mou ii kai"),
            ("03:19.41", "Moshimo kamisama ga hidarikiki nara donna ni shiawase ka shirenai"),
            ("03:38.42", "Gira gira kagayaite watashi wa yoru wo nomi"),
            ("03:44.42", "Rap Tap Tap Tap"),
            ("03:46.91", "Ima ni mitero kono luv"),
            ("03:49.92", "Me ni shimiru wa 1 mg no hanabi"),
            ("03:54.42", "Drag on Drag on"),
            ("03:56.94", "Nante funny kono yo wa bizzare"),
            ("04:01.16", "Gira gira gira gira gira gira"),
            ("04:10.01", "Give Love hana wa michite (giragira)"),
            ("04:14.29", "Ari no manma ja irarenai dare mo kare mo"),
            ("04:19.33", "Nante subarashiki sekai da!"),
            ("04:21.91", "Gira tsuitekou"),
        };

        List<float> timings = new List<float>();
        List<string> lines = new List<string>();

        foreach (var (time, line) in lrcLyrics)
        {
            timings.Add(Main.ParseLRCTime(time));
            lines.Add(line);
        }

        Main.RegisterSong("gira-gira", (timings.ToArray(), lines.ToArray()));
    }

}
