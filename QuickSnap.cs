using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace QuickSnap
{
    public class QuickSnap
    {

        public static List<int> GetScreens()
        {
            List<int> screens = new List<int>();
            return new List<int>();

        }

        public class Screen
        {
            private int _screenNumber;

            public int ScreenNumber { get => _screenNumber; set => _screenNumber = value; }
        }

        public class Settings
        {

            private string _upperCorner;
            private string _size;
            private string _prefix;
            private string _path;
            private string _suffix;
            private string _name;
            private bool _autoIncrementSuffix;

            public string UpperCorner { get => _upperCorner; set => _upperCorner = value; }
            public string Size { get => _size; set => _size = value; }
            public string Prefix { get => _prefix; set => _prefix = value; }
            public string Path { get => _path; set => _path = value; }
            public string Suffix { get => _suffix; set => _suffix = value; }
            public string Name { get => _name; set => _name = value; }
            public bool AutoIncrementSuffix { get => _autoIncrementSuffix; set => _autoIncrementSuffix = value; }
        }

        public static void SaveSettings(ref QuickSnap.Settings settings)
        {
            string output = JsonConvert.SerializeObject(settings);
            File.WriteAllText("SavedSettings.json", output);
        }

        public static void GetSettings(ref QuickSnap.Settings settings)
        {
            try
            {
                settings = JsonConvert.DeserializeObject<QuickSnap.Settings>(File.ReadAllText("SavedSettings.json"));
            }catch(Exception e)
            {
                settings = new Settings();
            }
        }
    }
}
