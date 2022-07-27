using System.IO;

namespace FNAF_Engine_Reborn.Object_Editors
{
    public static class Import_Sprites
    {
        public static void CreateSprite(string Path, string FileName, string Projecto)
        {
            File.Copy(Path, Projecto + "/images/" + FileName, true);
        }
    }
}
