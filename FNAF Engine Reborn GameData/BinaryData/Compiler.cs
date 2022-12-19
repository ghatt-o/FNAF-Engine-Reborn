using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
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

        public static void Compile(string type, string project, GameData gameData)
        {
            if (type == "fnaf" || type == "fnaf4")
            {
                byte[] curKey = new byte[53];
                if (type == "fnaf") curKey[0] = 1;
                else if (type == "fnaf4") curKey[0] = 2;
                curKey[1] = 52;
                for (int i = 1; i < 52; i++)
                {
                    curKey[i] = 7;
                }
                ByteWriter binWriter = new ByteWriter(new FileStream($@"Exports/{gameData.Name}/data.ferdata", FileMode.Create));
                gameData.Write(binWriter, true, "");
                XorEncryption.Encrypt(File.ReadAllBytes($@"Exports/{gameData.Name}/data.ferdata"), new byte[53]);
            }
        }
    }
}
