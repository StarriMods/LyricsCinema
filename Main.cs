using MelonLoader;
using UnityEngine;
using Il2CppRhythm;

namespace LyricsCinema
{
    public class Main : MelonMod
    {
        // Preferences category
        private MelonPreferences_Category prefsCategory;

        // variables
        private AudioSource currentSong;
        private MusicController musicController;
        private string currentSongId;
        private static string _currentLyric = "";
        private static string _nextLyric = "";
        private static bool _showLyric = false;
        private static int _currentLineIndex = -1;

        // Lyrics - text properties
        private static GUIStyle _textStyle;
        private static GUIStyle _nextLineStyle;
        private MelonPreferences_Entry<int> fontSize;

        // Lyrics - top line
        private MelonPreferences_Entry<float> topLineY;
        private MelonPreferences_Entry<float> topLineX;
        private MelonPreferences_Entry<float> topLineWidthMargin;
        private MelonPreferences_Entry<float> topLineHeight;
        // Lyrics - bottom line
        private MelonPreferences_Entry<float> bottomLineY;
        private MelonPreferences_Entry<float> bottomLineX;
        private MelonPreferences_Entry<float> bottomLineWidthMargin;
        private MelonPreferences_Entry<float> bottomLineHeight;

        // Dict to hold the lyrics and timestamps
        public static Dictionary<string, (float[] timings, string[] lines)> LyricsData = new Dictionary<string, (float[] timings, string[] lines)>();


        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();

            // Initialize preferences and set custom file path
            prefsCategory = MelonPreferences.CreateCategory("LyricsCinema", "Lyrics Cinema Settings");
            prefsCategory.SetFilePath("UserData/LyricsCinema.cfg");

            // Create entries for text properties
            fontSize = prefsCategory.CreateEntry("FontSize", 65, "Font Size");

            // Create entries for top line properties
            topLineY = prefsCategory.CreateEntry("TopLineY", 250f, "Top Line Y Position");
            topLineX = prefsCategory.CreateEntry("TopLineX", 20f, "Top Line X Position");
            topLineWidthMargin = prefsCategory.CreateEntry("TopLineWidthMargin", 40f, "Top Line Width Margin");
            topLineHeight = prefsCategory.CreateEntry("TopLineHeight", 100f, "Top Line Height");

            // Create entries for bottom line properties
            bottomLineY = prefsCategory.CreateEntry("BottomLineY", 320f, "Bottom Line Y Position");
            bottomLineX = prefsCategory.CreateEntry("BottomLineX", 20f, "Bottom Line X Position");
            bottomLineWidthMargin = prefsCategory.CreateEntry("BottomLineWidthMargin", 40f, "Bottom Line Width Margin");
            bottomLineHeight = prefsCategory.CreateEntry("BottomLineHeight", 100f, "Bottom Line Height");
        }

        public override void OnLateInitializeMelon()
        {

            // Register Songs
            BrainPower.RegisterLyrics();
            Chandelier.RegisterLyrics();
            GiraGira.RegisterLyrics();
            CheapThrills.RegisterLyrics();
            DontStartNow.RegisterLyrics();
            StarryEyed.RegisterLyrics();
            Levitating.RegisterLyrics();
            // add more songs here


            foreach (var songId in LyricsData.Keys)
            {
                CustomLogger.Msg("Lyrics loaded for ID: " + songId);
            }


            InitializeGUIStyles();
            MelonEvents.OnGUI.Subscribe(DrawLyrics);

        }

        public override void OnUpdate()
        {
            // Find the MusicController GameObject 
            if (musicController == null)
            {
                GameObject musicControllerGameObject = GameObject.Find("MusicController");
                if (musicControllerGameObject != null)
                {
                    musicController = musicControllerGameObject.GetComponent<MusicController>();
                    CustomLogger.Debug("MusicController GameObject found.");
                }
                else
                {
                    CustomLogger.Debug("MusicController GameObject NOT found. Probably in a menu....");
                }
            }

            if (musicController != null && musicController.musicInfo != null)
            {
                // find currently playing song
                string newSongId = musicController.musicInfo.id;
                if (newSongId != currentSongId)
                {
                    currentSongId = newSongId;
                    CustomLogger.Msg($"Current song ID changed to: {currentSongId}");
                }

                // update Lyrics
                currentSong = musicController.GetComponent<AudioSource>();
                if (currentSong != null && currentSong.isPlaying && LyricsData.ContainsKey(currentSongId))
                {
                    _showLyric = true;
                    UpdateCurrentLyric(currentSong.time);
                }
                else
                {
                    _showLyric = false;
                    if (!currentSong.isPlaying)
                        CustomLogger.Debug("AudioSource is not playing any music.");
                    if (!LyricsData.ContainsKey(currentSongId))
                        CustomLogger.Debug("No lyrics available for this song ID.");
                }
            }

        }


        private void UpdateCurrentLyric(float currentTime)
        {
            if (!LyricsData.TryGetValue(currentSongId, out var data))
            {
                CustomLogger.Debug("No lyrics data found for the current song ID.");
                return;
            }

            float[] timings = data.timings;
            string[] lines = data.lines;


            // If timings are not explicitly provided, calculate them evenly based on the song length
            if (timings.Length == 0 && currentSong.clip != null)
            {
                float totalLength = currentSong.clip.length;
                int numberOfLines = lines.Length;
                float timePerLine = totalLength / numberOfLines;
                timings = new float[numberOfLines];
                for (int i = 0; i < numberOfLines; i++)
                {
                    timings[i] = i * timePerLine;
                }
            }

            bool lyricFound = false;
            float tolerance = 0.5f;  // 500 ms tolerance for matching the current time to a lyric timing
            for (int i = 0; i < timings.Length; i++)
            {
                if (currentTime < timings[i] + tolerance) // Adding tolerance
                {
                    if (i > 0 && currentTime + tolerance >= timings[i - 1]) // Ensure the current time is within the current timing range
                    {
                        _currentLyric = lines[i - 1];
                        _currentLineIndex = i - 1;
                        lyricFound = true;
                    }
                    _nextLyric = i < lines.Length - 1 ? lines[i] : "";
                    break;
                }
            }

            if (!lyricFound)
            {
                _showLyric = false;
                CustomLogger.Debug("No matching lyric timing found. Hiding lyrics.");
            }
            else
            {
                _showLyric = true;
                CustomLogger.Debug($"Current Time: {currentTime}, Lyric displayed: {_currentLyric}");
            }
        }


        public void InitializeGUIStyles()
        {
            _textStyle = new GUIStyle()
            {
                fontSize = fontSize.Value,
                alignment = TextAnchor.MiddleCenter,
                normal = { textColor = Color.cyan }
            };

            _nextLineStyle = new GUIStyle(_textStyle)
            {
                normal = { textColor = new Color(168, 173, 173, 0.3f) } // Cyan with 50% opacity
            };
        }

        public void DrawLyrics()
        {
            if (_showLyric)
            {
                if (_currentLineIndex >= 0)
                {
                    //to place at bottom:
                    //GUI.Label(new Rect(20, Screen.height - 140, Screen.width - 40, 100), _currentLyric, _textStyle);

                    // top place at top:
                    GUI.Label(new Rect(topLineX.Value, topLineY.Value, Screen.width - topLineWidthMargin.Value, topLineHeight.Value), _currentLyric, _textStyle);
                   // GUI.Label(new Rect(20, 250, Screen.width - 40, 90), _currentLyric, _textStyle);

                    if (!string.IsNullOrEmpty(_nextLyric))
                    {
                        //to place at bottom:
                        //GUI.Label(new Rect(20, Screen.height - 70, Screen.width - 40, 100), _nextLyric, _nextLineStyle);

                        //to place at top
                        GUI.Label(new Rect(bottomLineX.Value, bottomLineY.Value, Screen.width - bottomLineWidthMargin.Value, bottomLineHeight.Value), _nextLyric, _nextLineStyle);
                        //GUI.Label(new Rect(20, 320, Screen.width - 40, 90), _nextLyric, _nextLineStyle);
                    }
                }
            }
        }




        public override void OnApplicationQuit()
        {
            MelonEvents.OnGUI.Unsubscribe(DrawLyrics);

        }



        public static void RegisterSong(string songId, (float[] timings, string[] lines) data)
        {
            LyricsData.Add(songId, data);
        }




        public static float ParseLRCTime(string lrcTimestamp)
        {
            // Expected format: [mm:ss.ff]
            string[] parts = lrcTimestamp.Split(':');
            if (parts.Length != 2)
                return 0;

            string[] secondParts = parts[1].Split('.');
            float minutes = float.Parse(parts[0]);
            float seconds = float.Parse(secondParts[0]);
            float fraction = secondParts.Length > 1 ? float.Parse("0." + secondParts[1]) : 0;

            return minutes * 60 + seconds;
            // Quickfix: discard ms because just adding them leads them to be interpreted as seconds
            //return minutes * 60 + seconds + fraction;
        }

        public static class CustomLogger
        {
            // Debug message logging method
            // Compile with Debug to enable debug logging output
            public static void Debug(string message)
            {
            #if DEBUG_LOGGING
            MelonLogger.Msg("[DEBUG] " + message);
            #endif
            }

            // Regular message logging method
            public static void Msg(string message)
            {
                MelonLogger.Msg(message);
            }
        }

    }
}