using System.Windows.Forms;

namespace FNAF_Engine_Game
{
    public class FER_Game
    {
        public FNAF_Engine_Game ferg;
        public FER_Game(FNAF_Engine_Game ferg)
        {
            this.ferg = ferg;
        }

        public void CreateElement(Elements.TextElement text_element, string menu)
        {
            Panel menupanel = (Panel)ferg.Controls[menu];
            menupanel.Controls.Add(text_element);
        }
    }
}
