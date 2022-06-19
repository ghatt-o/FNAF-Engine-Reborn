using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn
{
    class ScriptEditor
    {
        public string Project { get; set; }
        public bool HasEvent(string Name)
        {
            if (File.ReadAllText(Name + "/event.txt") == "none")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string ToEvent(string Name)
        {
            string file = File.ReadAllText(Name + "/event.txt");
            return file;
        }
        public void CreateScript(string Name)
        {
            Directory.CreateDirectory(Project + "/scripts/visual/" + Name);
            File.WriteAllText(Project + "/scripts/visual/" + Name + "/event.txt", "none");
            File.WriteAllText(Project + "/scripts/visual/" + Name + "/actions.txt", "none");
        }
        public void AddEvent(string Name, string Token)
        {
            string ScriptPath = Name;
            if (Token == "On Engine Start")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "On Engine Start");
            }
            if (Token == "On Engine Loop")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "On Engine Loop");
            }
            if (Token == "On Engine End")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "On Engine End");
            }
            if (Token == "On Night Start")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "On Night Start");
            }
            if (Token == "On Night End")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "On Night End");
            }
            if (Token == "On Night Loop")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "On Night Loop");
            }
            if (Token == "On Night Break")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "On Night Break");
            }
        }
    }
}
