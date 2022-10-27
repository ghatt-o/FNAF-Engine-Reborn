using System;
using System.Linq;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class loadFERproject : Form
    {
        public loadFERproject()
        {
            InitializeComponent();
        }
        private void loadFERproject_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(System.IO.Directory.GetDirectories(@"assets/custom_assets/projects/"));
            }
            catch (Exception)
            {
                //nice
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                _ = MessageBox.Show("Select a project or create one if you haven't!");
            }
            else
            {
                label3.Text = comboBox1.SelectedItem.ToString();
                _ = comboBox1.SelectedItem.ToString();
                reborn reb = Application.OpenForms.OfType<reborn>().FirstOrDefault();
                reb.GetFunctions(comboBox1.SelectedItem.ToString());
                reb.load_editors(comboBox1.SelectedItem.ToString());
                Hide();
            }
        }

        private void loadFERproject_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                try
                {
                    if (comboBox1.SelectedItem == null)
                    {

                    }
                    else
                    {
                        label3.Text = comboBox1.SelectedItem.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex + ": No project loaded");
                }
            }
        }
    }
}
