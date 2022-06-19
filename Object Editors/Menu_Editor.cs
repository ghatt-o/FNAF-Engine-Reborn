using System.IO;

namespace FNAF_Engine_Reborn.Object_Editors
{
    class Menu_Editor
    {
        public void RefreshText(string Project, string Menu)
        {
            string[] TextElements = Directory.GetDirectories(Project + "/menus/" + Menu + "/textelements");
            foreach (string TextElement in TextElements)
            {

            }
        }
    }
}
