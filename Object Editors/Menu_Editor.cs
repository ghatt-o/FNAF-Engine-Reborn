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
            if (TextElement.args == false)
            {
                Label Text = new Label();
                Text.BackColor = Color.Transparent;
                Text.FlatStyle = FlatStyle.Flat;
                Text.Font = new Font(TextElement.Font, FontStyle.Regular);
                Text.Text = TextElement.Text;
                Text.Location = new Point(TextElement.X, TextElement.Y);
                Text.Move += newText_Move;
                void newText_Move(object sender, EventArgs e)
                {

                }
                Preview.Controls.Add(Text);
            }
            else
            {

            }
        }
        public void RefreshText(string Project, string Menu)
        {
            string[] TextElements = Directory.GetDirectories(Project + "/menus/" + Menu + "/text_elements");
            foreach (string TextElement in TextElements)
            {
                string id = File.ReadAllText(TextElement + "/id.txt");
                string text = File.ReadAllText(TextElement + "/text.txt");
                string args = File.ReadAllText(TextElement + "/args.txt");
                string fontname = File.ReadAllText(TextElement + "/font.txt");
                string fontsize_string = File.ReadAllText(TextElement + "/fontsize.txt");
                int fontsize = Convert.ToInt32(fontsize_string);

                FontFamily fontfamily = new FontFamily(fontname);
                Font font = new Font(fontfamily, fontsize, FontStyle.Regular);

                TextElement NewText = new TextElement();

                NewText.ID = id;
                NewText.Text = text;
                NewText.FontSize = fontsize;
                NewText.Font = font;
            }
        }
    }
}
