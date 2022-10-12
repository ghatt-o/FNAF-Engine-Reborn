using System.Drawing;
using System.Windows.Forms;

namespace FNAF_Engine_Game.Elements
{
    public class TextElement : Label
    {
        public string FontName
        {
            get
            {
                return FontName;
            }
            set
            {
                FontName = value;
                Font = new System.Drawing.Font(FontName, FontSize);
            }
        }
        public float FontSize
        {
            get
            {
                return FontSize;
            }
            set
            {
                FontSize = value;
                Font = new System.Drawing.Font(FontName, FontSize);
            }
        }
        public bool args
        {
            get
            {
                return args;
            }
            set
            {
                if (value == true)
                {
                    Visible = false;
                    args = true;
                }
                else
                {
                    Visible = true;
                    args = false;
                }
            }
        }
        public Color Color
        {
            get
            {
                return Color;
            }
            set
            {
                Color = value;
                ForeColor = Color;
            }
        }
    }
}
