using System;
using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn.bin
{
    public partial class MinigameMaker : Form
    {
        public string currentMinigame;
        public string projecto;
        public bool buildMode;

        public MinigameMaker()
        {
            InitializeComponent();
        }

        private void MinigameMaker_Load(object sender, EventArgs e)
        {
            loadFERproject projectloader = new loadFERproject();
            _ = projectloader.label3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpriteAdd.Visible = true;
        }

        private void createSpritebtn_Click(object sender, EventArgs e)
        {
            //Label newLabel = new Label();
            //this.Controls.Add(newLabel);
            SpriteAdd.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            comboBox1.Enabled = false;
            button11.Visible = true;
            panel1.Visible = true;
            buildMode = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            comboBox1.Enabled = true;
            button11.Visible = false;
            panel1.Visible = false;
            buildMode = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                _ = MessageBox.Show("Select a minigame!");
            }
            else
            {
                currentMinigame = projecto + "/minigames/" + comboBox1.SelectedItem.ToString();
            }
        }

        private void MinigameMaker_VisibleChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(projecto + "/minigames") == false)
            {
                _ = MessageBox.Show("Something went wrong! Fixing...");
                _ = Directory.CreateDirectory(projecto + "/minigames");
                comboBox1.Items.Clear();
                currentMinigame = "";
                _ = MessageBox.Show("Fixed!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(System.IO.Directory.GetDirectories(projecto + "/minigames/"));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string minigameBTBC = textBox1.Text;
            _ = Directory.CreateDirectory(projecto + "/minigames/" + minigameBTBC);
            panel2.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
