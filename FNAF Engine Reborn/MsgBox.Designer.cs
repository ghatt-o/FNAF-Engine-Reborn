namespace FNAF_Engine_Reborn
{
    partial class MsgBox
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
            this.createProjectbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createProjectbtn
            // 
            this.createProjectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(0)))));
            this.createProjectbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(0)))));
            this.createProjectbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.createProjectbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.createProjectbtn.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createProjectbtn.ForeColor = System.Drawing.Color.Black;
            this.createProjectbtn.Location = new System.Drawing.Point(415, 90);
            this.createProjectbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createProjectbtn.Name = "createProjectbtn";
            this.createProjectbtn.Size = new System.Drawing.Size(259, 75);
            this.createProjectbtn.TabIndex = 15;
            this.createProjectbtn.Text = "OK";
            this.createProjectbtn.UseVisualStyleBackColor = false;
            this.createProjectbtn.Click += new System.EventHandler(this.createProjectbtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 159);
            this.label1.TabIndex = 16;
            this.label1.Text = ">";
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(687, 177);
            this.Controls.Add(this.createProjectbtn);
            this.Controls.Add(this.label1);
            this.Name = "MsgBox";
            this.Text = "Msg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createProjectbtn;
        private System.Windows.Forms.Label label1;
    }
}