using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class Compiler : Form
    {

        public Compiler(reborn reborn)
        {
            InitializeComponent();
            this.reborn = reborn;
        }

        public reborn reborn { get; }

        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");
            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destinationDir);
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }

        public async Task Wait(int miliseconds)
        {
            await Task.Delay(miliseconds);
        }

        private async void Compiler_Load(object sender, EventArgs e)
        {
            try
            {
                await Wait(300);
                Compiling_Progress.Value += 5;
                string game_name = File.ReadAllText(reborn.projecto + "/game.txt");
                string project_name = File.ReadAllText(reborn.projecto + "/name.txt");
                try
                {
                    Directory.Delete($@"Exports/{game_name}", true);
                }
                catch (Exception)
                {

                }
                Directory.CreateDirectory(@"Exports/");
                Compiling_Progress.Value += 5;
                await Wait(300);
                Directory.CreateDirectory($@"Exports/{game_name}");
                Compiling_Progress.Value += 7;
                await Wait(300);
                Directory.CreateDirectory($@"Exports/{game_name}/assets/");
                Compiling_Progress.Value += 1;
                await Wait(300);
                CopyDirectory($"{reborn.projecto}", $@"Exports/{game_name}/assets", true);
                Compiling_Progress.Value += 50;
                await Wait(300);
                CopyDirectory(@"assets/files", $@"Exports/{game_name}/", true);
                await Wait(300);
                Compiling_Progress.Value += 5;
                await Wait(300);
                Compiling_Progress.Value += 6;
                await Wait(300);
                Compiling_Progress.Value += 18;
                MessageBox.Show($"Game successfully compiled to {Application.StartupPath}/Exports/{game_name}! (CLICK OK TO CONTINUE)");
                //compiled to Exports/projectname/Game.exe
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to compile!! (CLICK OK TO CONTINUE)");
            }
            finally
            {
                this.Hide();
            }
        }
    }
}
