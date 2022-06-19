using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn.Object_Editors
{
    class TextElement
    {
        public string ID { get; set; }
        public string Text { get; set; }
        public float FontSize { get; set; }
        public Font Font { get; set; }
        public bool Hidden { get; set; }
    }
}
