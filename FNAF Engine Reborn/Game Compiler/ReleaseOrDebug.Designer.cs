
namespace FNAF_Engine_Reborn
{
    partial class ReleaseOrDebug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleaseOrDebug));
            this.button113 = new System.Windows.Forms.Button();
            this.ptemplate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label71 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button113
            // 
            this.button113.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button113.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button113.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button113.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button113.ForeColor = System.Drawing.Color.White;
            this.button113.Location = new System.Drawing.Point(80, 73);
            this.button113.Name = "button113";
            this.button113.Size = new System.Drawing.Size(107, 31);
            this.button113.TabIndex = 122;
            this.button113.Text = "Debug Mode";
            this.button113.UseVisualStyleBackColor = false;
            this.button113.MouseEnter += new System.EventHandler(this.button113_MouseEnter);
            // 
            // ptemplate
            // 
            this.ptemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ptemplate.ForeColor = System.Drawing.Color.White;
            this.ptemplate.Location = new System.Drawing.Point(77, 6);
            this.ptemplate.Name = "ptemplate";
            this.ptemplate.Size = new System.Drawing.Size(283, 65);
            this.ptemplate.TabIndex = 123;
            this.ptemplate.Text = "The game has 2 modes; Debug and Release, You can use Debug if there\'s a script th" +
    "at runs in only debug mode.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(250, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 124;
            this.button1.Text = "Release Mode";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // label71
            // 
            this.label71.Image = ((System.Drawing.Image)(resources.GetObject("label71.Image")));
            this.label71.Location = new System.Drawing.Point(215, 78);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(34, 19);
            this.label71.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 126;
            this.label1.Text = "Loading...";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 91);
            this.label2.TabIndex = 127;
            this.label2.Text = "Game style: ";
            this.label2.Visible = false;
            // 
            // ReleaseOrDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(405, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptemplate);
            this.Controls.Add(this.button113);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReleaseOrDebug";
            this.Text = "Testing Game";
            this.Load += new System.EventHandler(this.ReleaseOrDebug_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button113;
        private System.Windows.Forms.Label ptemplate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}