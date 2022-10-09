using System;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (Directory.Exists(@"assets"))
            {

            }
            else
            {
                _ = Directory.CreateDirectory(@"assets");
                _ = Directory.CreateDirectory(@"assets/files/");
                _ = Directory.CreateDirectory(@"assets/extensions");
                _ = Directory.CreateDirectory(@"assets/images");
                _ = Directory.CreateDirectory(@"assets/music");
                _ = Directory.CreateDirectory(@"assets/templates");
                _ = Directory.CreateDirectory(@"assets/custom_assets");
                _ = Directory.CreateDirectory(@"assets/custom_assets/extensions");
                _ = Directory.CreateDirectory(@"assets/custom_assets/images");
                _ = Directory.CreateDirectory(@"assets/custom_assets/music");
                _ = Directory.CreateDirectory(@"assets/custom_assets/projects");
                _ = Directory.CreateDirectory(@"assets/custom_assets/templates");
                _ = MessageBox.Show("Building assets... (Please click OK to continue!)");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new reborn());
        }
    }
}
