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

        public string FontName
        {
            get
            {
                return FontName;
            }
            set
            {
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
                }
                else
                {
                    Visible = true;
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
                ForeColor = Color;
            }
        }
    }
}
