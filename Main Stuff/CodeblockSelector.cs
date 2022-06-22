using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn.Main_Stuff
{
    public partial class CodeblockSelector : Form
    {
        public string Path;
        public CodeblockSelector(reborn reborn)
        {
            InitializeComponent();
        }

        private void CodeblockSelector_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Events_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedevent = Events.SelectedNode.ToString();
        }
    }
}
