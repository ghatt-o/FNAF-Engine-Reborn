using System;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn.Main_Stuff
{
    public partial class CodeblockSelector : Form
    {
        private string all = "";
        private readonly reborn reborn;
        public string Path;
        public CodeblockSelector(reborn reborn)
        {
            InitializeComponent();
            this.reborn = reborn;
        }

        private void CodeblockSelector_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Events_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Events.SelectedNode.Tag.ToString() == "Cat")
            {

            }
            else
            {
                Console.WriteLine(Events.SelectedNode.ToString());
                string[] separated = Events.SelectedNode.ToString().Split(' ');
                separated.SetValue("", 0);
                _ = separated.Length;
                foreach (string text in separated)
                {
                    all = all + " " + text;
                }
                ScriptEditor scripteditor = new ScriptEditor();
                scripteditor.AddEvent(reborn.script, all);
                reborn.button10.Hide();
                string event_ = scripteditor.ToEvent(reborn.script);
                reborn.button25.Show();
                reborn.button25.Text = event_;
                Console.WriteLine("event isss: " + event_);
                reborn.button26.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
