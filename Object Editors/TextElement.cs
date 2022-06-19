using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn.Object_Editors
{
    class TextElement
    {
        public string Project { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public string FontSize { get; set; }
        public string Font { get; set; }
        public string Hidden { get; set; }
        public void CreateText(string ID)
        {
            string Path = Project + "/menus/";
            Directory.CreateDirectory(Path + ID);
            File.WriteAllText(Path + ID + "/text.txt", "Text");
            File.WriteAllText(Path + ID + "/fontsize.txt", "12");
            File.WriteAllText(Path + ID + "/font.txt", "Consolas");
        }
        public void SortData(string a)
        {

        }
    }
}
