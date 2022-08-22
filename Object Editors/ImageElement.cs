using System.Drawing;

namespace FNAF_Engine_Reborn.Object_Editors
{
    internal class ImageElement
    {
        public string ID { get; set; }
        public bool Hidden { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool args { get; set; }
        public string Functions { get; set; }
        public string FunctionsHover { get; set; }
        public string FunctionsHold { get; set; }
    }
}
