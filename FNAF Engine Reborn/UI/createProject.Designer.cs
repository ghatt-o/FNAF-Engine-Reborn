
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
            projectNamebox = new System.Windows.Forms.TextBox();
            createProjectbtn = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            gameStyleOptions = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // projectNamebox
            // 
            projectNamebox.BackColor = System.Drawing.Color.White;
            projectNamebox.ForeColor = System.Drawing.Color.Black;
            projectNamebox.Location = new System.Drawing.Point(13, 43);
            projectNamebox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            projectNamebox.Name = "projectNamebox";
            projectNamebox.Size = new System.Drawing.Size(219, 23);
            projectNamebox.TabIndex = 1;
            // 
            // createProjectbtn
            // 
            createProjectbtn.BackColor = System.Drawing.Color.FromArgb(0, 225, 0);
            createProjectbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 225, 0);
            createProjectbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 155, 0);
            createProjectbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 195, 0);
            createProjectbtn.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createProjectbtn.ForeColor = System.Drawing.Color.Black;
            createProjectbtn.Location = new System.Drawing.Point(13, 222);
            createProjectbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            createProjectbtn.Name = "createProjectbtn";
            createProjectbtn.Size = new System.Drawing.Size(219, 50);
            createProjectbtn.TabIndex = 14;
            createProjectbtn.Text = "Create";
            createProjectbtn.UseVisualStyleBackColor = false;
            createProjectbtn.Click += createProjectbtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.White;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = System.Drawing.Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Premade Assets", "Premade Menus", "Required Empty Menus", "John's Template" });
            comboBox1.Location = new System.Drawing.Point(13, 99);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(219, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(409, 317);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(572, 713);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // gameStyleOptions
            // 
            gameStyleOptions.BackColor = System.Drawing.Color.White;
            gameStyleOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            gameStyleOptions.ForeColor = System.Drawing.Color.Black;
            gameStyleOptions.FormattingEnabled = true;
            gameStyleOptions.Items.AddRange(new object[] { "Standard", "Five Nights at Freddy's 1-3", "Five Nights at Freddy's 4", "Five Nights at Freddy's 5 (Beta)", "Five Nights at Freddy's 6 (Beta)", "FNAF World (Beta)" });
            gameStyleOptions.Location = new System.Drawing.Point(13, 156);
            gameStyleOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gameStyleOptions.Name = "gameStyleOptions";
            gameStyleOptions.Size = new System.Drawing.Size(219, 23);
            gameStyleOptions.TabIndex = 22;
            gameStyleOptions.SelectedIndexChanged += gameStyleOptions_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(9, 125);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 28);
            label2.TabIndex = 21;
            label2.Text = "Game Style";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(9, 69);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 28);
            label1.TabIndex = 23;
            label1.Text = "Project Template";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(9, 12);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 28);
            label3.TabIndex = 24;
            label3.Text = "Project Name";
            // 
            // createProject
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ClientSize = new System.Drawing.Size(245, 291);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(gameStyleOptions);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(createProjectbtn);
            Controls.Add(projectNamebox);
            Controls.Add(pictureBox1);
            ForeColor = System.Drawing.SystemColors.Window;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "createProject";
            Text = "Project Creator";
            Load += createProject_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox projectNamebox;
        private System.Windows.Forms.Button createProjectbtn;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox gameStyleOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}