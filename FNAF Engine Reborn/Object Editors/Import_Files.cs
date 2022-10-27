using System.IO;

namespace FNAF_Engine_Reborn.Object_Editors
{
    public static class Import_Files
    {
        public static void CreateSprite(string Path, string FileName, string Projecto)
        {
            try
            {
                File.Copy(Path, Projecto + "/images/" + FileName, true);
            }
            catch
            {

            }
        }
        public static void CreateAudio(string Path, string Projecto)
        {
            try
            {
                FileInfo fileinfo = new FileInfo(Path);
                string FileName = fileinfo.Name;
                File.Copy(Path, Projecto + "/sounds/" + FileName, true);
            }
            catch
            {

            }
        }
    }
}
