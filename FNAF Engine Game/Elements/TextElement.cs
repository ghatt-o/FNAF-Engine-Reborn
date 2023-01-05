using System.Drawing;
using System.Windows.Forms;

namespace FNAF_Engine_Game.Elements
{
    public class TextElement : Label
    {
        public short type
        {
            get
            {
                return type;
            }
            set
            {
                if (type == 1) this.FlatStyle = FlatStyle.System;
                else this.FlatStyle = FlatStyle.Flat;
            }
        }

        public TextFont TFont
        {
            set { Font = new(value.FontName, value.FontSize); }
        }

        public bool args
        {
            set
            {
                if (value == true)
                {
                    Visible = false;
                }
                else
                {
                    Visible = true;
                }
            }
        }
        public Color Color
        {
            set
            {
                ForeColor = value;
            }
        }
    }

    public class TextFont
    {
        public string FontName = "Consolas";
        public float FontSize = 9f;

        public TextFont(string FontName, float FontSize)
        {
            this.FontName = FontName;
            this.FontSize = FontSize;
        }
    }
}
