using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData
{
    internal static class Compiler
    {
        private static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            _ = Directory.CreateDirectory(destinationDir);
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                _ = file.CopyTo(targetFilePath);
            }
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }

        public static async void Compile(string type, string project, GameData gameData)
        {
            if (type == "fnaf" || type == "fnaf4")
            {
                BinaryWriter binWriter = new BinaryWriter(new FileStream($@"Exports/{gameData.Name}/data.ferdata", FileMode.Create));
                gameData.Write(binWriter, true, "");
                binWriter.Close();
            }
        }
    }
}
