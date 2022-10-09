using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace FNAF_Engine_GameData.BinaryData
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

        public static async void Compile(string type, bool binary, string project, GameData gameData)
        {
            if (type == "fnaf" || type == "fnaf4")
            {
                if (binary == true)
                {
                    if (gameData == null)
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

                        //IMAGES
                        #region

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
                            FileInfo fileInfo = new FileInfo(img);
                            long imgSize = fileInfo.Length;

                            binWriter.Write(imgSize);
                            binWriter.Write(imgBytes);
                        }

                        #endregion
                        //AUDIO FILES
                        #region

                        int AudioCount = 0;

                        List<string> Audios = new List<string>();

                        foreach (var file in Directory.GetFiles(project + "/sounds"))
                        {
                            AudioCount++;
                            Audios.Add(file);
                        }

                        binWriter.Write(AudioCount);

                        foreach (var aud in Audios)
                        {
                            byte[] AudioBytes = File.ReadAllBytes(aud);
                            FileInfo fileInfo = new FileInfo(aud);
                            long AudioSize = fileInfo.Length;

                            binWriter.Write(AudioSize);
                            binWriter.Write(AudioBytes);
                        }

                        #endregion

                        //MENUS
                        #region
                        int MenuCount = 0;

                        foreach (var menu in Directory.GetDirectories(project + "/menus")) MenuCount++;

                        binWriter.Write(MenuCount);

                        foreach (var menu in Directory.GetDirectories(project + "/menus"))
                        {
                            binWriter.Write(File.ReadAllText(menu + "/name.txt"));
                            binWriter.Write((long)0);
                            if (File.Exists(menu + "/bg.txt"))
                            {
                                string[] imagess = Directory.GetFiles(project + "/images/");
                                for (int i = 0; i < imagess.Length; i++)
                                {
                                    foreach (var file in Directory.GetFiles(project + "/images/"))
                                    {
                                        if (file == File.ReadAllText(menu + "/bg.txt"))
                                        {
                                            binWriter.Write(((long)i));
                                        }
                                    }
                                }
                            }
                            else
                            {
                                binWriter.Write((long)0);
                            }


                            //MENU CODE



                            string[] onmenustart_stuff = File.ReadAllLines(menu + "/onmenustart.txt");

                            long CodeLines = 0;
                            for (int i = 0; i < onmenustart_stuff.Length; i++) CodeLines++;

                            binWriter.Write(CodeLines);

                            foreach (string str in onmenustart_stuff) binWriter.Write(str);






                            string[] ongameloop_stuff = File.ReadAllLines(menu + "/onmenustart.txt");

                            long CodeLinesG = 0;
                            for (int i = 0; i < ongameloop_stuff.Length; i++) CodeLinesG++;

                            binWriter.Write(CodeLinesG);

                            foreach (string strG in ongameloop_stuff) binWriter.Write(strG);




                            //ELEMENTS
                            int textElementCount = 0;
                            int imgElementCount = 0;
                            foreach (var TextElement in Directory.GetDirectories(menu + "/text_elements")) textElementCount++;
                            foreach (var ImageElement in Directory.GetDirectories(menu + "/image_elements")) imgElementCount++;

                            binWriter.Write(textElementCount);
                            binWriter.Write(imgElementCount);

                            //TEXT ELEMENT
                            foreach (var TextElement in Directory.GetDirectories(menu + "/text_elements"))
                            {
                                if (File.ReadAllText(TextElement + "/args.txt") == "True") binWriter.Write(true);
                                else binWriter.Write(false);
                                binWriter.Write(Convert.ToInt32(File.ReadAllText(TextElement + "/x.txt")));
                                binWriter.Write(Convert.ToInt32(File.ReadAllText(TextElement + "/y.txt")));
                                binWriter.Write(File.ReadAllText(TextElement + "/text.txt"));
                                binWriter.Write(File.ReadAllText(TextElement + "/id.txt"));
                                binWriter.Write(File.ReadAllText(TextElement + "/font.txt"));
                                binWriter.Write(File.ReadAllText(TextElement + "/fontsize.txt"));
                                binWriter.Write(Convert.ToByte(File.ReadAllText(TextElement + "/color.txt").Split(',')[0]));
                                binWriter.Write(Convert.ToByte(File.ReadAllText(TextElement + "/color.txt").Split(',')[1]));
                                binWriter.Write(Convert.ToByte(File.ReadAllText(TextElement + "/color.txt").Split(',')[2]));

                                string[] funcs = File.ReadAllLines(TextElement + "/functions.txt");
                                string[] funcshover = File.ReadAllLines(TextElement + "/functionshover.txt");
                                string[] funcsunhover = File.ReadAllLines(TextElement + "/functionsunhover.txt");
                                string[] funcshold = File.ReadAllLines(TextElement + "/functionshold.txt");

                                binWriter.Write(funcs.Length);
                                binWriter.Write(funcshover.Length);
                                binWriter.Write(funcsunhover.Length);
                                binWriter.Write(funcshold.Length);

                                foreach (string f in funcs)
                                {
                                    binWriter.Write(f);
                                }

                                foreach (string f in funcshover)
                                {
                                    binWriter.Write(f);
                                }

                                foreach (string f in funcsunhover)
                                {
                                    binWriter.Write(f);
                                }

                                foreach (string f in funcshold)
                                {
                                    binWriter.Write(f);
                                }
                            }
                            //IMAGE ELEMENT
                        }

                        #endregion
                        binWriter.Close();
                    }
                    else
                    {
                        if (gameData.Options.SrcFileOnExport == true) CopyDirectory($"{project}", $@"Exports/{gameData.Name}/assets", true);
                        //
                        //
                        //
                        gameData.Write(new BinaryWriter(new FileStream($@"Exports/{gameData.Name}/data.ferdata", FileMode.Create)), true, null);
                    }
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
