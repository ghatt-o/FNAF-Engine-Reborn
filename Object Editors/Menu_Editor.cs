using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
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
        public async Task Wait(int miliseconds)
        {
            await Task.Delay(miliseconds);
        }
        public string Menu { get; set; }
        bool trigger { get; set; }
        public void CreateText(string ID, string Menu)
        {
            Directory.CreateDirectory(Menu + "/text_elements/" + ID);
            string NewPath = Menu + "/text_elements/" + ID;
            File.WriteAllText(NewPath + "/id.txt", ID);
            File.WriteAllText(NewPath + "/text.txt", "Text");
            File.WriteAllText(NewPath + "/font.txt", "Consolas");
            File.WriteAllText(NewPath + "/fontsize.txt", "12");
            File.WriteAllText(NewPath + "/args.txt", "false");
            File.WriteAllText(NewPath + "/x.txt", "0");
            File.WriteAllText(NewPath + "/y.txt", "0");
            File.WriteAllText(NewPath + "/Functions.txt", "goto:");
            File.WriteAllText(NewPath + "/color.txt", "255,255,255");
        }
        public void RewriteText(string Menu, TextElement TextElement)
        {
            string ID = TextElement.ID;
            string Path = Menu + "/text_elements/" + ID;
            File.WriteAllText(Path + "/text.txt", TextElement.Text);
            File.WriteAllText(Path + "/font.txt", TextElement.FontName);
            File.WriteAllText(Path + "/fontsize.txt", Convert.ToString(TextElement.FontSize));
            File.WriteAllText(Path + "/args.txt", Convert.ToString(TextElement.args));
            File.WriteAllText(Path + "/x.txt", Convert.ToString(TextElement.X));
            File.WriteAllText(Path + "/y.txt", Convert.ToString(TextElement.Y));
            File.WriteAllText(Path + "/Functions.txt", TextElement.Functions);
            File.WriteAllText(Path + "/color.txt", TextElement.Color.R.ToString() + "," + TextElement.Color.G.ToString() + "," + TextElement.Color.B.ToString());
        }
        public void AddText(string Menu, TextElement TextElement)
        {
            var Preview = reborn.MenuPreview;
            if (TextElement.args == false)
            {
                Label Text = new Label();
                Text.Location = new Point(TextElement.X, TextElement.Y);
                Text.AutoSize = true;
                Text.BackColor = Color.Transparent;
                Text.FlatStyle = FlatStyle.Flat;
                Text.ForeColor = TextElement.Color;
                Text.Font = new Font(TextElement.Font, FontStyle.Regular);
                Text.Text = TextElement.Text;
                Text.Draggable(true);
                Text.Click += newText_Select;
                Text.Move += newText_Move;
                Text.MouseDoubleClick += Text_MouseDoubleClick;
                Text.Name = TextElement.ID;
                reborn.Element_Text_MenuEditor.TextChanged += TextChanged;
                reborn.Element_FontSize_MenuEditor.TextChanged += FontSizeChanged;
                reborn.Element_Color_MenuEditor.TextChanged += ColorChanged;
                reborn.Element_Font_MenuEditor.TextChanged += FontChanged;
                void FontChanged(object sender, EventArgs e)
                {
                    if (reborn.Element_ID_MenuEditor.Text == Text.Name)
                    {
                        try
                        {
                            TextElement.FontName = reborn.Element_Font_MenuEditor.Text;
                            RewriteText(Menu, TextElement);
                            RefreshText(Menu);
                        }
                        catch (ArgumentException)
                        {
                            TextElement.FontName = "Consolas";
                            RewriteText(Menu, TextElement);
                            RefreshText(Menu);
                        }
                    }
                }
                void TextChanged(object sender, EventArgs e)
                {
                    try
                    {
                        if (reborn.Element_ID_MenuEditor.Text == Text.Name)
                        {
                            TextElement.Text = reborn.Element_Text_MenuEditor.Text;
                            Text.Text = reborn.Element_Text_MenuEditor.Text;
                            RewriteText(Menu, TextElement);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                void ColorChanged(object sender, EventArgs e)
                {
                    try
                    {
                        if (reborn.Element_ID_MenuEditor.Text == Text.Name)
                        {
                            var RGB = reborn.Element_Color_MenuEditor.Text.Split(',');
                            if (RGB.Length == 3)
                            {
                                int R = Convert.ToInt32(RGB[0]);
                                int G = Convert.ToInt32(RGB[1]);
                                int B = Convert.ToInt32(RGB[2]);
                                TextElement.Color = Color.FromArgb(R, G, B);
                                RewriteText(Menu, TextElement);
                                RefreshText(Menu);
                            }
                            else
                            {

                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Oh no, an exception!!");
                    }
                }
                async void FontSizeChanged(object sender, EventArgs e)
                {
                    try
                    {
                        if (reborn.Element_ID_MenuEditor.Text == Text.Name)
                        {
                            float fontsize = Convert.ToSingle(reborn.Element_FontSize_MenuEditor.Text);
                            TextElement.FontSize = fontsize;
                            RewriteText(Menu, TextElement);
                            await Wait(1);
                            RefreshText(Menu);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                void newText_Select(object sender, EventArgs e)
                {
                    try
                    {
                        reborn.Element_Font_MenuEditor.Text = TextElement.FontName;
                        reborn.Element_ID_MenuEditor.Text = Text.Name;
                        reborn.Element_X_MenuEditor.Text = "X: " + Text.Location.X;
                        reborn.Element_Y_MenuEditor.Text = "Y: " + Text.Location.Y;
                        reborn.Element_Text_MenuEditor.Text = TextElement.Text;
                        reborn.Element_FontSize_MenuEditor.Text = Convert.ToString(TextElement.FontSize);
                        reborn.Element_Color_MenuEditor.Text = TextElement.Color.R.ToString() + "," + TextElement.Color.G.ToString() + "," + TextElement.Color.B.ToString();
                    }
                    catch (Exception)
                    {

                    }
                }
                void newText_Move(object sender, EventArgs e)
                {
                    try
                    {
                        TextElement.X = Text.Location.X;
                        TextElement.Y = Text.Location.Y;
                        RewriteText(Menu, TextElement);
                        reborn.Element_X_MenuEditor.Text = "X: " + Text.Location.X;
                        reborn.Element_Y_MenuEditor.Text = "Y: " + Text.Location.Y;
                    }
                    catch (Exception)
                    {

                    }
                }
                void Text_MouseDoubleClick(object sender, MouseEventArgs e)
                {
                    try
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            TextElement.args = true;
                            RewriteText(Menu, TextElement);
                            RefreshText(Menu);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                Preview.Controls.Add(Text);
            }
            else
            {

            }
        }
        public void RefreshText(string Menu)
        {
            reborn.MenuPreview.Controls.Clear();
            string[] TextElements = Directory.GetDirectories(Menu + "/text_elements");
            foreach (string TextElement in TextElements)
            {
                string id = File.ReadAllText(TextElement + "/id.txt");
                string text = File.ReadAllText(TextElement + "/text.txt");
                string args = File.ReadAllText(TextElement + "/args.txt");
                string fontname = File.ReadAllText(TextElement + "/font.txt");
                string fontsize_string = File.ReadAllText(TextElement + "/fontsize.txt");
                int x = Convert.ToInt32(File.ReadAllText(TextElement + "/x.txt"));
                int y = Convert.ToInt32(File.ReadAllText(TextElement + "/y.txt"));
                string colorTxt = File.ReadAllText(TextElement + "/color.txt");
                var SeparatedRGB = colorTxt.Split(',');
                int R = Convert.ToInt32(SeparatedRGB[0]);
                int G = Convert.ToInt32(SeparatedRGB[1]);
                int B = Convert.ToInt32(SeparatedRGB[2]);
                int fontsize = Convert.ToInt32(fontsize_string);

                FontFamily fontfamily;

                try
                {
                    fontfamily = new FontFamily(fontname);
                }
                catch (Exception)
                {
                    fontfamily = new FontFamily("Consolas");
                }

                Font font = new Font(fontfamily, fontsize, FontStyle.Regular);

                TextElement NewText = new TextElement
                {
                    ID = id,
                    Text = text,
                    FontSize = fontsize,
                    Font = font,
                    FontName = fontname,
                    X = x,
                    Y = y,
                    args = Convert.ToBoolean(args),
                    Color = Color.FromArgb(R, G, B)
                };
                AddText(Menu, NewText);
            }
        }
    }
}
