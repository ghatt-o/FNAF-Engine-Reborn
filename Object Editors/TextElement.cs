using System.Drawing;

namespace FNAF_Engine_Reborn.Object_Editors
{
    internal class TextElement
    {
        public string ID { get; set; }
        public string Text { get; set; }
        public float FontSize { get; set; }
        public Font Font { get; set; }
        public string FontName { get; set; }
        public bool Hidden { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool args { get; set; }
        public string Functions { get; set; }
        public string FunctionsHover { get; set; }
        public string FunctionsHold { get; set; }
        public Color Color { get; set; }
    }
}
