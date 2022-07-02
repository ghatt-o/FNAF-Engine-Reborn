using System.IO;

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
            File.WriteAllText(ScriptPath + "/event.txt", Token);
        }
    }
}
