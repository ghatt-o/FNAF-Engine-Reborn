
namespace FNAF_Engine_Reborn
{
    partial class Deleteproject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deleteproject));
            comboBox1 = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.White;
            comboBox1.ForeColor = System.Drawing.Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(12, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(240, 23);
            comboBox1.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(220, 0, 0);
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 0, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(175, 0, 0);
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(195, 0, 0);
            button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(12, 45);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(240, 46);
            button2.TabIndex = 10;
            button2.Text = "DELETE PROJECT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(238, 30);
            label2.TabIndex = 9;
            label2.Text = "WARNING: This action is irreversable, if you \r\ndelete your project you cannot recover it!";
            // 
            // Deleteproject
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ClientSize = new System.Drawing.Size(264, 136);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.White;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Deleteproject";
            Text = "Delete Project";
            Load += Deleteproject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}