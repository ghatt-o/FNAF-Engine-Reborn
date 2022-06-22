using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn.Object_Editors
{
    class Menu_Editor
    {
        private reborn reborn;

        public Menu_Editor(reborn reborn)
        {
            this.reborn = reborn;
        }
        public string Menu { get; set; }
        public void CreateText(string Project, string ID)
        {
            string Path = Project + "/menus/" + Menu + "/";
            Directory.CreateDirectory(Path + "text_elements/" + ID);
            string NewPath = Path + "text_elements/" + ID;
            File.WriteAllText(NewPath + "/id.txt", ID);
            File.WriteAllText(NewPath + "/text.txt", "Text");
            File.WriteAllText(NewPath + "/font.txt", "Consolas");
            File.WriteAllText(NewPath + "/fontsize.txt", "11");
            File.WriteAllText(NewPath + "/args.txt", "false");
        }
        public void AddText(string Project, TextElement TextElement)
        {
            var Preview = reborn.MenuPreview;
            Label Text = new Label();
            Text.BackColor = Color.Transparent;
            Text.FlatStyle = FlatStyle.Flat;
            //Text.Font = new Font(TextElement.Font, TextElement.FontSize);
            //Text.Font.Size = new Size(1);
            Text.Font = new Font(TextElement.Font, FontStyle.Regular);
        }
        public void RefreshText(string Project, string Menu)
        {
            string[] TextElements = Directory.GetDirectories(Project + "/menus/" + Menu + "/text_elements");
            foreach (string TextElement in TextElements)
            {
                //Console.WriteLine(TextElement);
            }
        }
    }
}
