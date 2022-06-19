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
                MessageBox.Show("Select a project or create one if you haven't!");
            }
            else
            {
                reborn reborn = new reborn();
                label3.Text = comboBox1.SelectedItem.ToString();
                string sus = comboBox1.SelectedItem.ToString();
                reborn rebor = Application.OpenForms.OfType<reborn>().Single();
                rebor.load_editors();
                rebor.projecto = comboBox1.SelectedItem.ToString();
                reborn.projecto = comboBox1.SelectedItem.ToString();
                this.Hide();
            }
        }

        private void loadFERproject_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                try
                {
                    label3.Text = comboBox1.SelectedItem.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex + ": No project loaded");
                }
            }
        }
    }
}
