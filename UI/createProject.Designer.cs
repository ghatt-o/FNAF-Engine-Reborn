
namespace FNAF_Engine_Reborn
{
    partial class createProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createProject));
            this.projectNamelbl = new System.Windows.Forms.Label();
            this.projectNamebox = new System.Windows.Forms.TextBox();
            this.createProjectbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fnaf4style_CheckBox = new System.Windows.Forms.CheckBox();
            this.gameStyleOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectNamelbl
            // 
            this.projectNamelbl.AutoSize = true;
            this.projectNamelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.projectNamelbl.Font = new System.Drawing.Font("Digital-7", 15F);
            this.projectNamelbl.ForeColor = System.Drawing.SystemColors.Window;
            this.projectNamelbl.Location = new System.Drawing.Point(12, 1);
            this.projectNamelbl.Name = "projectNamelbl";
            this.projectNamelbl.Size = new System.Drawing.Size(114, 21);
            this.projectNamelbl.TabIndex = 0;
            this.projectNamelbl.Text = "Project Name";
            // 
            // projectNamebox
            // 
            this.projectNamebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.projectNamebox.ForeColor = System.Drawing.SystemColors.Window;
            this.projectNamebox.Location = new System.Drawing.Point(15, 20);
            this.projectNamebox.Name = "projectNamebox";
            this.projectNamebox.Size = new System.Drawing.Size(185, 20);
            this.projectNamebox.TabIndex = 1;
            // 
            // createProjectbtn
            // 
            this.createProjectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.createProjectbtn.Font = new System.Drawing.Font("Digital-7", 15F);
            this.createProjectbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.createProjectbtn.Location = new System.Drawing.Point(33, 137);
            this.createProjectbtn.Name = "createProjectbtn";
            this.createProjectbtn.Size = new System.Drawing.Size(156, 43);
            this.createProjectbtn.TabIndex = 14;
            this.createProjectbtn.Text = "Create";
            this.createProjectbtn.UseVisualStyleBackColor = false;
            this.createProjectbtn.Click += new System.EventHandler(this.createProjectbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Digital-7", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Project Template";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Premade Assets",
            "Premade Menus",
            "Required Empty Menus",
            "John\'s Template"});
            this.comboBox1.Location = new System.Drawing.Point(15, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-190, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 618);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // fnaf4style_CheckBox
            // 
            this.fnaf4style_CheckBox.Enabled = false;
            this.fnaf4style_CheckBox.Font = new System.Drawing.Font("Digital-7", 15F);
            this.fnaf4style_CheckBox.Location = new System.Drawing.Point(212, 42);
            this.fnaf4style_CheckBox.Name = "fnaf4style_CheckBox";
            this.fnaf4style_CheckBox.Size = new System.Drawing.Size(141, 22);
            this.fnaf4style_CheckBox.TabIndex = 20;
            this.fnaf4style_CheckBox.Text = "FNAF 4 Style";
            this.fnaf4style_CheckBox.UseVisualStyleBackColor = true;
            this.fnaf4style_CheckBox.Visible = false;
            // 
            // gameStyleOptions
            // 
            this.gameStyleOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gameStyleOptions.ForeColor = System.Drawing.SystemColors.Window;
            this.gameStyleOptions.FormattingEnabled = true;
            this.gameStyleOptions.Items.AddRange(new object[] {
            "Five Nights at Freddy\'s (Beta)"});
            this.gameStyleOptions.Location = new System.Drawing.Point(210, 20);
            this.gameStyleOptions.Name = "gameStyleOptions";
            this.gameStyleOptions.Size = new System.Drawing.Size(188, 21);
            this.gameStyleOptions.TabIndex = 22;
            this.gameStyleOptions.SelectedIndexChanged += new System.EventHandler(this.gameStyleOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("Digital-7", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(207, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Game Style";
            // 
            // createProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(414, 307);
            this.Controls.Add(this.gameStyleOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fnaf4style_CheckBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createProjectbtn);
            this.Controls.Add(this.projectNamebox);
            this.Controls.Add(this.projectNamelbl);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "createProject";
            this.Text = "Project Creator";
            this.Load += new System.EventHandler(this.createProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNamelbl;
        private System.Windows.Forms.TextBox projectNamebox;
        private System.Windows.Forms.Button createProjectbtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox fnaf4style_CheckBox;
        public System.Windows.Forms.ComboBox gameStyleOptions;
        private System.Windows.Forms.Label label2;
    }
}