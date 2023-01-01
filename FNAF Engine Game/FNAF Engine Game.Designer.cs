
using System.Windows.Forms;

namespace FNAF_Engine_Game
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
            this.Error = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Loading = new System.Windows.Forms.Panel();
            this.LoadingIcon = new System.Windows.Forms.PictureBox();
            this.Office = new System.Windows.Forms.Panel();
            this.OfficeBackground = new System.Windows.Forms.PictureBox();
            this.Night_Start = new System.Windows.Forms.Panel();
            this.nightLBL = new System.Windows.Forms.Label();
            this.TwelveAM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Invisible = new System.Windows.Forms.Label();
            this.Error.SuspendLayout();
            this.Loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIcon)).BeginInit();
            this.Office.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBackground)).BeginInit();
            this.Night_Start.SuspendLayout();
            this.SuspendLayout();
            // 
            // Error
            // 
            this.Error.BackColor = System.Drawing.Color.DodgerBlue;
            this.Error.Controls.Add(this.Description);
            this.Error.Controls.Add(this.Title);
            this.Error.Location = new System.Drawing.Point(0, 10);
            this.Error.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(1280, 720);
            this.Error.TabIndex = 2;
            this.Error.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.ForeColor = System.Drawing.SystemColors.Control;
            this.Description.Location = new System.Drawing.Point(66, 125);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(112, 28);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.Control;
            this.Title.Location = new System.Drawing.Point(63, 53);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(84, 46);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title";
            // 
            // Loading
            // 
            this.Loading.BackColor = System.Drawing.Color.Black;
            this.Loading.Controls.Add(this.LoadingIcon);
            this.Loading.Location = new System.Drawing.Point(0, -8);
            this.Loading.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(1280, 720);
            this.Loading.TabIndex = 2;
            // 
            // LoadingIcon
            // 
            this.LoadingIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadingIcon.Location = new System.Drawing.Point(1624, 999);
            this.LoadingIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadingIcon.Name = "LoadingIcon";
            this.LoadingIcon.Size = new System.Drawing.Size(57, 58);
            this.LoadingIcon.TabIndex = 0;
            this.LoadingIcon.TabStop = false;
            // 
            // Office
            // 
            this.Office.BackColor = System.Drawing.Color.Black;
            this.Office.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Office.Controls.Add(this.OfficeBackground);
            this.Office.Location = new System.Drawing.Point(0, 1);
            this.Office.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(1280, 720);
            this.Office.TabIndex = 2;
            this.Office.Visible = false;
            // 
            // OfficeBackground
            // 
            this.OfficeBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OfficeBackground.Location = new System.Drawing.Point(0, 0);
            this.OfficeBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OfficeBackground.Name = "OfficeBackground";
            this.OfficeBackground.Size = new System.Drawing.Size(1280, 720);
            this.OfficeBackground.TabIndex = 0;
            this.OfficeBackground.TabStop = false;
            // 
            // Night_Start
            // 
            this.Night_Start.BackColor = System.Drawing.Color.Black;
            this.Night_Start.Controls.Add(this.nightLBL);
            this.Night_Start.Controls.Add(this.TwelveAM);
            this.Night_Start.Controls.Add(this.label3);
            this.Night_Start.Controls.Add(this.label2);
            this.Night_Start.Controls.Add(this.label1);
            this.Night_Start.Controls.Add(this.Invisible);
            this.Night_Start.Location = new System.Drawing.Point(0, 0);
            this.Night_Start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Night_Start.Name = "Night_Start";
            this.Night_Start.Size = new System.Drawing.Size(1280, 720);
            this.Night_Start.TabIndex = 4;
            this.Night_Start.Visible = false;
            this.Night_Start.VisibleChanged += new System.EventHandler(this.Night_Start_VisibleChanged);
            // 
            // nightLBL
            // 
            this.nightLBL.AutoSize = true;
            this.nightLBL.Font = new System.Drawing.Font("Consolas", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nightLBL.ForeColor = System.Drawing.SystemColors.Window;
            this.nightLBL.Location = new System.Drawing.Point(727, 420);
            this.nightLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nightLBL.Name = "nightLBL";
            this.nightLBL.Size = new System.Drawing.Size(197, 52);
            this.nightLBL.TabIndex = 1;
            this.nightLBL.Text = "Night 1";
            // 
            // TwelveAM
            // 
            this.TwelveAM.AutoSize = true;
            this.TwelveAM.Font = new System.Drawing.Font("Consolas", 27.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TwelveAM.ForeColor = System.Drawing.SystemColors.Window;
            this.TwelveAM.Location = new System.Drawing.Point(736, 378);
            this.TwelveAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TwelveAM.Name = "TwelveAM";
            this.TwelveAM.Size = new System.Drawing.Size(179, 43);
            this.TwelveAM.TabIndex = 0;
            this.TwelveAM.Text = "12:00 AM";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 300.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(-134, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2247, 561);
            this.label3.TabIndex = 4;
            this.label3.Text = "_________________";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 300.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(-201, -459);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2247, 630);
            this.label2.TabIndex = 3;
            this.label2.Text = "_________________";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 300.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(-282, -301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2247, 530);
            this.label1.TabIndex = 5;
            this.label1.Text = "_________________";
            // 
            // Invisible
            // 
            this.Invisible.Font = new System.Drawing.Font("Consolas", 300.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Invisible.ForeColor = System.Drawing.SystemColors.Window;
            this.Invisible.Location = new System.Drawing.Point(-282, 429);
            this.Invisible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Invisible.Name = "Invisible";
            this.Invisible.Size = new System.Drawing.Size(2247, 528);
            this.Invisible.TabIndex = 1;
            this.Invisible.Text = "_________________";
            this.Invisible.Visible = false;
            // 
            // FNAF_Engine_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1460, 920);
            this.Controls.Add(this.Office);
            this.Controls.Add(this.Night_Start);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FNAF_Engine_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNAF Engine: Reborn Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FNAF_Engine_Game_Load_1);
            this.VisibleChanged += new System.EventHandler(this.FNAF_Engine_Game_VisibleChanged);
            this.Error.ResumeLayout(false);
            this.Error.PerformLayout();
            this.Loading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIcon)).EndInit();
            this.Office.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBackground)).EndInit();
            this.Night_Start.ResumeLayout(false);
            this.Night_Start.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Error;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label nightLBL;
        private System.Windows.Forms.Label TwelveAM;
        private System.Windows.Forms.Panel Night_Start;
        private System.Windows.Forms.Panel Office;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Invisible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Panel Loading;
        private PictureBox LoadingIcon;
        private PictureBox OfficeBackground;
    }
}