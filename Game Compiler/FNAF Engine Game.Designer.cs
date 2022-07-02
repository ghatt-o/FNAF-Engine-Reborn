
namespace FNAF_Engine_Reborn
{
    partial class FNAF_Engine_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNAF_Engine_Game));
            this.Main = new System.Windows.Forms.Panel();
            this.Office = new System.Windows.Forms.Panel();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main.Controls.Add(this.Office);
            this.Main.Location = new System.Drawing.Point(0, 2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1442, 859);
            this.Main.TabIndex = 0;
            this.Main.VisibleChanged += new System.EventHandler(this.Main_VisibleChanged);
            // 
            // Office
            // 
            this.Office.Location = new System.Drawing.Point(2, -3);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(1442, 859);
            this.Office.TabIndex = 1;
            this.Office.Paint += new System.Windows.Forms.PaintEventHandler(this.Office_Paint);
            // 
            // FNAF_Engine_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1444, 860);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FNAF_Engine_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNAF Engine: Reborn Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FNAF_Engine_Game_Load_1);
            this.VisibleChanged += new System.EventHandler(this.FNAF_Engine_Game_VisibleChanged);
            this.Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel Office;
    }
}