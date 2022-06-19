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
        public void CreateScript(string Name)
        {
            Directory.CreateDirectory(Project + "/scripts/visual/" + Name);
            File.WriteAllText(Project + "/scripts/visual/" + Name + "/event.txt", "");
            File.WriteAllText(Project + "/scripts/visual/" + Name + "/actions.txt", "");
        }
        public void AddEvent(string Name, string Token)
        {
            string ScriptPath = Project + "/scripts/visual/" + Name;
            if (Token == "On Engine Start")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "1:1");
            }
            if (Token == "On Engine Loop")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "1:2");
            }
            if (Token == "On Engine End")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "1:3");
            }
            if (Token == "On Night Start")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "1:4");
            }
            if (Token == "On Night End")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "1:5");
            }
            if (Token == "On Night Loop")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "1:6");
            }
            if (Token == "On Night Break")
            {
                File.WriteAllText(ScriptPath + "/event.txt", "1:7");
            }
        }
    }
}
