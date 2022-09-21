using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn.Object_Editors
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

        public static async void Compile(string type, bool binary, string project)
        {
            if (type == "fnaf" || type == "fnaf4")
            {
                if (binary == true)
                {
                    string game_name = File.ReadAllText(project + "/game.txt");
                    string project_name = File.ReadAllText(project + "/name.txt");


                    if (string.IsNullOrWhiteSpace(game_name) == true) // if its blank or white spaces
                    {
                        game_name = project_name;
                    }

                    try
                    {
                        Directory.Delete($@"Exports/{game_name}", true);
                    }
                    catch (Exception) { }


                    _ = Directory.CreateDirectory(@"Exports/");
                    _ = Directory.CreateDirectory($@"Exports/{game_name}");

                    BinaryWriter binWriter = new BinaryWriter(new FileStream($@"Exports/{game_name}/data.ferdata", FileMode.Create));

                    binWriter.Write(game_name);
                    if (File.ReadAllText(project + "/options.txt").Contains("fullscreen=true")) binWriter.Write(true);
                    else binWriter.Write(false);

                    int ImageCount = 0;

                    List<string> images = new List<string>();

                    foreach (var file in Directory.GetFiles(project + "/images"))
                    {
                        ImageCount++;
                        images.Add(file);
                    }

                    binWriter.Write(ImageCount);

                    foreach (var img in images)
                    {
                        byte[] imgBytes = File.ReadAllBytes(img);
                        long imgSize = imgBytes.LongLength;

                        binWriter.Write(imgSize);
                        binWriter.Write(imgBytes);
                    }

                    binWriter.Close();
                }
                else if (binary == false)
                {
                    try
                    {
                        string game_name = File.ReadAllText(project + "/game.txt");
                        string project_name = File.ReadAllText(project + "/name.txt");
                        if (string.IsNullOrWhiteSpace(game_name) == true) // if its blank or white spaces
                        {
                            game_name = project_name;
                        }
                        try
                        {
                            Directory.Delete($@"Exports/{game_name}", true);
                        }
                        catch (Exception)
                        {

                        }
                        _ = Directory.CreateDirectory(@"Exports/");
                        _ = Directory.CreateDirectory($@"Exports/{game_name}");
                        _ = Directory.CreateDirectory($@"Exports/{game_name}/assets/");
                        CopyDirectory($"{project}", $@"Exports/{game_name}/assets", true);
                        CopyDirectory(@"assets/files/fnaf", $@"Exports/{game_name}/", true);
                        //MessageBox.Show($"Game successfully compiled to {Application.StartupPath}/Exports/{game_name}! (CLICK OK TO CONTINUE)");
                        //compiled to Exports/projectname/Game.exe
                    }
                    catch (Exception)
                    {
                        string game_name = File.ReadAllText(project + "/game.txt");
                        string project_name = File.ReadAllText(project + "/name.txt");
                        throw new IOException($"Project: {project_name}, Game: {game_name}, Export: {game_name}", 1);
                    }
                }
            }
        }
    }
}
