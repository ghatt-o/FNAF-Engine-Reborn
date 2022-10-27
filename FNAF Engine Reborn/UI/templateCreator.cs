using System;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn
{
    public partial class templateCreator : Form
    {
        public templateCreator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Select a project to serve as template!");
                    Directory.CreateDirectory("assets/custom_assets/templates/" + textBox1.Text);
                }
                try
                {
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(Directory.GetDirectories("assets/custom_assets/templates/"));
                }
                catch (Exception)
                {

                }
                try
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(Directory.GetDirectories("assets/custom_assets/templates/"));
                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {
                if (textBox1.Text == null)
                {
                    _ = MessageBox.Show("Special characters are not allowed!");
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void templateCreator_Load_1(object sender, EventArgs e)
        {
            try
            {
                comboBox3.Items.AddRange(System.IO.Directory.GetDirectories("assets/custom_assets/templates/"));
            }
            catch (Exception)
            {

            }
            try
            {
                comboBox2.Items.AddRange(Directory.GetDirectories("assets/custom_assets/templates/"));
            }
            catch (Exception)
            {

            }
            try
            {
                comboBox1.Items.AddRange(Directory.GetDirectories("assets/custom_assets/projects/"));
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(comboBox3.SelectedItem.ToString(), true);
                _ = MessageBox.Show("Deleted template!");
                try
                {
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(System.IO.Directory.GetDirectories("assets/custom_assets/templates/"));
                }
                catch (Exception)
                {

                }
                try
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(System.IO.Directory.GetDirectories("assets/custom_assets/templates/"));
                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Select a template!");
            }
        }
    }
}
