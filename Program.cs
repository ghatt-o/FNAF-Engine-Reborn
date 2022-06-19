using System;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Directory.Exists(@"assets"))
            {

            }
            else
            {
                Directory.CreateDirectory(@"assets");
                Directory.CreateDirectory(@"assets/extensions");
                Directory.CreateDirectory(@"assets/images");
                Directory.CreateDirectory(@"assets/music");
                Directory.CreateDirectory(@"assets/templates");
                Directory.CreateDirectory(@"assets/custom_assets");
                Directory.CreateDirectory(@"assets/custom_assets/extensions");
                Directory.CreateDirectory(@"assets/custom_assets/images");
                Directory.CreateDirectory(@"assets/custom_assets/music");
                Directory.CreateDirectory(@"assets/custom_assets/projects");
                Directory.CreateDirectory(@"assets/custom_assets/templates");
                MessageBox.Show("Building assets... (Please click OK to continue!)");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new reborn());
        }
    }
}
