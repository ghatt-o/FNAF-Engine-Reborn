
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
            this.projectNamebox = new System.Windows.Forms.TextBox();
            this.createProjectbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fnaf4style_CheckBox = new System.Windows.Forms.CheckBox();
            this.gameStyleOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectNamebox
            // 
            this.projectNamebox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.projectNamebox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.projectNamebox.Location = new System.Drawing.Point(13, 43);
            this.projectNamebox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.projectNamebox.Name = "projectNamebox";
            this.projectNamebox.Size = new System.Drawing.Size(219, 23);
            this.projectNamebox.TabIndex = 1;
            // 
            // createProjectbtn
            // 
            this.createProjectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(0)))));
            this.createProjectbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(0)))));
            this.createProjectbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.createProjectbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.createProjectbtn.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createProjectbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createProjectbtn.Location = new System.Drawing.Point(13, 222);
            this.createProjectbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createProjectbtn.Name = "createProjectbtn";
            this.createProjectbtn.Size = new System.Drawing.Size(219, 50);
            this.createProjectbtn.TabIndex = 14;
            this.createProjectbtn.Text = "Create";
            this.createProjectbtn.UseVisualStyleBackColor = false;
            this.createProjectbtn.Click += new System.EventHandler(this.createProjectbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Premade Assets",
            "Premade Menus",
            "Required Empty Menus",
            "John\'s Template"});
            this.comboBox1.Location = new System.Drawing.Point(13, 99);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 23);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(409, 317);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 713);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // fnaf4style_CheckBox
            // 
            this.fnaf4style_CheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fnaf4style_CheckBox.Enabled = false;
            this.fnaf4style_CheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnaf4style_CheckBox.ForeColor = System.Drawing.Color.White;
            this.fnaf4style_CheckBox.Location = new System.Drawing.Point(13, 185);
            this.fnaf4style_CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fnaf4style_CheckBox.Name = "fnaf4style_CheckBox";
            this.fnaf4style_CheckBox.Size = new System.Drawing.Size(164, 31);
            this.fnaf4style_CheckBox.TabIndex = 20;
            this.fnaf4style_CheckBox.Text = "FNAF 4 Style";
            this.fnaf4style_CheckBox.UseVisualStyleBackColor = false;
            this.fnaf4style_CheckBox.Visible = false;
            // 
            // gameStyleOptions
            // 
            this.gameStyleOptions.BackColor = System.Drawing.Color.White;
            this.gameStyleOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameStyleOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gameStyleOptions.FormattingEnabled = true;
            this.gameStyleOptions.Items.AddRange(new object[] {
            "???",
            "Five Nights at Freddy\'s (Beta)"});
            this.gameStyleOptions.Location = new System.Drawing.Point(13, 156);
            this.gameStyleOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameStyleOptions.Name = "gameStyleOptions";
            this.gameStyleOptions.Size = new System.Drawing.Size(219, 23);
            this.gameStyleOptions.TabIndex = 22;
            this.gameStyleOptions.SelectedIndexChanged += new System.EventHandler(this.gameStyleOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Game Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Project Template";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Project Name";
            // 
            // createProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(245, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameStyleOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fnaf4style_CheckBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.createProjectbtn);
            this.Controls.Add(this.projectNamebox);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "createProject";
            this.Text = "Project Creator";
            this.Load += new System.EventHandler(this.createProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox projectNamebox;
        private System.Windows.Forms.Button createProjectbtn;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox fnaf4style_CheckBox;
        public System.Windows.Forms.ComboBox gameStyleOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}